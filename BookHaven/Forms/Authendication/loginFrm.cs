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
            string userName = usernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string userRole;

            Staff staff = new Staff("", userName , password , "" , "");
            if(staff.login(userName , password , out userRole))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardBookHaven dashboardBookHaven = new DashboardBookHaven(userRole);
                dashboardBookHaven.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
