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
    public partial class ForgotPassword : Form
    {
        private IMongoCollection<BsonDocument> usersCollection;
        public ForgotPassword()
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
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnRetrievePassword_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var filter = Builders<BsonDocument>.Filter.Eq("email", email);
            var user = usersCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                string password = user["password"].AsString;
                lblPassword.Text = $"Your password is: {password}";
                lblPassword.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            else
            {
                lblPassword.Text = "Email not found.";
            }
        }
    }
}
