namespace QLNS
{
    partial class Nhapkho
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
            button1 = new Button();
            btn_ex = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1094, 399);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_ex);
            groupBox1.Location = new Point(12, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1092, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(6, 82);
            button1.Name = "button1";
            button1.Size = new Size(121, 56);
            button1.TabIndex = 1;
            button1.Text = "Xuất ra file Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_ex
            // 
            btn_ex.Location = new Point(6, 22);
            btn_ex.Name = "btn_ex";
            btn_ex.Size = new Size(121, 54);
            btn_ex.TabIndex = 0;
            btn_ex.Text = "Chọn File";
            btn_ex.UseMnemonic = false;
            btn_ex.UseVisualStyleBackColor = true;
            btn_ex.Click += btn_ex_Click;
            // 
            // Nhapkho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 663);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Nhapkho";
            Text = "Nhapkho";
            Load += Nhapkho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btn_ex;
        private Button button1;
    }
}