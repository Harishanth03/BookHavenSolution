using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookHaven.Forms.Customer
{
    public partial class CustomerForm: UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();
            addCustomerPanel.Visible = false;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            addCustomerPanel.Visible = true;
        }

        private void closePictureBoc_Click_1(object sender, EventArgs e)
        {
            addCustomerPanel.Visible = false;
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            DashboardBookHaven dashboardBookHav = this.FindForm() as DashboardBookHaven;

            if(dashboardBookHav != null)
            {
                dashboardBookHav.LoadUserControl(new PurchaseHistory());
            }
            else
            {
                MessageBox.Show("Error: Could not find Dashboard.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            


        }
    }
}
