using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using MongoDB.Driver;
using ClosedXML.Excel;
using System.Linq;
using System.Net.Http;

namespace QLNS
{
    public partial class Nhapkho : Form
    {
        private readonly MongoDBContext _context;
        public Nhapkho()
        {
            InitializeComponent();
            _context = new MongoDBContext();
            // Đăng ký provider mã hóa cho Encoding 1252
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            LoadData();

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

        private void btn_ex_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn file Excel để nhập dữ liệu"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelData(filePath);
            }
            LoadData();

        }

        private void ImportExcelData(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        var dataTable = result.Tables[0];

                        // Kiểm tra và lấy index của các cột cần thiết
                        int maSanPhamIndex = GetColumnIndex(dataTable, "Mã sản phẩm");
                        int tenSanPhamIndex = GetColumnIndex(dataTable, "Tên sản phẩm");
                        int soLuongIndex = GetColumnIndex(dataTable, "Số lượng");
                        int giaBanIndex = GetColumnIndex(dataTable, "Giá bán");
                        int loaiHangIndex = GetColumnIndex(dataTable, "Loại Hàng");

                        if (maSanPhamIndex == -1 || tenSanPhamIndex == -1 || soLuongIndex == -1 || giaBanIndex == -1 || loaiHangIndex == -1)
                        {
                            MessageBox.Show("File Excel không chứa các cột cần thiết.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int updatedCount = 0;
                        int errorCount = 0;
                        int insertedCount = 0;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            try
                            {
                                int maSanPham = Convert.ToInt32(row[maSanPhamIndex]);
                                string tenSanPham = row[tenSanPhamIndex].ToString();
                                int soLuong = Convert.ToInt32(row[soLuongIndex]);
                                decimal giaBan = Convert.ToDecimal(row[giaBanIndex]);
                                string loaiHang = row[loaiHangIndex].ToString();
                                DateTime ngayNhap = DateTime.Now.Date;

                                // Tạo bộ lọc để kiểm tra sản phẩm đã tồn tại hay chưa dựa trên mã sản phẩm và ngày (không tính giờ)
                                var filter = Builders<Nhaphang>.Filter.And(
                                    Builders<Nhaphang>.Filter.Eq(nh => nh.Masanpham, maSanPham),
                                    Builders<Nhaphang>.Filter.Eq(nh => nh.NgayNhap, ngayNhap)
                                );

                                var existingNhaphang = _context.Nhaphangs.Find(filter).FirstOrDefault();

                                if (existingNhaphang != null)
                                {
                                    // Nếu sản phẩm đã tồn tại, cập nhật số lượng
                                    var update = Builders<Nhaphang>.Update.Inc(nh => nh.SoLuong, soLuong);
                                    _context.Nhaphangs.UpdateOne(filter, update);
                                    updatedCount++;
                                }
                                else
                                {
                                    // Nếu sản phẩm chưa tồn tại, thêm mới
                                    var nhaphangMoi = new Nhaphang
                                    {
                                        Masanpham = maSanPham,
                                        Tensanpham = tenSanPham,
                                        SoLuong = soLuong,
                                        GiaBan = giaBan,
                                        Loaisanpham = loaiHang,
                                        NgayNhap = ngayNhap
                                    };

                                    _context.Nhaphangs.InsertOne(nhaphangMoi);
                                    insertedCount++;
                                }

                                // Cập nhật bảng hiện tại (ví dụ bảng "Saches")
                                var sachFilter = Builders<Sach>.Filter.Eq(s => s.Masanpham, maSanPham);
                                var sachUpdate = Builders<Sach>.Update.Inc(s => s.SoLuong, soLuong);

                                var result1 = _context.Saches.UpdateOne(sachFilter, sachUpdate);

                                if (result1.ModifiedCount > 0)
                                {
                                    updatedCount++;
                                }
                                else
                                {
                                    errorCount++;
                                }
                            }
                            catch (Exception ex)
                            {
                                errorCount++;
                                Console.WriteLine($"Lỗi xử lý dòng: {ex.Message}");
                            }
                        }

                        MessageBox.Show($"Nhập dữ liệu thành công: {insertedCount} sản phẩm vào Nhaphang.\nCập nhật thành công: {updatedCount} sản phẩm.\nLỗi: {errorCount} sản phẩm.", "Kết quả nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetColumnIndex(DataTable dataTable, string columnName)
        {
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (dataTable.Columns[i].ColumnName.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu dữ liệu ra file Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file
                string filePath = saveFileDialog.FileName;


                try
                {
                    // Lấy dữ liệu từ MongoDB
                    var sachCollection = _context.Saches.Find(FilterDefinition<Sach>.Empty).ToList();

                    // Tạo DataTable để chứa dữ liệu
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Mã sản phẩm", typeof(int));
                    dataTable.Columns.Add("Tên sản phẩm", typeof(string));
                    dataTable.Columns.Add("Số lượng", typeof(int));
                    dataTable.Columns.Add("Giá bán", typeof(decimal));
                    dataTable.Columns.Add("Loại Hàng", typeof(string));

                    // Thêm dữ liệu vào DataTable
                    foreach (var sach in sachCollection)
                    {
                        dataTable.Rows.Add(sach.Masanpham, sach.Tensanpham, sach.SoLuong, sach.GiaBan, sach.Loaisanpham);
                    }

                    // Tạo file Excel
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sách");

                        // Đưa dữ liệu vào worksheet
                        worksheet.Cell(1, 1).InsertTable(dataTable);

                        // Lưu file Excel
                        workbook.SaveAs(filePath);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nhapkho_Load(object sender, EventArgs e)
        {

        }
    }
}
