partial class QLSach
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dataGridView1;

    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        groupBox1 = new GroupBox();
        btnMH = new Button();
        btnLN = new Button();
        btnDCHT = new Button();
        btnGB = new Button();
        btnSearch = new Button();
        button1 = new Button();
        groupBox2 = new GroupBox();
        btn_Search = new Button();
        txtSearch = new TextBox();
        button4 = new Button();
        button3 = new Button();
        btnAdd = new Button();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        txtLoaiHang = new TextBox();
        txtGiaBan = new TextBox();
        txtSoLuong = new TextBox();
        txtTenSanPham = new TextBox();
        txtMaSanPham = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(10, 11);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowTemplate.Height = 24;
        dataGridView1.Size = new Size(1094, 399);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        dataGridView1.Resize += dataGridView1_Resize;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnMH);
        groupBox1.Controls.Add(btnLN);
        groupBox1.Controls.Add(btnDCHT);
        groupBox1.Controls.Add(btnGB);
        groupBox1.Controls.Add(btnSearch);
        groupBox1.Controls.Add(button1);
        groupBox1.Location = new Point(12, 435);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(442, 216);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Tìm kiếm theo danh mục";
        groupBox1.Enter += dataGridView1_Resize;
        // 
        // btnMH
        // 
        btnMH.Location = new Point(236, 149);
        btnMH.Name = "btnMH";
        btnMH.Size = new Size(140, 48);
        btnMH.TabIndex = 5;
        btnMH.Text = "Mô Hình";
        btnMH.UseVisualStyleBackColor = true;
        btnMH.Click += btnMH_Click;
        // 
        // btnLN
        // 
        btnLN.Location = new Point(236, 95);
        btnLN.Name = "btnLN";
        btnLN.Size = new Size(140, 48);
        btnLN.TabIndex = 4;
        btnLN.Text = "Đồ lưu niệm";
        btnLN.UseVisualStyleBackColor = true;
        btnLN.Click += btnLN_Click;
        // 
        // btnDCHT
        // 
        btnDCHT.Location = new Point(236, 41);
        btnDCHT.Name = "btnDCHT";
        btnDCHT.Size = new Size(140, 48);
        btnDCHT.TabIndex = 3;
        btnDCHT.Text = "Dụng cụ học tập";
        btnDCHT.UseVisualStyleBackColor = true;
        btnDCHT.Click += btnDCHT_Click;
        // 
        // btnGB
        // 
        btnGB.Location = new Point(45, 149);
        btnGB.Name = "btnGB";
        btnGB.Size = new Size(140, 48);
        btnGB.TabIndex = 2;
        btnGB.Text = "Gấu bông";
        btnGB.UseVisualStyleBackColor = true;
        btnGB.Click += btnGB_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(45, 95);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(140, 48);
        btnSearch.TabIndex = 1;
        btnSearch.Text = "Sách";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // button1
        // 
        button1.Location = new Point(45, 41);
        button1.Name = "button1";
        button1.Size = new Size(140, 48);
        button1.TabIndex = 0;
        button1.Text = "Hiển thị tất cả";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btn_Search);
        groupBox2.Controls.Add(txtSearch);
        groupBox2.Controls.Add(button4);
        groupBox2.Controls.Add(button3);
        groupBox2.Controls.Add(btnAdd);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(txtLoaiHang);
        groupBox2.Controls.Add(txtGiaBan);
        groupBox2.Controls.Add(txtSoLuong);
        groupBox2.Controls.Add(txtTenSanPham);
        groupBox2.Controls.Add(txtMaSanPham);
        groupBox2.Location = new Point(499, 435);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(605, 216);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Các chức năng khác";
        // 
        // btn_Search
        // 
        btn_Search.Location = new Point(421, 172);
        btn_Search.Name = "btn_Search";
        btn_Search.Size = new Size(107, 38);
        btn_Search.TabIndex = 13;
        btn_Search.Text = "Tìm kiếm";
        btn_Search.UseVisualStyleBackColor = true;
        btn_Search.Click += btn_Search_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(103, 187);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(286, 23);
        txtSearch.TabIndex = 12;
        // 
        // button4
        // 
        button4.Location = new Point(421, 123);
        button4.Name = "button4";
        button4.Size = new Size(107, 38);
        button4.TabIndex = 11;
        button4.Text = "Xóa";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.Location = new Point(421, 71);
        button3.Name = "button3";
        button3.Size = new Size(107, 38);
        button3.TabIndex = 10;
        button3.Text = "Sửa";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(421, 22);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(107, 38);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += button2_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(103, 141);
        label5.Name = "label5";
        label5.Size = new Size(84, 15);
        label5.TabIndex = 9;
        label5.Text = "Loại sản phẩm";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(103, 112);
        label4.Name = "label4";
        label4.Size = new Size(47, 15);
        label4.TabIndex = 8;
        label4.Text = "Giá bán";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(103, 55);
        label3.Name = "label3";
        label3.Size = new Size(80, 15);
        label3.TabIndex = 7;
        label3.Text = "Tên sản phẩm";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(103, 83);
        label2.Name = "label2";
        label2.Size = new Size(54, 15);
        label2.TabIndex = 6;
        label2.Text = "Số lượng";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(103, 28);
        label1.Name = "label1";
        label1.Size = new Size(79, 15);
        label1.TabIndex = 5;
        label1.Text = "Mã sản phẩm";
        // 
        // txtLoaiHang
        // 
        txtLoaiHang.Location = new Point(207, 138);
        txtLoaiHang.Name = "txtLoaiHang";
        txtLoaiHang.Size = new Size(182, 23);
        txtLoaiHang.TabIndex = 4;
        txtLoaiHang.TextChanged += c_TextChanged;
        // 
        // txtGiaBan
        // 
        txtGiaBan.Location = new Point(207, 109);
        txtGiaBan.Name = "txtGiaBan";
        txtGiaBan.Size = new Size(182, 23);
        txtGiaBan.TabIndex = 3;
        // 
        // txtSoLuong
        // 
        txtSoLuong.Location = new Point(207, 80);
        txtSoLuong.Name = "txtSoLuong";
        txtSoLuong.Size = new Size(182, 23);
        txtSoLuong.TabIndex = 2;
        // 
        // txtTenSanPham
        // 
        txtTenSanPham.Location = new Point(207, 51);
        txtTenSanPham.Name = "txtTenSanPham";
        txtTenSanPham.Size = new Size(182, 23);
        txtTenSanPham.TabIndex = 1;
        // 
        // txtMaSanPham
        // 
        txtMaSanPham.Location = new Point(207, 22);
        txtMaSanPham.Name = "txtMaSanPham";
        txtMaSanPham.ReadOnly = true;
        txtMaSanPham.Size = new Size(182, 23);
        txtMaSanPham.TabIndex = 0;
        // 
        // QLSach
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1116, 663);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(dataGridView1);
        Name = "QLSach";
        Text = "Quản Lý Sách";
        Load += QLSach_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private GroupBox groupBox1;
    private Button btnMH;
    private Button btnLN;
    private Button btnDCHT;
    private Button btnGB;
    private Button btnSearch;
    private Button button1;
    private GroupBox groupBox2;
    private TextBox txtLoaiHang;
    private TextBox txtGiaBan;
    private TextBox txtSoLuong;
    private TextBox txtTenSanPham;
    private TextBox txtMaSanPham;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button btnAdd;
    private Button btn_Search;
    private TextBox txtSearch;
    private Button button4;
    private Button button3;
}
