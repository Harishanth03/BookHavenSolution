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

        private int selectedCustomerID;

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (customerDataGridView.Columns[e.ColumnIndex].Name == "edit")
            {
                addCustomerButton.Visible = false;

                addCustomerPanel.Visible = true;

                updateButton.Visible = true;

                selectedCustomerID = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["customerID"].Value);

                customerNameTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["customerName"].Value.ToString();

                phoneNumberTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["phoneNumber"].Value.ToString();

                emailTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["email"].Value.ToString();

                addressTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();

                memberShipStatusTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["membership"].Value.ToString();

                MessageBox.Show($"Selected Customer: {customerNameTextBox.Text}", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (customerDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                if (customerDataGridView.Rows[e.RowIndex].Cells["customerID"].Value == null)
                {
                    MessageBox.Show("Error: Selected row does not contain a valid Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int customerID = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["customerID"].Value);
                string customerName = customerDataGridView.Rows[e.RowIndex].Cells["customerName"].Value.ToString();

                MessageBox.Show($"Attempting to delete Customer ID: {customerID}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debugging Step

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {customerName}?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    bool isDeleted = customerRespo.DeleteCustomer(customerID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomerData(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Customer deletion failed! The customer may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                if(selectedCustomerID <= 0)
                {
                    MessageBox.Show("No customer selected for update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string customerName = customerNameTextBox.Text;

                string phoneNumber = phoneNumberTextBox.Text;

                string email = emailTextBox.Text;

                string address = addressTextBox.Text;

                string membershipStatus = memberShipStatusTextBox.SelectedItem?.ToString() ?? "Regular";

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }

                Customers customerUpdate = new Customers(customerName , phoneNumber ,address , membershipStatus , email);

                bool isUpdated = customerRespo.UpdateCustomerDetails(selectedCustomerID, customerUpdate); //return the Bool data when update is succeed or not

                if(isUpdated)
                {
                    MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCustomerData(); // Refresh DataGridView

                    addCustomerPanel.Visible = false;    

                    ClearFields();
                }
                else
                {

                    MessageBox.Show("Update failed! No changes made or customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch(Exception ex)
            {

                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
