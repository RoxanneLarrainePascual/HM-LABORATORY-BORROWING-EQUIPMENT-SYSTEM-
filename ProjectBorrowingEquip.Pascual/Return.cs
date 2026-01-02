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
    public partial class Return : BaseForm
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HMLabBorrowingDB;Integrated Security=True";

        public Return()
        {
            InitializeComponent();
            LoadEquipmentList();
        }

        private Dashboard dashboard;

        public Return(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
            LoadEquipmentList();
        }

        private void LoadEquipmentList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT EquipmentName FROM dbo.Equipment";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbEquipment.Items.Add(reader["EquipmentName"].ToString());
                }
            }
        }
       

        private void Return_Load(object sender, EventArgs e)
        {
            
            LoadEquipmentList();

            
            cbQuantityReturned.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cbQuantityReturned.Items.Add(i);
            cbQuantityReturned.SelectedIndex = 0;

           
            cbCondition.Items.Clear();
            cbCondition.Items.Add("Good");
            cbCondition.Items.Add("Bad");
            cbCondition.SelectedIndex = 0;

           
            dtpReturned.Value = DateTime.Today;

            
            cbQuantityReturned.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbEquipment.SelectedIndex = -1;
            cbQuantityReturned.SelectedIndex = 0;
            cbCondition.SelectedIndex = 0;
            dtpReturned.Value = DateTime.Today;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbEquipment.SelectedIndex == -1 || cbQuantityReturned.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            int userId = UserSession.UserID;
            string equipmentName = cbEquipment.SelectedItem.ToString();
            int quantityReturned = int.Parse(cbQuantityReturned.SelectedItem.ToString());
            string condition = cbCondition.SelectedItem.ToString();
            DateTime returnDate = dtpReturned.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateBorrowings = @"UPDATE Borrowings
                                            SET Returned = 1,
                                                ReturnDate = @ReturnDate
                                            WHERE UserID = @UserID
                                              AND EquipmentName = @EquipmentName
                                              AND Returned = 0";

                SqlCommand cmd = new SqlCommand(updateBorrowings, con);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.ExecuteNonQuery();

                string updateEquipment = @"UPDATE dbo.Equipment
                                           SET AvailableQuantity = AvailableQuantity + @Quantity
                                           WHERE EquipmentName = @EquipmentName";

                SqlCommand cmdEquip = new SqlCommand(updateEquipment, con);
                cmdEquip.Parameters.AddWithValue("@Quantity", quantityReturned);
                cmdEquip.Parameters.AddWithValue("@EquipmentName", equipmentName);
                cmdEquip.ExecuteNonQuery();
            }

            MessageBox.Show($"Returned {quantityReturned} of {equipmentName} ({condition}) on {returnDate.ToShortDateString()}");

            dashboard?.LoadTotalBorrowed();
            dashboard?.LoadReturnedToday();
            dashboard?.LoadTotalEquipment();
            dashboard?.LoadLatestBorrowers();

            dashboard?.Show();
            this.Close();
        }

        private void lblBorrow_Click(object sender, EventArgs e)
        {
            BorrowingEquipmentForm borrowForm = new BorrowingEquipmentForm(dashboard);
            borrowForm.StartPosition = FormStartPosition.CenterScreen;
            borrowForm.Show();
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
