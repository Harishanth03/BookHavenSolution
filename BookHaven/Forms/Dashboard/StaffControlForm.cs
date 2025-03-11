using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Model;
using System.Data.SqlClient;

namespace BookHaven.Forms.Dashboard
{
    public partial class StaffControlForm: UserControl
    {
        public StaffControlForm()
        {
            InitializeComponent();
            addStaffPanel.Visible = false;

        }

        public void clear()
        {
            userNameTextBox.Clear();
            staffNameTextBox.Clear();
            passwordTextBox.Clear();
            emailTextBox.Clear();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            updateButton.Visible = false;
            addStaffPanel.Visible = true;

        }

        private void StaffControlForm_Load(object sender, EventArgs e)
        {
            LodaStaffDetails();
        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addStaffPanel.Visible = false;
        }

        //=============================================== Add staff Click Event Code ===========================================================

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                int staffID = 0;
                string staffName = staffNameTextBox.Text;
                string userName = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string userRole = staffRoleTextBox.SelectedItem?.ToString();

                if(string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userRole))
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Staff staff = new Staff(staffID , staffName, userName, password, email, userRole);
                staff.AddStaff();
                MessageBox.Show("Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LodaStaffDetails();
                clear();
                addStaffPanel.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        //==================================================== Staff Details Data View =======================================================

        public void LodaStaffDetails()
        {
            string selectQuery = "SELECT StaffID, Name, Email, UserName, UserRole, CreatedAt FROM staff";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    staffDataGridview.Rows.Clear();

                    while (reader.Read())
                    {
                        staffDataGridview.Rows.Add(
                            reader["StaffID"],
                            reader["Name"],
                            reader["Email"],
                            reader["UserName"],
                            reader["UserRole"],
                            Convert.ToDateTime(reader["CreatedAt"]).ToString("yyyy-MM-dd HH:mm:ss")
                        );
                    }
                }

                con.Close();
            }
        }

        private int SelectedStaffID;

        private void staffDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (staffDataGridview.Columns[e.ColumnIndex].Name == "edit")
            {
                addStaffBtn.Visible = false;

                addStaffPanel.Visible = true;

                updateButton.Visible = true;

                passwordTextBox.Enabled = false;

                userNameTextBox.Enabled = false;

                SelectedStaffID = Convert.ToInt32(staffDataGridview.Rows[e.RowIndex].Cells["StaffID"].Value);
                staffNameTextBox.Text = staffDataGridview.Rows[e.RowIndex].Cells["staffName"].Value.ToString();
                emailTextBox.Text = staffDataGridview.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                staffRoleTextBox.Text = staffDataGridview.Rows[e.RowIndex].Cells["UserRole"].Value.ToString();

                MessageBox.Show($"Selected Staff ID: {SelectedStaffID}", "Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string staffName = staffNameTextBox.Text;
                string email = emailTextBox.Text;
                string userRole = staffRoleTextBox.SelectedItem?.ToString();

                if(string.IsNullOrEmpty(staffName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userRole))
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Staff staff = new Staff(SelectedStaffID, staffName, "", "", email, userRole);
                staff.UpdateStaff();

                MessageBox.Show("Staff details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LodaStaffDetails(); 
                clear();
                addStaffPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //======================================================= Datagrid view Edit and Delete colum ===========================================


    }
}
