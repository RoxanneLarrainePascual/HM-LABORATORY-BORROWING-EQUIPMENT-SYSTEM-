using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectBorrowingEquip.Pascual
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMLabBorrowingDB; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        public static class UserSession
        {   
            public static int UserID { get; set; }
            public static string FullName { get; set; }
            public static string Username { get; set; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT UserID, FullName 
                         FROM dbo.Users 
                         WHERE Username=@username AND UserPassword=@password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Store logged-in user globally
                    UserSession.UserID = (int)reader["UserID"];
                    UserSession.FullName = reader["FullName"].ToString();
                    UserSession.Username = username;

                    MessageBox.Show("Login Successful");

                    Dashboard dashboard = new Dashboard();
                    dashboard.StartPosition = FormStartPosition.CenterScreen;
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}
