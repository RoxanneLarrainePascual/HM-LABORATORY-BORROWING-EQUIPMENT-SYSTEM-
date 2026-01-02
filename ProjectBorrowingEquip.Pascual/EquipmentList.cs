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
    public partial class EquipmentList : Form
    {
        private Dashboard dashboard;

        public EquipmentList(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
            LoadEquipment();
        }


        private string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMLabBorrowingDB;Integrated Security=True";

        public void LoadEquipment()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                            EquipmentName,
                            TotalQuantity,
                            AvailableQuantity
                         FROM dbo.Equipment";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEquipment.DataSource = dt;
            }

            ColorRows(); 
        }
        private void ColorRows()
        {
            foreach (DataGridViewRow row in dgvEquipment.Rows)
            {
                if (row.Cells["AvailableQuantity"].Value != null)
                {
                    int available = Convert.ToInt32(row.Cells["AvailableQuantity"].Value);

                    if (available == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void EquipmentList_Load(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void lblBorrow_Click(object sender, EventArgs e)
        {
            BorrowingEquipmentForm borrowForm = new BorrowingEquipmentForm(dashboard);
            borrowForm.StartPosition = FormStartPosition.CenterScreen;
            borrowForm.Show();
            this.Close();
        }

        private void lblReturns_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return(dashboard);
            returnForm.StartPosition = FormStartPosition.CenterScreen;
            returnForm.Show();
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

        private void lblStudents_Click(object sender, EventArgs e)
        {
            StudentList studentForm = new StudentList(dashboard);
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
