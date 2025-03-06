using BookHaven.Forms.Customer;
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
    public partial class DashboardBookHaven: Form
    {
        public DashboardBookHaven()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CustomerForm cus = new CustomerForm();
            cus.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cus);
        }
    }
}
