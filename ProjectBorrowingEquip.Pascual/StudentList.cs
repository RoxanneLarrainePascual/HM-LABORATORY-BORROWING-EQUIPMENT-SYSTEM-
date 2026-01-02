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

namespace ProjectBorrowingEquip.Pascual
{
    public partial class StudentList : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMLabBorrowingDB;Integrated Security=True";

        private Dashboard dashboard;
        public StudentList(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents(string search = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT UserID, FullName FROM Users WHERE FullName LIKE @search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", $"%{search}%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;

                dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudents.ReadOnly = true;
                dgvStudents.AllowUserToAddRows = false;
                dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearchStudent.Text.Trim());
        }

        private void lblReturns_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return(dashboard);
            returnForm.StartPosition = FormStartPosition.CenterScreen;
            returnForm.Show();
            this.Close();
        }

        private void lblEquipment_Click(object sender, EventArgs e)
        {

            EquipmentList form = new EquipmentList(dashboard);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();

            this.Close();
        }

        private void lblBorrow_Click(object sender, EventArgs e)
        {
            BorrowingEquipmentForm borrowForm = new BorrowingEquipmentForm(dashboard);
            borrowForm.StartPosition = FormStartPosition.CenterScreen;
            borrowForm.Show();

            this.Close();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard != null)
            {
                dashboard.Show();
                this.Close();
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Thank you for using HM LABORATORY BORROWING EQUIPMENT SYSTEM.",
        "Logout",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );

            
            if (dashboard != null && !dashboard.IsDisposed)
            {
                dashboard.Close();
            }

            
            this.Close();

           
            Form1 loginForm = new Form1();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();

        }
    }
}
    
