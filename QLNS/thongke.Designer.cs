namespace QLNS
{
    partial class thongke
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnExportExcel = new Button();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            btn_export = new Button();
            dateTimePicker_end = new DateTimePicker();
            dateTimePicker_start = new DateTimePicker();
            btn_find = new Button();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1094, 342);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            // 
            // button1
            // 
            button1.Location = new Point(54, 152);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 3;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportExcel);
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(273, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 250);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn thời gian truy vấn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(231, 152);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(138, 48);
            btnExportExcel.TabIndex = 6;
            btnExportExcel.Text = "Báo cáo";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(169, 90);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(169, 46);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleRole = AccessibleRole.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(10, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1101, 678);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1093, 650);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hàng đã xuất";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1093, 650);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hàng đã nhập";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_export);
            groupBox2.Controls.Add(dateTimePicker_end);
            groupBox2.Controls.Add(dateTimePicker_start);
            groupBox2.Controls.Add(btn_find);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(273, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 250);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn thời gian truy vấn";
            // 
            // btn_export
            // 
            btn_export.Location = new Point(231, 152);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(138, 48);
            btn_export.TabIndex = 6;
            btn_export.Text = "Báo cáo";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click_1;
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Format = DateTimePickerFormat.Short;
            dateTimePicker_end.Location = new Point(169, 90);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(200, 23);
            dateTimePicker_end.TabIndex = 5;
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Format = DateTimePickerFormat.Short;
            dateTimePicker_start.Location = new Point(169, 46);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(200, 23);
            dateTimePicker_start.TabIndex = 4;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(54, 152);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(144, 48);
            btn_find.TabIndex = 3;
            btn_find.Text = "Tìm kiếm";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 90);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Đến ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 46);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Từ ngày";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1094, 342);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // thongke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 663);
            Controls.Add(tabControl1);
            Name = "thongke";
            Text = "thongke";
            Load += thongke_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Button btnExportExcel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button btn_export;
        private DateTimePicker dateTimePicker_end;
        private DateTimePicker dateTimePicker_start;
        private Button btn_find;
        private Label label3;
        private Label label4;
    }
}