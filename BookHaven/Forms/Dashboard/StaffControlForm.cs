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
using System.Text.RegularExpressions;

namespace BookHaven.Forms.Dashboard
{
    public partial class StaffControlForm: UserControl
    {

       /* private int SelectedStaffID;*/ // Store the selected staff ID for update


        public StaffControlForm()
        {
            InitializeComponent();
            addStaffPanel.Visible = false;
            staffSearchBox.TextChanged += staffSearchBox_TextChanged;

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

            if(string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Username Name is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(staffNameTextBox.Text))
            {
                MessageBox.Show("Staff Name is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !Regex.IsMatch(emailTextBox.Text , @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Password is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (staffRoleTextBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Staff Role!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Staff newStaff; //i create a reference for Staff class without initionalize because its a abstract class

            if(staffRoleTextBox.SelectedItem.ToString() == "Admin")
            {
                newStaff = new Admin(); //assign the object as Admin
            }
            else
            {
                newStaff = new SalesClerk(); //Assign the object as Sales Clerk
            }

            newStaff.UserName = userNameTextBox.Text;
            newStaff.Email = emailTextBox.Text;
            newStaff.StaffName = staffNameTextBox.Text;
            newStaff.Password = passwordTextBox.Text;

            //Save to darabase

            StaffRepository staffRespo = new StaffRepository();

            staffRespo.AddStaff(newStaff);

            MessageBox.Show($"New {newStaff.UserName} added Successfully in the Book Haven" , "Add Staff" , MessageBoxButtons.OKCancel , MessageBoxIcon.Information);

            clear();

            LodaStaffDetails();

            addStaffPanel.Visible = false;

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

            if (staffDataGridview.Columns[e.ColumnIndex].Name == "delete")
            {
                int staffID = Convert.ToInt32(staffDataGridview.Rows[e.RowIndex].Cells["StaffID"].Value);
                string staffName = staffDataGridview.Rows[e.RowIndex].Cells["staffName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {staffName}?","Confirm Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    StaffRepository.DeleteStaff(staffID);
                    LodaStaffDetails(); // Refresh DataGridView
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = staffNameTextBox.Text;
                string newEmail = emailTextBox.Text;
                string newUserRole = staffRoleTextBox.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail) ||string.IsNullOrWhiteSpace(newUserRole))
                {
                    MessageBox.Show("All fields are required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                StaffRepository repository = new StaffRepository();

                repository.UpdateStaffDetails(SelectedStaffID , newName, newEmail, newUserRole);

                clear();

                addStaffPanel.Visible = false;

                LodaStaffDetails();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = staffSearchBox.Text.Trim().ToLower(); // het the search text on variable

            foreach(DataGridViewRow row in staffDataGridview.Rows)
            {
                if(!row.IsNewRow) // its will skip the new row
                {
                    bool visible = row.Cells["staffName"].Value.ToString().ToLower().Contains(searchText) ||row.Cells["Email"].Value.ToString().ToLower().Contains(searchText) ||row.Cells["UserName"].Value.ToString().ToLower().Contains(searchText);

                    row.Visible = visible;
                }
            }


        }
    }
}
