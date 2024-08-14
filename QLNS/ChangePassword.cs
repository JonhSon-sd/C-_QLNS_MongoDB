using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace QLNS
{
    public partial class ChangePassword : Form
    {
        private IMongoCollection<BsonDocument> usersCollection;
        private string currentUsername;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ConnectToDatabase()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("QLNS");
            usersCollection = database.GetCollection<BsonDocument>("user");
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var oldPassword = txtOldPassword.Text;
            var newPassword = txtNewPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;

            var filter = Builders<BsonDocument>.Filter.Eq("username", currentUsername) & Builders<BsonDocument>.Filter.Eq("password", oldPassword);
            var user = usersCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                if (newPassword == confirmPassword)
                {
                    var update = Builders<BsonDocument>.Update.Set("password", newPassword);
                    usersCollection.UpdateOne(filter, update);

                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi đổi mật khẩu thành công
                }
                else
                {
                    MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
