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

namespace BookHaven.Forms.Dashboard
{
    public partial class StaffControlForm: UserControl
    {
        public StaffControlForm()
        {
            InitializeComponent();
            addStaffPanel.Visible = false;

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            addStaffPanel.Visible = true;
        }

        private void StaffControlForm_Load(object sender, EventArgs e)
        {

        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addStaffPanel.Visible = false;
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            try
            {
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

                Staff staff = new Staff(staffName, userName, password, email, userRole);
                staff.AddStaff();
                MessageBox.Show("Staff member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addStaffPanel.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
