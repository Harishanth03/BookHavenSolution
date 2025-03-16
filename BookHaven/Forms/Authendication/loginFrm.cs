using BookHaven.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class loginFrm: Form
    {

        public static string userRole;
        public static string staffName;
        public static int staffID;

        public loginFrm()
        {
            InitializeComponent();
        }

        //set password visible to false
        private bool passwordVisible = false;


        private void loginFrm_Load(object sender, EventArgs e)
        {
           eyeIcon.Image = Properties.Resources.visibility_off;
           PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            if(passwordVisible)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                eyeIcon.Image = Properties.Resources.visibility_off;
                passwordVisible = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                eyeIcon.Image = Properties.Resources.visibility;
                passwordVisible = true;
            }
        }

        private void clear()
        {
            usernameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Username Name is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Password is required!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userName = usernameTextBox.Text;
            string password = PasswordTextBox.Text;


            if(StaffRepository.LoginStaff(userName , password , out userRole , out staffName , out staffID))
            {
                MessageBox.Show($"Hello {staffID} your Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardBookHaven dashboard = new DashboardBookHaven();

                this.Hide();

                dashboard.Show();
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
