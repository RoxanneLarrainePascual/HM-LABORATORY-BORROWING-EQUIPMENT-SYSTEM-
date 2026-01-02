using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectBorrowingEquip.Pascual.Form1;

namespace ProjectBorrowingEquip.Pascual
{

 
    public partial class Dashboard : Form
    {

        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMLabBorrowingDB; Integrated Security=True";

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = $"HELLO !! {UserSession.FullName}";
            LoadTotalBorrowed();
            LoadReturnedToday();
            LoadTotalEquipment();
            LoadLatestBorrowers();

            
            timer1.Interval = 5000; 
            timer1.Start();
        }

        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
           
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadTotalBorrowed();
            LoadReturnedToday();
            LoadTotalEquipment();
            LoadLatestBorrowers();
        }

        public void LoadTotalBorrowed()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT SUM(Quantity)
                         FROM Borrowings
                         WHERE Returned = 0";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                object result = cmd.ExecuteScalar();
                lblTotalBorrowed.Text = result != DBNull.Value ? result.ToString() : "0";
            }
        }


        public void LoadReturnedToday()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Borrowings
                                 WHERE Returned = 1
                                 AND CAST(ReturnDate AS DATE) = CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                lblReturnedToday.Text = cmd.ExecuteScalar().ToString();
            }
        }
        public void LoadTotalEquipment()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                string totalQuery = "SELECT SUM(TotalQuantity) FROM dbo.Equipment"; 
                SqlCommand totalCmd = new SqlCommand(totalQuery, con);
                object totalResult = totalCmd.ExecuteScalar();
                int total = totalResult != DBNull.Value ? Convert.ToInt32(totalResult) : 0;

                
                string availableQuery = "SELECT SUM(AvailableQuantity) FROM dbo.Equipment"; 
                SqlCommand availableCmd = new SqlCommand(availableQuery, con);
                object availableResult = availableCmd.ExecuteScalar();
                int available = availableResult != DBNull.Value ? Convert.ToInt32(availableResult) : 0;

                lblTotalEquipment.Text = $"{available} / {total}";
            }
        }

        public void LoadLatestBorrowers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT TOP 5 U.FullName, B.EquipmentName, B.Quantity, B.BorrowDate
                                 FROM Borrowings B
                                 JOIN Users U ON B.UserID = U.UserID
                                 ORDER BY B.BorrowDate DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLatestBorrowers.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalEquipment_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void lblBorrow_Click(object sender, EventArgs e)
        {
            BorrowingEquipmentForm borrowForm = new BorrowingEquipmentForm(this);
            borrowForm.StartPosition = FormStartPosition.CenterScreen; 
            borrowForm.Show();

            this.Hide(); 

        }

        private void lblReturns_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return(this); 
            returnForm.StartPosition = FormStartPosition.CenterScreen;
            returnForm.Show();
            this.Hide();
        }

        private void lblEquipment_Click(object sender, EventArgs e)
        {
            EquipmentList form = new EquipmentList(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

            this.Hide();
        }

        private void lblStudents_Click(object sender, EventArgs e)
        {
            StudentList studentForm = new StudentList(this);
            studentForm.StartPosition = FormStartPosition.CenterScreen;
            studentForm.Show();
        }

        private void panLogout_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using HM LABORATORY BORROWING EQUIPMENT SYSTEM.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
            this.Close();

           
            Form1 loginForm = new Form1();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }
    }
}

