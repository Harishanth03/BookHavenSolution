using BookHaven.Forms.Book;
using BookHaven.Forms.Customer;
using BookHaven.Forms.Dashboard;
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
            DashbaordForm DashbaordFrm = new DashbaordForm();
            DashbaordFrm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(DashbaordFrm);
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CustomerForm cus = new CustomerForm();
            cus.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cus);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            DashbaordForm DashbaordFrm = new DashbaordForm();
            DashbaordFrm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(DashbaordFrm);
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            BookForm book = new BookForm();
            book.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(book);
        }
    }
}
