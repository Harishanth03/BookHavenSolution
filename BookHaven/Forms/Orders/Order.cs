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
using System.Data.SqlClient;

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

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            DashboardBookHaven dashboardBookHav = this.FindForm() as DashboardBookHaven;
            if (dashboardBookHav != null)
            {
                dashboardBookHav.LoadUserControl(new OrderHistory());
            }
            else
            {
                MessageBox.Show("Error: Could not find Dashboard.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);
            this.bookTableAdapter.Fill(this.bookDataSet.Book);
            LoadOrdersIntoGrid();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity;
                decimal bookPrice;

                if (!int.TryParse(quantityTextBox.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rawPrice = PriceLable.Text.Replace("Book Price: රු", "").Trim();

                if (!decimal.TryParse(rawPrice, out bookPrice))
                {
                    MessageBox.Show("Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (customerComboBox.SelectedValue == null || selectedBookComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a customer and a book.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BookHaven.Model.Order newOrder = new BookHaven.Model.Order
                {
                    CustomerID = Convert.ToInt32(customerComboBox.SelectedValue),
                    BookID = Convert.ToInt32(selectedBookComboBox.SelectedValue),
                    Quantity = quantity,
                    Price = bookPrice,
                    DeliveryOption = deliveryOptionComboBox.SelectedItem?.ToString() ?? "Pickup",
                    DeliveryDate = deliveryDatePicker.Value
                };

                bool success = OrderRespo.PlaceOrder(newOrder);

                if (success)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear fields if needed
                    ClearOrderForm();
                    addOrderPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectedBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedBookComboBox.SelectedItem is DataRowView selectedRow)
            {
                if (selectedRow["Price"] != DBNull.Value)
                {
                    decimal price = Convert.ToDecimal(selectedRow["Price"]);
                    PriceLable.Text = "Book Price: රු" + price.ToString();
                }
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedBookComboBox.SelectedItem is DataRowView selectedRow)
            {
                if (decimal.TryParse(selectedRow["Price"].ToString(), out decimal price) &&
                    int.TryParse(quantityTextBox.Text, out int quantity))
                {
                    decimal total = price * quantity;
                    totalPriceTextBox.Text = "Total Price: රු"+ total.ToString("F2"); 
                }
                else
                {
                    totalPriceTextBox.Text = "Total Price: රු.0.00";
                }
            }
        }

        private void ClearOrderForm()
        {
            customerComboBox.SelectedIndex = -1;
            selectedBookComboBox.SelectedIndex = -1;
            deliveryOptionComboBox.SelectedIndex = -1;

            quantityTextBox.Clear();
            PriceLable.Text = "Book Price: රු0.00";
            totalPriceTextBox.Text = "Total Price: රු0.00";

            deliveryDatePicker.Value = DateTime.Now;
        }

        private void orderDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=========================================== Load Order Data into Table =========================================================

        private void LoadOrdersIntoGrid()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT 
                o.OrderID,
                c.FullName AS CustomerName,
                b.Title AS BookTitle,
                od.Quantity,
                od.Price,
                (od.Quantity * od.Price) AS TotalPrice,
                o.DeliveryOption,
                o.EstimatedDeliveryDate,
                o.OrderDate
            FROM Orders o
            INNER JOIN Customer c ON o.CustomerID = c.CustomerID
            INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
            INNER JOIN Book b ON od.BookID = b.BookID
            ORDER BY o.OrderDate DESC;
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    orderDataGridview.Rows.Clear();

                    while (reader.Read())
                    {
                        orderDataGridview.Rows.Add(
                            reader["OrderID"],
                            reader["CustomerName"],
                            reader["BookTitle"],
                            reader["Quantity"],
                            reader["Price"],
                            reader["TotalPrice"],
                            reader["DeliveryOption"],
                            Convert.ToDateTime(reader["EstimatedDeliveryDate"]).ToShortDateString(),
                            Convert.ToDateTime(reader["OrderDate"]).ToShortDateString()
                        );
                    }
                }

                con.Close();
            }
        }

    }
}
