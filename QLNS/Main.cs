using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace QLNS
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public Main()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_kho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSach());
            ActivateButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Banhang());
            ActivateButton(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nhapkho());
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongke());
            ActivateButton(sender);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void Main_FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btn_kho)
        {
            if (btn_kho != null)
            {
                if (currentButton != (Button)btn_kho)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btn_kho;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_left.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(24, 49, 83);
                previousBtn.ForeColor = Color.Gainsboro;
                previousBtn.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            login.FormClosing += (s, args) => Application.Exit();
            ActivateButton(sender);
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
