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
using System.Globalization;

namespace BookHaven.Forms.POS
{
    public partial class POS : UserControl
    {

        public int SelectedCustomerID { get; private set; } // store the selected CustomerID from Combobox
        public int SelectedBookID { get; private set; }     // store the selected BookID from Combobox



        public POS()
        {
            InitializeComponent();
            bookNameComboBox.SelectedIndexChanged += bookNameComboBox_SelectedIndexChanged;
            QuantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            StaffNameLable.Text = loginFrm.staffName;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }


        //================================================== Combo Box selection from Database ==============================================

        private void LoadCustomerComboBox()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT CustomerID, FullName FROM Customer";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable customerTable = new DataTable();
                    adapter.Fill(customerTable);

                    customerComboBox.DataSource = customerTable;  // Bind data to ComboBox
                    customerComboBox.DisplayMember = "FullName";  // Show customer names
                    customerComboBox.ValueMember = "CustomerID";  // Store CustomerID internally
                    customerComboBox.SelectedIndex = -1;
                }
            }
        }

        //==================================================== Combobox selection from database for book ==========================================

        private void LoadBookComboBox()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT BookID, Title , Price FROM Book"; // Fetch BookID & Title

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable bookTable = new DataTable();
                    adapter.Fill(bookTable);

                    bookNameComboBox.DataSource = bookTable;  // Bind DataTable
                    bookNameComboBox.DisplayMember = "Title"; // Show book titles
                    bookNameComboBox.ValueMember = "BookID";  // Store BookID internally
                    bookNameComboBox.SelectedIndex = -1;      // No selection by default
                }
            }
        }

        //=================================================== calculate total ===================================================================

        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in summaryDataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    string priceText = row.Cells["Price"].Value.ToString();

                    priceText = priceText.Replace("රු.", "").Replace("/-", "").Trim();

                    if (decimal.TryParse(priceText, NumberStyles.AllowThousands | NumberStyles.Currency, CultureInfo.CreateSpecificCulture("si-LK"), out decimal price))
                    {
                        totalAmount += price;
                    }
                }
            }

            totalAmountLable.Text = "Total Price: රු. " + totalAmount.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";

            UpdateNetRevenue(totalAmount);

        }



        private void POS_Load(object sender, EventArgs e)
        {
            LoadCustomerComboBox(); // Load customer data when form loads
            LoadBookComboBox();     // Load book data when form loads
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedItem != null)
            {
                DataRowView selectedRow = customerComboBox.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    SelectedCustomerID = Convert.ToInt32(selectedRow["CustomerID"]);
                    Console.WriteLine("Selected Customer ID: " + SelectedCustomerID);
                }
            }
        }

        private decimal selectedBookPrice = 0;

        private void bookNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookNameComboBox.SelectedValue != null)
            {
                
                if (int.TryParse(bookNameComboBox.SelectedValue.ToString(), out int bookID))
                {
                    SelectedBookID = bookID;
                    GetBookPrice(SelectedBookID); // Fetch price from DB
                }
                else
                {
                    Console.WriteLine("Error: SelectedValue is not a valid BookID.");
                }
            }

        }

        private void GetBookPrice(int bookID)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT Price FROM Book WHERE BookID = @BookID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        selectedBookPrice = Convert.ToDecimal(result);
                        PriceLable.Text = selectedBookPrice.ToString("C2", CultureInfo.CreateSpecificCulture("si-LK")); // Update price label
                        UpdateTotalPrice(); // Recalculate total price
                    }
                }
            }
        }



        //================================================== Update Total Price ===============================================================

        private void UpdateTotalPrice()
        {
            if (decimal.TryParse(QuantityTextBox.Text, out decimal quantity) && quantity > 0)
            {
                decimal priceTotal = selectedBookPrice * quantity;
                PriceLable.Text = priceTotal.ToString("C2", CultureInfo.CreateSpecificCulture("si-LK")); // ✅ Use Sri Lankan Currency
            }
            else
            {
                PriceLable.Text = selectedBookPrice.ToString("C2", CultureInfo.CreateSpecificCulture("si-LK")); // ✅ Show base price properly
            }
        }

        private void addToSummaryBtn_Click(object sender, EventArgs e)
        {
            if (SelectedBookID == 0 || SelectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer and a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(QuantityTextBox.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = selectedBookPrice * quantity;


            summaryDataGridView.Rows.Add(
                SelectedBookID,
                customerComboBox.Text,
                bookNameComboBox.Text,
                "රු. " + selectedBookPrice.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-",
                quantity,
                "රු. " + totalPrice.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-" // ✅ Display as රු. 20/-
            );

            CalculateTotalAmount();

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            customerComboBox.SelectedIndex = -1;
            bookNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            PriceLable.Text = "Rs. 00.00"; // Reset price label
        }

        //======================================================= Update Net Revenue ==============================================================

        private void UpdateNetRevenue(decimal totalAmount)
        {
            decimal discount = 0;

            if (!string.IsNullOrEmpty(discountTextBox.Text) && decimal.TryParse(discountTextBox.Text, out discount))
            {
                if (discount > totalAmount)
                {
                    MessageBox.Show("Discount cannot be greater than total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    discountTextBox.Text = "0";
                    discount = 0;
                }
            }

            decimal netRevenue = totalAmount - discount;

            netRevenueLable.Text = "Net Revenue: රු. " + netRevenue + "/-";
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalAmountLable.Text.Replace("Total Price: රු.", "").Replace("/-", "").Trim(), NumberStyles.AllowThousands | NumberStyles.Currency, CultureInfo.CreateSpecificCulture("si-LK"), out decimal totalAmount))
            {
                decimal discount = 0;

                // Try parsing the discount from the discountTextBox
                if (!string.IsNullOrEmpty(discountTextBox.Text) && decimal.TryParse(discountTextBox.Text, out discount))
                {
                    if (discount > totalAmount)
                    {
                        MessageBox.Show("Discount cannot be greater than the total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        discountTextBox.Text = "0";
                        discount = 0;
                    }
                }

                // Calculate Net Revenue (Total Price - Discount)
                decimal netRevenue = totalAmount - discount;

                // Update the Net Revenue Label in real-time
                netRevenueLable.Text = "Net Revenue: රු. " + netRevenue.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";
            }
        }

        private void processSalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(summaryDataGridView.Rows.Count  == 0)
                {
                    MessageBox.Show("No items to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(SelectedBookID == 0)
                {
                    MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(string.IsNullOrEmpty(paymentMethodComboBox.Text))
                {
                    MessageBox.Show("Please select a payment method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalAmount = Convert.ToDecimal(totalAmountLable.Text.Replace("Total Price: රු.", "").Replace("/-", "").Trim(), CultureInfo.CreateSpecificCulture("si-LK"));

                decimal discount = 0;

                if(!string.IsNullOrEmpty(discountTextBox.Text))
                {

                    decimal.TryParse(discountTextBox.Text, out discount);

                }

                string paymentMethod = paymentMethodComboBox.Text;

                int salesClerkID = loginFrm.staffID;

                PointOfSales salesTransaction = new PointOfSales(salesClerkID , SelectedCustomerID , totalAmount , paymentMethod , discount);

                List<SalesTransactionDetails> salesTransactionDetails = new List<SalesTransactionDetails>();

                foreach(DataGridViewRow row in summaryDataGridView.Rows)
                {
                    if (row.Cells["bookID"].Value != null && row.Cells["bookQuantity"].Value != null && row.Cells["bookPrice"].Value != null)
                    {
                        int bookID = Convert.ToInt32(row.Cells["bookID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["bookQuantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["bookPrice"].Value.ToString().Replace("රු.", "").Replace("/-", "").Trim(),CultureInfo.CreateSpecificCulture("si-LK"));
                        salesTransactionDetails.Add(new SalesTransactionDetails(0, bookID, quantity, price));
                    }
                }

                SalesTransactionRepository transactionRepo = new SalesTransactionRepository();

                int transactionID = transactionRepo.SaveTransaction(salesTransaction, salesTransactionDetails);

                if (transactionID > 0)
                {
                    MessageBox.Show("Transaction successful! Transaction ID: " + transactionID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPOS();
                }
                else
                {
                    MessageBox.Show("Transaction failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPOS()
        {
            summaryDataGridView.Rows.Clear();
            totalAmountLable.Text = "Total Price: රු. 0.00/-";
            discountTextBox.Clear();
            netRevenueLable.Text = "Net Revenue: රු. 0.00/-";
            customerComboBox.SelectedIndex = -1;
            paymentMethodComboBox.SelectedIndex = -1;
        }
    }
}
