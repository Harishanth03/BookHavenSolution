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
    public partial class GraphView: UserControl
    {
        public GraphView()
        {
            InitializeComponent();
            int totalCustomers = customerRespo.GetTotalCustomer();

            totalCustomersLable.Text = totalCustomers.ToString();

            totalSalesLable.Text = SalesTransactionRepository.getTotalSales().ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
