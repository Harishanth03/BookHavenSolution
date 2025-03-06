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

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addCustomerPanel.Visible = false;
        }
    }
}
