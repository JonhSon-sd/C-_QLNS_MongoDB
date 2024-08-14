using MongoDB.Driver;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Http;

namespace QLNS
{
    public partial class Banhang : Form
    {
        private readonly MongoDBContext _context;
        public Banhang()
        {
            InitializeComponent();
            _context = new MongoDBContext();
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView2.CellClick += dataGridView2_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấp vào tiêu đề cột
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_msp.Text = selectedRow.Cells["Masanpham"].Value.ToString();
                txt_tensp.Text = selectedRow.Cells["Tensanpham"].Value.ToString();
                txt_giaban.Text = selectedRow.Cells["GiaBan"].Value.ToString();
                //txt_soluong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấp vào tiêu đề cột
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                txt_msp.Text = selectedRow.Cells["Masanpham"].Value.ToString();
                txt_tensp.Text = selectedRow.Cells["Tensanpham"].Value.ToString();
                txt_giaban.Text = selectedRow.Cells["GiaBan"].Value.ToString();
                txt_soluong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txt_giamgia.Text = selectedRow.Cells["GiamGia"].Value.ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                var sachCollection = _context.Saches.Find(_ => true).ToList();
                dataGridView1.DataSource = sachCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            //bảng dữ liệu hàng hóa
            try
            {
                var hoadonCollection = _context.Hoadons.Find(_ => true).ToList();
                dataGridView2.DataSource = hoadonCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox
                int maSanPham = int.Parse(txt_msp.Text);
                string tenSanPham = txt_tensp.Text;
                decimal giaBan = decimal.Parse(txt_giaban.Text);
                int soLuong = int.Parse(txt_soluong.Text);
                decimal giamGia = decimal.Parse(txt_giamgia.Text);

                // Tính tổng tiền
                decimal tongTien = (giaBan * soLuong) - (giaBan * soLuong * giamGia) / 100;

                // Tạo một đối tượng Hoadon
                Hoadon hoadon = new Hoadon
                {
                    MaSanPham = maSanPham,
                    TenSanPham = tenSanPham,
                    GiaBan = giaBan,
                    SoLuong = soLuong,
                    GiamGia = giamGia,
                    TongTien = tongTien
                };

                // Thêm dữ liệu vào bảng Hoadon trong MongoDB
                _context.Hoadons.InsertOne(hoadon);

                MessageBox.Show("Thêm hóa đơn thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác định sản phẩm cần xóa dựa vào mã sản phẩm
                var filter = Builders<Hoadon>.Filter.Eq("MaSanPham", int.Parse(txt_msp.Text));

                // Thực hiện xóa sản phẩm khỏi CSDLd
                _context.Hoadons.DeleteOne(filter);

                // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                LoadData();

                // Xóa dữ liệu trong các TextBox sau khi xóa thành công
                txt_msp.Clear();
                txt_tensp.Clear();
                txt_giaban.Clear();
                txt_soluong.Clear();
                txt_giamgia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();

            var reportForm = new Reportcs();
            reportForm.ReportCompleted += () => LoadData();  // Đăng ký sự kiện

            reportForm.Show();

        }

        private void Banhang_Load(object sender, EventArgs e)
        {

        }
    }
}
