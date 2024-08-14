namespace QLNS
{
    partial class ForgotPassword
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnRetrievePassword = new Button();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập Email đăng ký";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(209, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnRetrievePassword
            // 
            btnRetrievePassword.BackColor = Color.FromArgb(255, 128, 0);
            btnRetrievePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRetrievePassword.ForeColor = Color.White;
            btnRetrievePassword.Location = new Point(166, 171);
            btnRetrievePassword.Name = "btnRetrievePassword";
            btnRetrievePassword.Size = new Size(127, 42);
            btnRetrievePassword.TabIndex = 2;
            btnRetrievePassword.Text = "Retrieve Password";
            btnRetrievePassword.UseVisualStyleBackColor = false;
            btnRetrievePassword.Click += btnRetrievePassword_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(255, 128, 0);
            lblPassword.Location = new Point(93, 112);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(74, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "PASSWORD :";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 49, 83);
            ClientSize = new Size(481, 240);
            Controls.Add(lblPassword);
            Controls.Add(btnRetrievePassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnRetrievePassword;
        private Label lblPassword;
    }
}