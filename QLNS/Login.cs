using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace QLNS
{
    public partial class Login : Form
    {
        private IMongoCollection<BsonDocument> usersCollection;

        public Login()
        {
            InitializeComponent();
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLNS");
            usersCollection = database.GetCollection<BsonDocument>("user");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", password);
            var user = usersCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                var Main = new Main();
                Main.Show();
                // Chuyển đến form khác sau khi đăng nhập thành công
                this.Hide();
                Main.FormClosing += (s, args) => Application.Exit();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangky dangky = new dangky();
            dangky.Show();
            this.Hide();
            dangky.FormClosing += (s, args) => this.Show();
        }

        private void forgotPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
            forgotPassword.FormClosing += (s, args) => this.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
            this.Hide();
            changePassword.FormClosing += (s, args) => this.Show();
        }
    }
}
