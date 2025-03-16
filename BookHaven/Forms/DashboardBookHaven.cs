using BookHaven.Forms.Book;
using BookHaven.Forms.Customer;
using BookHaven.Forms.Dashboard;
using BookHaven.Forms.Orders;
using BookHaven.Forms.POS;
using BookHaven.Forms.Report;
using BookHaven.Forms.Suppliers;
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

        private string userRole;

        public DashboardBookHaven()
        {
            InitializeComponent();
            DashbaordForm DashbaordFrm = new DashbaordForm();
            DashbaordFrm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(DashbaordFrm);

            //userRole = role;
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

        private void orderButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Order orderFrm = new Order();
            orderFrm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(orderFrm);
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SupplierForm supplierFrm = new SupplierForm();
            supplierFrm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(supplierFrm);
        }

        //=============================================== Access Control ===========================================================

        private void AccessControl()
        {
            if (userRole == "SalesClerk")
            {
                reportButton.Visible = false;
                supplierButton.Visible = false;
                reportButton.Visible = false;

            }
            else if (userRole == "Admin")
            {
                pointOfSaleButton.Visible = false;
                orderButton.Visible = false;
            }
        }

        private void sideBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardBookHaven_Load(object sender, EventArgs e)
        {
            AccessControl();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                loginFrm loginForm = new loginFrm();
                loginForm.Show();
                this.Close();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ReportForm frm = new ReportForm();
            frm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frm);
        }
    }
}
