using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Model;

namespace BookHaven.Forms.POS
{
    public partial class POS : UserControl
    {
        public int SelectedCustomerID { get; private set; } = 0;
        public int SelectedBookID { get; private set; } = 0;
        private decimal selectedBookPrice = 0;

        public POS()
        {
            InitializeComponent();
            this.customerTableAdapter.Fill(this.customerDataSet.Customer);
            this.bookTableAdapter.Fill(this.bookDataSet.Book);
            StaffNameLable.Text = loginFrm.staffName;
        }

        private void POS_Load(object sender, EventArgs e) { }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedItem is DataRowView selectedRow && selectedRow["CustomerID"] != DBNull.Value)
            {
                SelectedCustomerID = Convert.ToInt32(selectedRow["CustomerID"]);
                Console.WriteLine("Selected Customer ID: " + SelectedCustomerID);
            }
        }

        private void bookNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookNameComboBox.SelectedItem is DataRowView selectedRow)
            {
                if (selectedRow["BookID"] != DBNull.Value)
                    SelectedBookID = Convert.ToInt32(selectedRow["BookID"]);

                if (selectedRow["Price"] != DBNull.Value)
                {
                    selectedBookPrice = Convert.ToDecimal(selectedRow["Price"]);
                    PriceLable.Text = selectedBookPrice.ToString("C2", CultureInfo.CreateSpecificCulture("si-LK"));
                    UpdateTotalPrice();
                }
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (decimal.TryParse(QuantityTextBox.Text, out decimal quantity) && quantity > 0)
            {
                decimal priceTotal = selectedBookPrice * quantity;
                PriceLable.Text = "රු. " + priceTotal.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";
            }
            else
            {
                PriceLable.Text = "රු. " + selectedBookPrice.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";
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
                "රු. " + totalPrice.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-"
            );

            CalculateTotalAmount();
            ClearInputFields();
        }

        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in summaryDataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    string priceText = row.Cells["Price"].Value.ToString().Replace("රු.", "").Replace("/-", "").Trim();
                    if (decimal.TryParse(priceText, NumberStyles.AllowThousands | NumberStyles.Currency, CultureInfo.CreateSpecificCulture("si-LK"), out decimal price))
                    {
                        totalAmount += price;
                    }
                }
            }

            totalAmountLable.Text = "Total Price: රු. " + totalAmount.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";
            UpdateNetRevenue(totalAmount);
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalAmountLable.Text.Replace("Total Price: රු.", "").Replace("/-", "").Trim(), NumberStyles.AllowThousands | NumberStyles.Currency, CultureInfo.CreateSpecificCulture("si-LK"), out decimal totalAmount))
            {
                decimal discount = 0;
                if (!string.IsNullOrEmpty(discountTextBox.Text) && decimal.TryParse(discountTextBox.Text, out discount))
                {
                    if (discount > totalAmount)
                    {
                        MessageBox.Show("Discount cannot be greater than the total amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        discountTextBox.Text = "0";
                        discount = 0;
                    }
                }
                decimal netRevenue = totalAmount - discount;
                netRevenueLable.Text = "Net Revenue: රු. " + netRevenue.ToString("N2", CultureInfo.CreateSpecificCulture("si-LK")) + "/-";
            }
        }

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

        private void processSalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (summaryDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No items to process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (SelectedCustomerID == 0)
                {
                    MessageBox.Show("Please select a valid customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(paymentMethodComboBox.Text))
                {
                    MessageBox.Show("Please select a payment method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalAmount = Convert.ToDecimal(
                    totalAmountLable.Text.Replace("Total Price: රු.", "").Replace("/-", "").Trim(),
                    CultureInfo.CreateSpecificCulture("si-LK")
                );

                decimal discount = 0;
                if (!string.IsNullOrEmpty(discountTextBox.Text))
                    decimal.TryParse(discountTextBox.Text, out discount);

                string paymentMethod = paymentMethodComboBox.Text;
                int salesClerkID = loginFrm.staffID;

                PointOfSales salesTransaction = new PointOfSales(salesClerkID, SelectedCustomerID, totalAmount, paymentMethod, discount);

                List<SalesTransactionDetails> salesTransactionDetails = new List<SalesTransactionDetails>();
                foreach (DataGridViewRow row in summaryDataGridView.Rows)
                {
                    if (row.Cells["bookID"].Value != null && row.Cells["bookQuantity"].Value != null && row.Cells["bookPrice"].Value != null)
                    {
                        int bookID = Convert.ToInt32(row.Cells["bookID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["bookQuantity"].Value);
                        decimal price = Convert.ToDecimal(
                            row.Cells["bookPrice"].Value.ToString().Replace("රු.", "").Replace("/-", "").Trim(),
                            CultureInfo.CreateSpecificCulture("si-LK")
                        );

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
            bookNameComboBox.SelectedIndex = -1;
            paymentMethodComboBox.SelectedIndex = -1;
            SelectedCustomerID = 0;
            SelectedBookID = 0;
        }

        private void ClearInputFields()
        {
            bookNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            PriceLable.Text = "රු. 0.00/-";
            
        }



        private void receiptPrintButton_Click(object sender, EventArgs e)
        {
            if (summaryDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items to print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string transactionID = "TID" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string customerName = customerComboBox.Text;

            string totalAmount = totalAmountLable.Text;
            string discount = discountTextBox.Text;
            string netRevenue = netRevenueLable.Text;

            ReceiptPrint receiptPrinter = new ReceiptPrint(
                transactionID,
                customerName,
                totalAmount,
                discount,
                netRevenue,
                summaryDataGridView
            );

            receiptPrinter.PrintReceipt();
        }
    }
}
