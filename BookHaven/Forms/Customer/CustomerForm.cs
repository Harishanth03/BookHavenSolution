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
            updateCustomerButton.Visible = false;
            LoadData();
            customerDataGridView.AutoGenerateColumns = false;
        }

        private void LoadData()
        {
            List<Models.Customer> data = new List<Models.Customer>();
            for(int i = 0; i < 10; i++)
            {
                customerDataGridView.Rows.Add(
                    i + 1,
                    "Harishanth",
                    "0771234567",
                    "harishanth08@gmail.com",
                    "Colombo",
                    "Gold",
                    "Admin"
                );
            }

        }



        private void customerAddButton_Click(object sender, EventArgs e)
        {
            addCustomerPanel.Visible = true;
        }

        private void closePictureBoc_Click_1(object sender, EventArgs e)
        {
            addCustomerPanel.Visible = false;
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

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == customerDataGridView.Columns["deleteColum"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Deleting record with ID: {id}");
                }
            }

            if(e.ColumnIndex == customerDataGridView.Columns["editColumn"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string name = customerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string phone = customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string email = customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                string address = customerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString(); 
                string membership = customerDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(); 



                AddCustomerButton.Visible = false;
                updateCustomerButton.Visible = true;
                addCustomerPanel.Visible = true;
                customerNameTextBox.Text = name.ToString();
                phoneNumberTextBox.Text = phone.ToString();
                emailTextBox.Text = email.ToString();
                addressTextBox.Text = address.ToString();
                memberShipStatusTextBox.Text = membership.ToString();

            }
        }
    }
}
