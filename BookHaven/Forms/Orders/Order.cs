using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms.Orders
{
    public partial class Order: UserControl
    {
        public Order()
        {
            InitializeComponent();
            addOrderPanel.Visible = false;
        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addOrderPanel.Visible = false;
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            addOrderPanel.Visible = true;
        }
    }
}
