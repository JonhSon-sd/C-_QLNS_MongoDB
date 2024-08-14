namespace QLNS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel_left = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_kho = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            btnMinsize = new Button();
            btnMaximize = new Button();
            button6 = new Button();
            panel_Body = new Panel();
            pictureBox2 = new PictureBox();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(24, 49, 83);
            panel_left.Controls.Add(button5);
            panel_left.Controls.Add(button4);
            panel_left.Controls.Add(button3);
            panel_left.Controls.Add(button2);
            panel_left.Controls.Add(button1);
            panel_left.Controls.Add(btn_kho);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Dock = DockStyle.Left;
            panel_left.ForeColor = Color.FromArgb(0, 0, 64);
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(200, 799);
            panel_left.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 49, 83);
            button5.Dock = DockStyle.Bottom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.settings;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 669);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(200, 65);
            button5.TabIndex = 6;
            button5.Text = "Đổi mật khẩu";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 49, 83);
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 734);
            button4.Name = "button4";
            button4.Size = new Size(200, 65);
            button4.TabIndex = 5;
            button4.Text = "Đăng xuất";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(24, 49, 83);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.alarm__1_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 395);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(200, 65);
            button3.TabIndex = 4;
            button3.Text = "Nhập Kho";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 49, 83);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.bar_chart1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 330);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(200, 65);
            button2.TabIndex = 3;
            button2.Text = "Kiểm kê";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 49, 83);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.shopping_cart__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 265);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(200, 65);
            button1.TabIndex = 2;
            button1.Text = "Nhập hóa đơn";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_kho
            // 
            btn_kho.BackColor = Color.FromArgb(24, 49, 83);
            btn_kho.Dock = DockStyle.Top;
            btn_kho.FlatAppearance.BorderSize = 0;
            btn_kho.FlatStyle = FlatStyle.Flat;
            btn_kho.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_kho.ForeColor = Color.Gainsboro;
            btn_kho.Image = (Image)resources.GetObject("btn_kho.Image");
            btn_kho.ImageAlign = ContentAlignment.MiddleLeft;
            btn_kho.Location = new Point(0, 200);
            btn_kho.Name = "btn_kho";
            btn_kho.Padding = new Padding(15, 0, 0, 0);
            btn_kho.Size = new Size(200, 65);
            btn_kho.TabIndex = 1;
            btn_kho.Text = "Kho";
            btn_kho.TextAlign = ContentAlignment.MiddleLeft;
            btn_kho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_kho.UseVisualStyleBackColor = false;
            btn_kho.Click += btn_kho_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.SUnday;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(24, 49, 83);
            panel_top.Controls.Add(btnMinsize);
            panel_top.Controls.Add(btnMaximize);
            panel_top.Controls.Add(button6);
            panel_top.Dock = DockStyle.Top;
            panel_top.ForeColor = SystemColors.ControlText;
            panel_top.Location = new Point(200, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1105, 100);
            panel_top.TabIndex = 1;
            panel_top.Paint += panel_top_Paint;
            panel_top.MouseDown += panel_top_MouseDown;
            // 
            // btnMinsize
            // 
            btnMinsize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinsize.FlatAppearance.BorderSize = 0;
            btnMinsize.FlatStyle = FlatStyle.Flat;
            btnMinsize.Font = new Font("Microsoft Sans Serif", 20F);
            btnMinsize.ForeColor = Color.White;
            btnMinsize.Location = new Point(988, 0);
            btnMinsize.Name = "btnMinsize";
            btnMinsize.Size = new Size(34, 43);
            btnMinsize.TabIndex = 2;
            btnMinsize.Text = "-";
            btnMinsize.UseVisualStyleBackColor = true;
            btnMinsize.Click += button8_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 20F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1028, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 43);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "o";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 20F);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.cross_out__2_;
            button6.Location = new Point(1068, 3);
            button6.Name = "button6";
            button6.Size = new Size(34, 43);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel_Body
            // 
            panel_Body.Controls.Add(pictureBox2);
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(200, 100);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1105, 699);
            panel_Body.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.six;
            pictureBox2.Location = new Point(307, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(509, 478);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 32, 38);
            ClientSize = new Size(1305, 799);
            Controls.Add(panel_Body);
            Controls.Add(panel_top);
            Controls.Add(panel_left);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_top;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btn_kho;
        private Button button2;
        private Panel panel_Body;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button btnMinsize;
        private Button btnMaximize;
    }
}