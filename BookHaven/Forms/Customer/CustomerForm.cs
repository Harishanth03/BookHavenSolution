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
using BookHaven.Model;

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
            LoadCustomerData();
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

        private void addCustomerButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string customerName = customerNameTextBox.Text;
                string phoneNumber = phoneNumberTextBox.Text;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;
                string membershipStatus = memberShipStatusTextBox.SelectedItem?.ToString() ?? "Regular"; //check if combobox is selected or set default 

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Customers customer = new Customers(customerName, phoneNumber, address, membershipStatus, email);

                customerRespo.AddCustomer(customer);

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomerData();

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            customerNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            memberShipStatusTextBox.SelectedIndex = -1;
            emailTextBox.Clear();
        }

        //================================================ Load Customer Data ====================================================

        private void LoadCustomerData()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT CustomerID, FullName, Phone, Address, Email,  MembershipStatus, TotalSpent FROM Customer";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        customerDataGridView.Rows.Clear();

                        while (reader.Read())
                        {
                            customerDataGridView.Rows.Add(
                                reader["CustomerID"],
                                reader["FullName"],
                                reader["Phone"],
                                reader["Address"],
                                reader["Email"],
                                reader["MembershipStatus"],
                                reader["TotalSpent"]
                            );
                        }
                    }

                    con.Close();
                }
            }
        }
    }
}
