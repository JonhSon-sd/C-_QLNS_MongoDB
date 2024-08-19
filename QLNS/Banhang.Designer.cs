namespace QLNS
{
    partial class Banhang
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
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button5 = new Button();
            txt_msp = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_giamgia = new TextBox();
            txt_soluong = new TextBox();
            txt_giaban = new TextBox();
            txt_tensp = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsdt = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1094, 342);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Location = new Point(12, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 289);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(539, 261);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtsdt);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(txt_msp);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txt_giamgia);
            groupBox2.Controls.Add(txt_soluong);
            groupBox2.Controls.Add(txt_giaban);
            groupBox2.Controls.Add(txt_tensp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(570, 369);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(535, 282);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button5
            // 
            button5.Location = new Point(21, 209);
            button5.Name = "button5";
            button5.Size = new Size(119, 46);
            button5.TabIndex = 14;
            button5.Text = "In Hóa Đơn";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_msp
            // 
            txt_msp.Location = new Point(114, 22);
            txt_msp.Name = "txt_msp";
            txt_msp.Size = new Size(172, 23);
            txt_msp.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 28);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Mã sản phẩm";
            // 
            // button4
            // 
            button4.Location = new Point(420, 108);
            button4.Name = "button4";
            button4.Size = new Size(110, 43);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(420, 40);
            button3.Name = "button3";
            button3.Size = new Size(110, 43);
            button3.TabIndex = 10;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 107);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 9;
            button2.Text = "Sửa ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(304, 40);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 8;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_giamgia
            // 
            txt_giamgia.Location = new Point(114, 139);
            txt_giamgia.Name = "txt_giamgia";
            txt_giamgia.Size = new Size(172, 23);
            txt_giamgia.TabIndex = 7;
            txt_giamgia.Text = "0";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(114, 110);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(172, 23);
            txt_soluong.TabIndex = 6;
            txt_soluong.Text = "1";
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(114, 81);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(172, 23);
            txt_giaban.TabIndex = 5;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(114, 51);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(172, 23);
            txt_tensp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 145);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Giảm giá (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 116);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Giá bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 57);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(146, 222);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(140, 23);
            txtsdt.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 226);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 16;
            label6.Text = "Số điện thoại khách hàng";
            // 
            // Banhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 663);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Banhang";
            Text = "Banhang";
            Load += Banhang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_giamgia;
        private TextBox txt_soluong;
        private TextBox txt_giaban;
        private TextBox txt_tensp;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txt_msp;
        private Label label5;
        private Button button5;
        private TextBox txtsdt;
        private Label label6;
    }
}