using DocumentFormat.OpenXml.InkML;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace QLNS
{
    public partial class Reportcs : Form
    {
        private readonly MongoDBContext _context;
        public event Action ReportCompleted;
        public Reportcs()
        {
            InitializeComponent();
            _context = new MongoDBContext();
            LoadData(); // Load dữ liệu khi form được mở
        }
        private void LoadData()
        {
            // Lấy dữ liệu từ MongoDB và hiển thị trong DataGridView
            try
            {
                var hoadonCollection = _context.Hoadons.Find(_ => true).ToList();
                dataGridView1.DataSource = hoadonCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xem trước in
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            // Sự kiện được gọi khi người dùng thực sự in
            printDocument.EndPrint += new PrintEventHandler(PrintDocument_EndPrint);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            printPreviewDialog.ShowDialog();
        }
        private void OnReportCompleted()
        {
            // Gọi sự kiện khi công việc hoàn thành
            ReportCompleted?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // In trực tiếp
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            printDocument.Print();
            MessageBox.Show("Hóa đơn đã được in !");
            PrintAndTransferData();
            // Gọi sự kiện hoàn thành
            OnReportCompleted();
            UpdateProductQuantities();
            // Đóng form hoặc các xử lý khác
            this.Close();

        }

        private void PrintDocument_EndPrint(object sender, PrintEventArgs e)
        {
            // Gọi chức năng chuyển dữ liệu sau khi in
            PrintAndTransferData();

            // Cập nhật số lượng sản phẩm trong QLSach
            UpdateProductQuantities();
        }
        //public chức năng chuyển
        private void PrintAndTransferData()
        {
            // In hóa đơn
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            PrintPreviewDialog printPreview = new PrintPreviewDialog { Document = printDoc };
            printPreview.ShowDialog();

            // Chuyển dữ liệu sau khi in
            ChuyenDuLieuHoadonSangKiemke();
            LoadData();
        }


        //Chuyển dữ liệu sang bảng kiểm kê
        private void ChuyenDuLieuHoadonSangKiemke()
        {
            var hoadonCollection = _context.Hoadons;
            var kiemkeCollection = _context.Kiemkes;

            // Lấy tất cả dữ liệu từ bảng Hoadon
            var hoadonList = hoadonCollection.Find(_ => true).ToList();

            foreach (var hoadon in hoadonList)
            {
                // Kiểm tra xem sản phẩm đã tồn tại trong bảng Kiemke chưa
                var kiemkeItem = kiemkeCollection.Find(k => k.MaSanPham == hoadon.MaSanPham).FirstOrDefault();

                if (kiemkeItem != null)
                {
                    // Nếu sản phẩm đã tồn tại, cộng dồn các giá trị
                    kiemkeItem.SoLuong = hoadon.SoLuong;
                    kiemkeItem.TongTien = hoadon.TongTien;
                    kiemkeItem.GiaBan = hoadon.GiaBan;  // Cập nhật giá bán mới nếu cần
                    kiemkeItem.GiamGia = hoadon.GiamGia; // Cập nhật giảm giá mới nếu cần

                    // Cập nhật lại dữ liệu trong bảng Kiemke
                    var update = Builders<Kiemke>.Update
                                    .Set(k => k.MaSanPham, kiemkeItem.MaSanPham)
                                    .Set(k => k.TenSanPham, kiemkeItem.TenSanPham)
                                    .Set(k => k.SoLuong, kiemkeItem.SoLuong)
                                    .Set(k => k.TongTien, kiemkeItem.TongTien)
                                    .Set(k => k.GiaBan, kiemkeItem.GiaBan)
                                    .Set(k => k.GiamGia, kiemkeItem.GiamGia)
                                    .Set(k => k.NgayXuat, DateTime.Now);

                    kiemkeCollection.UpdateOne(k => k.Id == kiemkeItem.Id, update);
                }
                else
                {
                    // Nếu sản phẩm chưa tồn tại, thêm sản phẩm vào bảng Kiemke
                    var newKiemkeItem = new Kiemke
                    {
                        MaSanPham = hoadon.MaSanPham,
                        TenSanPham = hoadon.TenSanPham,
                        GiaBan = hoadon.GiaBan,
                        SoLuong = hoadon.SoLuong,
                        GiamGia = hoadon.GiamGia,
                        TongTien = hoadon.TongTien,
                        NgayXuat = DateTime.Now // Thêm ngày xuất hiện tại
                    };

                    kiemkeCollection.InsertOne(newKiemkeItem);
                }
            }

            // Xóa dữ liệu trong bảng Hoadon sau khi chuyển
            //hoadonCollection.DeleteMany(_ => true);
        }



        //tính tổng tiền hóa đơn
        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TongTien"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["TongTien"].Value);
                }
            }
            return total;
        }


        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Thiết lập các thông số
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            float lineHeight = regularFont.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // In tiêu đề hóa đơn
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", titleFont, Brushes.Black, x + 200, y);
            y += lineHeight * 4;

            // In thông tin cửa hàng (nếu có)
            e.Graphics.DrawString("Cửa Hàng Nhà Sách Đại Phát", boldFont, Brushes.Black, x, y);
            y += lineHeight *2;
            e.Graphics.DrawString("Địa chỉ: Nhổn - Hà Nội", regularFont, Brushes.Black, x, y);
            y += lineHeight *2;
            e.Graphics.DrawString("SĐT: 0973452875", regularFont, Brushes.Black, x, y);
            y += lineHeight * 4;

            // In tiêu đề bảng hóa đơn
            e.Graphics.DrawString("Tên Sản Phẩm", boldFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Số Lượng", boldFont, Brushes.Black, x + 200, y);
            e.Graphics.DrawString("Giảm Giá", boldFont, Brushes.Black, x + 300, y);
            e.Graphics.DrawString("Thành Tiền", boldFont, Brushes.Black, x + 400, y);
            y += lineHeight;

            // In đường kẻ dưới tiêu đề
            e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
            y += lineHeight / 2;

            // In dữ liệu hóa đơn từ DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TenSanPham"].Value != null)
                {
                    e.Graphics.DrawString(row.Cells["TenSanPham"].Value.ToString(), regularFont, Brushes.Black, x, y);
                    e.Graphics.DrawString(row.Cells["SoLuong"].Value.ToString(), regularFont, Brushes.Black, x + 200, y);
                    e.Graphics.DrawString(row.Cells["GiamGia"].Value.ToString() + "%", regularFont, Brushes.Black, x + 300, y);
                    e.Graphics.DrawString(row.Cells["TongTien"].Value.ToString() + " VND", regularFont, Brushes.Black, x + 400, y);
                    y += lineHeight;
                }
            }

            // In đường kẻ dưới danh sách sản phẩm
            e.Graphics.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
            y += lineHeight;

            // Tính tổng số tiền
            decimal totalAmount = CalculateTotalAmount();

            // Hiển thị tổng cộng
            e.Graphics.DrawString("Tổng Cộng:", boldFont, Brushes.Black, x + 300, y);
            e.Graphics.DrawString(totalAmount.ToString() + " VND", regularFont, Brushes.Black, x + 400, y);
            y += lineHeight * 2;

            // In ngày tháng và chữ ký
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), regularFont, Brushes.Black, x, y);
            y += lineHeight * 2;
            e.Graphics.DrawString("Chữ Ký Khách Hàng", regularFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Chữ Ký Người Bán", regularFont, Brushes.Black, x + 300, y);

        }

        private void UpdateProductQuantities()
        {
            MessageBox.Show("Bắt đầu cập nhật số lượng sản phẩm");
            var hoadonCollection = _context.Hoadons;
            var qlsachCollection = _context.Saches;

            var hoadonList = hoadonCollection.Find(_ => true).ToList();
            MessageBox.Show($"Số lượng hóa đơn: {hoadonList.Count}");

            foreach (var hoadon in hoadonList)
            {
                var filter = Builders<Sach>.Filter.Eq(s => s.Masanpham, hoadon.MaSanPham);
                var sachItem = qlsachCollection.Find(filter).FirstOrDefault();

                if (sachItem != null)
                {
                    int newQuantity = Math.Max(0, sachItem.SoLuong - hoadon.SoLuong);
                  

                    var update = Builders<Sach>.Update.Set(s => s.SoLuong, newQuantity);
                    var result = qlsachCollection.UpdateOne(filter, update);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy sản phẩm {hoadon.MaSanPham} trong QLSach");
                }
            }
            // Sau khi cập nhật số lượng sản phẩm, xóa dữ liệu trong bảng Hoadon
            hoadonCollection.DeleteMany(_ => true);
        }

        private void Reportcs_Load(object sender, EventArgs e)
        {

        }
    }
}
