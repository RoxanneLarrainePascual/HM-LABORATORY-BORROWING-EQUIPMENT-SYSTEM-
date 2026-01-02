using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectBorrowingEquip.Pascual.Form1;

namespace ProjectBorrowingEquip.Pascual
{
    public partial class BorrowingEquipmentForm : Form
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = HMLabBorrowingDB; Integrated Security=True";

        private Dashboard dashboard;

        public BorrowingEquipmentForm(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;                 
            InitializeQuantityComboBox();      
        }

        private void InitializeQuantityComboBox()
        {
            cbQuantity.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                cbQuantity.Items.Add(i);
            }
            cbQuantity.SelectedIndex = 0;
        }

        private void cbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void LoadEquipment()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT EquipmentID, EquipmentName 
                         FROM Equipment 
                         WHERE AvailableQuantity > 0";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbEquipment.DisplayMember = "EquipmentName";
                cbEquipment.ValueMember = "EquipmentID";
                cbEquipment.DataSource = dt;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbEquipment.SelectedValue == null)
            {
                MessageBox.Show("Please select equipment.");
                return;
            }

            if (cbQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select quantity.");
                return;
            }

            int userId = UserSession.UserID; 
            int equipmentId = (int)cbEquipment.SelectedValue;
            int quantity = Convert.ToInt32(cbQuantity.SelectedItem);
            DateTime borrowDate = dTPDateBorrowed.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    
                    string checkQuery = @"SELECT AvailableQuantity
                                          FROM Equipment
                                          WHERE EquipmentID = @EquipmentID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction);
                    checkCmd.Parameters.AddWithValue("@EquipmentID", equipmentId);

                    object availableObj = checkCmd.ExecuteScalar();
                    if (availableObj == null || (int)availableObj < quantity)
                    {
                        MessageBox.Show("Not enough equipment available.");
                        transaction.Rollback();
                        return;
                    }

                    
                    string insertQuery = @"INSERT INTO Borrowings
                                           (UserID, EquipmentName, Quantity, BorrowDate, Returned)
                                           VALUES (@UserID, @EquipmentName, @Quantity, @BorrowDate, 0)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction);
                    insertCmd.Parameters.AddWithValue("@UserID", userId);
                    insertCmd.Parameters.AddWithValue("@EquipmentName", cbEquipment.Text);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                    insertCmd.ExecuteNonQuery();

                    
                    string updateQuery = @"UPDATE Equipment
                                           SET AvailableQuantity = AvailableQuantity - @Quantity
                                           WHERE EquipmentID = @EquipmentID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction);
                    updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@EquipmentID", equipmentId);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Borrowing recorded successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }

            
            dashboard?.LoadTotalBorrowed();
            dashboard?.LoadReturnedToday();
            dashboard?.LoadTotalEquipment();
            dashboard?.LoadLatestBorrowers();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
           
            cbEquipment.Text = "";

            if (cbQuantity.Items.Count > 0)
                cbQuantity.SelectedIndex = 0;

            dTPDateBorrowed.Value = DateTime.Today;
            dTPExpectedReturn.Value = DateTime.Today;
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
           
            if (dashboard != null)
            {
                dashboard.Show();
                this.Close();
            }
        }

        private void BorrowingEquipmentForm_Load(object sender, EventArgs e)
        {
            LoadEquipment();
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

        private void lblStudents_Click(object sender, EventArgs e)
        {
            StudentList studentForm = new StudentList(dashboard);
            studentForm.StartPosition = FormStartPosition.CenterScreen;
            studentForm.Show();
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
