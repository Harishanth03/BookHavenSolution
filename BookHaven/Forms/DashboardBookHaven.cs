using BookHaven.Forms.Book;
using BookHaven.Forms.Customer;
using BookHaven.Forms.Dashboard;
using BookHaven.Forms.POS;
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
        //=============================================== Dynamically Load The User Control =================================================
        public void LoadUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pointOfSaleButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            POS pos = new POS();
            pos.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(pos);
        }
    }
}
