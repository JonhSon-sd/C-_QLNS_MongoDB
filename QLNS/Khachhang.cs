using DocumentFormat.OpenXml.InkML;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class Khachhang : Form
    {
        private readonly MongoDBContext _context;
        public Khachhang()
        {
            InitializeComponent();
            _context = new MongoDBContext();
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấp vào tiêu đề cột
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtMk.Text = selectedRow.Cells["makhach"].Value.ToString();
                txtTk.Text = selectedRow.Cells["tenkhach"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["sdt"].Value.ToString();
                txtLm.Text = selectedRow.Cells["luotmua"].Value.ToString();
            }
        }

        private void LoadData()
        {

            try
            {
                var sachCollection = _context.Khachhs.Find(_ => true).ToList();
                dataGridView1.DataSource = sachCollection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem mã sản phẩm đã tồn tại hay chưa
                var filter = Builders<khachh>.Filter.Eq("makhach", int.Parse(txtMk.Text));
                var existingSach = _context.Khachhs.Find(filter).FirstOrDefault();

                if (existingSach != null)
                {
                    // Nếu mã sản phẩm đã tồn tại, hiển thị cảnh báo
                    MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã sản phẩm khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng Sách mới với thông tin từ các TextBox
                var Khachmoi = new khachh
                {
                    makhach = int.Parse(txtMk.Text),
                    tenkhach = txtTk.Text,
                    sdt = int.Parse(txtSdt.Text),
                    luotmua = int.Parse(txtLm.Text),
                };

                // Thêm sách vào CSDL MongoDB
                _context.Khachhs.InsertOne(Khachmoi);

                // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                LoadData();

                // Xóa dữ liệu trong các TextBox sau khi thêm thành công
                txtMk.Clear();
                txtTk.Clear();
                txtSdt.Clear();
                txtLm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = Builders<khachh>.Filter.Eq("makhach", int.Parse(txtMk.Text));
                var update = Builders<khachh>.Update
                    .Set("tenkhach", txtTk.Text)
                    .Set("sdt", int.Parse(txtSdt.Text))
                    .Set("luotmua", int.Parse(txtLm.Text));

                _context.Khachhs.UpdateOne(filter, update);

                // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                LoadData();

                // Xóa dữ liệu trong các TextBox sau khi sửa thành công
                txtMk.Clear();
                txtTk.Clear();
                txtSdt.Clear();
                txtLm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác định sản phẩm cần xóa dựa vào mã sản phẩm
                var filter = Builders<khachh>.Filter.Eq("makhach", int.Parse(txtMk.Text));

                // Thực hiện xóa sản phẩm khỏi CSDL
                _context.Khachhs.DeleteOne(filter);

                // Cập nhật lại DataGridView để hiển thị dữ liệu mới
                LoadData();

                // Xóa dữ liệu trong các TextBox sau khi xóa thành công
                txtMk.Clear();
                txtTk.Clear();
                txtSdt.Clear();
                txtLm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text;

                // Kiểm tra xem searchText có phải là số hay không
                FilterDefinition<khachh> filter;
                if (int.TryParse(searchText, out int makhach))
                {
                    // Tìm kiếm theo mã sản phẩm (nếu nhập là số)
                    filter = Builders<khachh>.Filter.Eq("makhach", searchText);
                }
                else
                {
                    // Tìm kiếm theo tên sản phẩm (nếu nhập là chuỗi)
                    filter = Builders<khachh>.Filter.Regex("tenkhach", new BsonRegularExpression($".*{searchText}.*", "i"));
                }

                // Thực hiện truy vấn và nạp dữ liệu vào DataGridView
                var sachCollection = _context.Khachhs.Find(filter).ToList();
                dataGridView1.DataSource = sachCollection;

                // Xóa dữ liệu trong TextBox sau khi tìm kiếm
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
            }

        }
    }
}
