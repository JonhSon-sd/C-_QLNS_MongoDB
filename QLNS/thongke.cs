using MongoDB.Driver;
using ClosedXML.Excel;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http;

namespace QLNS
{
    public partial class thongke : Form
    {
        private readonly MongoDBContext _context;
        public thongke()
        {
            InitializeComponent();
            _context = new MongoDBContext();
            // Khởi tạo DateTimePicker
            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1); // Giá trị mặc định: 1 tháng trước
            dateTimePickerEnd.Value = DateTime.Now;
            // Khởi tạo DateTimePicker cho dataGridView2
            dateTimePicker_start.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker_end.Value = DateTime.Now;

        }
        private void LoadData(DateTime startDate, DateTime endDate)
        {
            try
            {
                var filterBuilder = Builders<Kiemke>.Filter;
                var filter = filterBuilder.Gte(k => k.NgayXuat, startDate) & filterBuilder.Lte(k => k.NgayXuat, endDate);
                var thongkecolection = _context.Kiemkes.Find(filter).ToList();
                dataGridView1.DataSource = thongkecolection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Chức năng mới - Load dữ liệu từ Nhaphang vào dataGridView2
        private void LoadDataForDataGridView2(DateTime startDate, DateTime endDate)
        {
            try
            {
                var filterBuilder = Builders<Nhaphang>.Filter;
                var filter = filterBuilder.Gte(n => n.NgayNhap, startDate) & filterBuilder.Lte(n => n.NgayNhap, endDate);
                var nhaphangCollection = _context.Nhaphangs.Find(filter).ToList();
                dataGridView2.DataSource = nhaphangCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Gọi hàm LoadData với khoảng thời gian được chọn
            LoadData(startDate, endDate);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            var filterBuilder = Builders<Kiemke>.Filter;
            var filter = filterBuilder.Gte(k => k.NgayXuat, startDate) & filterBuilder.Lte(k => k.NgayXuat, endDate);
            var thongkecolection = _context.Kiemkes.Find(filter).ToList();

            if (thongkecolection.Any())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "ThongKe_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("ThongKe");

                        // Tiêu đề cột
                        worksheet.Cell(1, 1).Value = "Mã Sản Phẩm";
                        worksheet.Cell(1, 2).Value = "Tên Sản Phẩm";
                        worksheet.Cell(1, 3).Value = "Giá Bán";
                        worksheet.Cell(1, 4).Value = "Số Lượng";
                        worksheet.Cell(1, 5).Value = "Giảm Giá";
                        worksheet.Cell(1, 6).Value = "Tổng Tiền";
                        worksheet.Cell(1, 7).Value = "Ngày Xuất";

                        // Dữ liệu
                        for (int i = 0; i < thongkecolection.Count; i++)
                        {
                            worksheet.Cell(i + 2, 1).Value = thongkecolection[i].MaSanPham;
                            worksheet.Cell(i + 2, 2).Value = thongkecolection[i].TenSanPham;
                            worksheet.Cell(i + 2, 3).Value = thongkecolection[i].GiaBan;
                            worksheet.Cell(i + 2, 4).Value = thongkecolection[i].SoLuong;
                            worksheet.Cell(i + 2, 5).Value = thongkecolection[i].GiamGia;
                            worksheet.Cell(i + 2, 6).Value = thongkecolection[i].TongTien;
                            worksheet.Cell(i + 2, 7).Value = thongkecolection[i].NgayXuat.ToString("dd/MM/yyyy");
                        }

                        // Lưu file Excel
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chức năng mới - Nút xuất Excel cho dataGridView2
        private void btn_export_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_find_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker_start.Value.Date;
            DateTime endDate = dateTimePicker_end.Value.Date;

            LoadDataForDataGridView2(startDate, endDate);
        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker_start.Value.Date;
            DateTime endDate = dateTimePicker_end.Value.Date;

            var filterBuilder = Builders<Nhaphang>.Filter;
            var filter = filterBuilder.Gte(n => n.NgayNhap, startDate) & filterBuilder.Lte(n => n.NgayNhap, endDate);
            var nhaphangCollection = _context.Nhaphangs.Find(filter).ToList();

            if (nhaphangCollection.Any())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "ThongKe_Nhaphang_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("ThongKe_Nhaphang");

                        // Tiêu đề cột
                        worksheet.Cell(1, 1).Value = "Mã Sản Phẩm";
                        worksheet.Cell(1, 2).Value = "Tên Sản Phẩm";
                        worksheet.Cell(1, 3).Value = "Giá Bán";
                        worksheet.Cell(1, 4).Value = "Số Lượng";
                        worksheet.Cell(1, 5).Value = "Loại Sản Phẩm";
                        worksheet.Cell(1, 6).Value = "Ngày Nhập";

                        // Dữ liệu
                        for (int i = 0; i < nhaphangCollection.Count; i++)
                        {
                            worksheet.Cell(i + 2, 1).Value = nhaphangCollection[i].Masanpham;
                            worksheet.Cell(i + 2, 2).Value = nhaphangCollection[i].Tensanpham;
                            worksheet.Cell(i + 2, 3).Value = nhaphangCollection[i].GiaBan;
                            worksheet.Cell(i + 2, 4).Value = nhaphangCollection[i].SoLuong;
                            worksheet.Cell(i + 2, 5).Value = nhaphangCollection[i].Loaisanpham;
                            worksheet.Cell(i + 2, 6).Value = nhaphangCollection[i].NgayNhap.ToString("dd/MM/yyyy");
                        }

                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thongke_Load(object sender, EventArgs e)
        {

        }
    }
}
