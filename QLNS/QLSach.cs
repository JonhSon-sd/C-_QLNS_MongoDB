using System;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Linq;
using MongoDB.Bson;
using System.Net.Http;

public partial class QLSach : Form
{
    private readonly MongoDBContext _context;

    public QLSach()
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

            txtMaSanPham.Text = selectedRow.Cells["Masanpham"].Value.ToString();
            txtTenSanPham.Text = selectedRow.Cells["Tensanpham"].Value.ToString();
            txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
            txtGiaBan.Text = selectedRow.Cells["GiaBan"].Value.ToString();
            txtLoaiHang.Text = selectedRow.Cells["Loaisanpham"].Value.ToString();
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
    }

    private void dataGridView1_Resize(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        foreach (DataGridViewColumn column in dataGridView1.Columns)
        {
            column.Resizable = DataGridViewTriState.False;
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        SearchProducts("Sách");
    }

    private void SearchProducts(string Loaisanpham)
    {
        try
        {
            var filter = Builders<Sach>.Filter.Eq("Loại Hàng", Loaisanpham); // Tạo điều kiện tìm kiếm
            var sachCollection = _context.Saches.Find(filter).ToList();
            dataGridView1.DataSource = sachCollection;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
        }
    }

    private void btnGB_Click(object sender, EventArgs e)
    {
        SearchProducts("Gấu bông");
    }

    private void btnDCHT_Click(object sender, EventArgs e)
    {
        SearchProducts("Dụng cụ học tập");
    }

    private void btnLN_Click(object sender, EventArgs e)
    {
        SearchProducts("Đồ lưu niệm");
    }

    private void btnMH_Click(object sender, EventArgs e)
    {
        SearchProducts("Mô hình");
    }

    private void c_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            // Kiểm tra xem mã sản phẩm đã tồn tại hay chưa
            var filter = Builders<Sach>.Filter.Eq("Masanpham", int.Parse(txtMaSanPham.Text));
            var existingSach = _context.Saches.Find(filter).FirstOrDefault();

            if (existingSach != null)
            {
                // Nếu mã sản phẩm đã tồn tại, hiển thị cảnh báo
                MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã sản phẩm khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Sách mới với thông tin từ các TextBox
            var sachMoi = new Sach
            {
                Masanpham = int.Parse(txtMaSanPham.Text),
                Tensanpham = txtTenSanPham.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                Loaisanpham = txtLoaiHang.Text
            };

            // Thêm sách vào CSDL MongoDB
            _context.Saches.InsertOne(sachMoi);

            // Cập nhật lại DataGridView để hiển thị dữ liệu mới
            LoadData();

            // Xóa dữ liệu trong các TextBox sau khi thêm thành công
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtLoaiHang.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            var filter = Builders<Sach>.Filter.Eq("Masanpham", int.Parse(txtMaSanPham.Text));
            var update = Builders<Sach>.Update
                .Set("Tensanpham", txtTenSanPham.Text)
                .Set("SoLuong", int.Parse(txtSoLuong.Text))
                .Set("GiaBan", decimal.Parse(txtGiaBan.Text))
                .Set("Loaisanpham", txtLoaiHang.Text);

            _context.Saches.UpdateOne(filter, update);

            // Cập nhật lại DataGridView để hiển thị dữ liệu mới
            LoadData();

            // Xóa dữ liệu trong các TextBox sau khi sửa thành công
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtLoaiHang.Clear();
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
            var filter = Builders<Sach>.Filter.Eq("Masanpham", int.Parse(txtMaSanPham.Text));

            // Thực hiện xóa sản phẩm khỏi CSDL
            _context.Saches.DeleteOne(filter);

            // Cập nhật lại DataGridView để hiển thị dữ liệu mới
            LoadData();

            // Xóa dữ liệu trong các TextBox sau khi xóa thành công
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtLoaiHang.Clear();
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
            FilterDefinition<Sach> filter;
            if (int.TryParse(searchText, out int maSach))
            {
                // Tìm kiếm theo mã sản phẩm (nếu nhập là số)
                filter = Builders<Sach>.Filter.Eq("Masanpham", searchText);
            }
            else
            {
                // Tìm kiếm theo tên sản phẩm (nếu nhập là chuỗi)
                filter = Builders<Sach>.Filter.Regex("Tensanpham", new BsonRegularExpression($".*{searchText}.*", "i"));
            }

            // Thực hiện truy vấn và nạp dữ liệu vào DataGridView
            var sachCollection = _context.Saches.Find(filter).ToList();
            dataGridView1.DataSource = sachCollection;

            // Xóa dữ liệu trong TextBox sau khi tìm kiếm
            txtSearch.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
        }

    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            // Truy vấn tất cả sản phẩm từ cơ sở dữ liệu
            var sachCollection = _context.Saches.Find(_ => true).ToList();

            // Hiển thị kết quả trong DataGridView
            dataGridView1.DataSource = sachCollection;

            // Xóa dữ liệu trong các TextBox
            txtSearch.Clear();
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtSoLuong.Clear();
            txtGiaBan.Clear();
            txtLoaiHang.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi hiển thị tất cả sản phẩm: " + ex.Message);
        }
    }

    private void QLSach_Load(object sender, EventArgs e)
    {

    }
}
