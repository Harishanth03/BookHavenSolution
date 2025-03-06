using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms.Customer
{
    public partial class PurchaseHistory: UserControl
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            DashboardBookHaven dashboardBookHav = this.FindForm() as DashboardBookHaven;

            if(dashboardBookHav != null)
            {
                dashboardBookHav.LoadUserControl(new CustomerForm());
            }
            else
            {
                MessageBox.Show("Error: Could not find Dashboard.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
