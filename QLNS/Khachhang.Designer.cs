namespace QLNS
{
    partial class Khachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Search = new Button();
            txtSearch = new TextBox();
            button4 = new Button();
            button3 = new Button();
            btnAdd = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLm = new TextBox();
            txtSdt = new TextBox();
            txtTk = new TextBox();
            txtMk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1094, 399);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Search);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtLm);
            groupBox2.Controls.Add(txtSdt);
            groupBox2.Controls.Add(txtTk);
            groupBox2.Controls.Add(txtMk);
            groupBox2.Location = new Point(251, 435);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(605, 216);
            groupBox2.TabIndex = 3;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 112);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Lượt mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 55);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 83);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Mã khách hàng";
            // 
            // txtLm
            // 
            txtLm.Location = new Point(207, 109);
            txtLm.Name = "txtLm";
            txtLm.Size = new Size(182, 23);
            txtLm.TabIndex = 4;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(207, 80);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(182, 23);
            txtSdt.TabIndex = 2;
            // 
            // txtTk
            // 
            txtTk.Location = new Point(207, 51);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(182, 23);
            txtTk.TabIndex = 1;
            // 
            // txtMk
            // 
            txtMk.Location = new Point(207, 22);
            txtMk.Name = "txtMk";
            txtMk.ReadOnly = true;
            txtMk.Size = new Size(182, 23);
            txtMk.TabIndex = 0;
            // 
            // Khachhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 663);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Name = "Khachhang";
            Text = "Khachhang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btn_Search;
        private TextBox txtSearch;
        private Button button4;
        private Button button3;
        private Button btnAdd;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLm;
        private TextBox txtSdt;
        private TextBox txtTk;
        private TextBox txtMk;
    }
}