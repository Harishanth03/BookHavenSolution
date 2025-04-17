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

namespace BookHaven.Forms.Book
{
    public partial class BookForm: UserControl
    {

        private DataTable bookTable = new DataTable();

        private BookRespo bookRespotery = new BookRespo();

        public BookForm()
        {
            InitializeComponent();
            addBookPanel.Visible = false;
            this.ActiveControl = addBookPanel;
            RestrictedSalesClerkAction();

        }


        private void RestrictedSalesClerkAction()
        {
            if(loginFrm.userRole == "SalesClerk")
            {
                 bookDataGridView.Columns["edit"].Visible = false; 
            bookDataGridView.Columns["delete"].Visible = false; 
            }
        }

        private void bookAddButton_Click(object sender, EventArgs e)
        {
            addBookPanel.Visible = true;
            this.ActiveControl = addBookPanel;

        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addBookPanel.Visible = false;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

            try
            {
                string title = bookNameTextBox.Text;
                string author = authorTextBox.Text;
                string isbn = isbnTextBox.Text;
                string genre = genreComboBox.SelectedItem?.ToString();
                decimal price = Convert.ToDecimal(bookPriceTextBox.Text); // Purchase price
                int quantity = Convert.ToInt32(bookQuantityTextBox.Text);
                int supplierId = Convert.ToInt32(supplierComboBox.SelectedValue);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Books book = new Books(title, author, isbn, genre, price, quantity, supplierId);
                bookRespotery.addBook(book);

                MessageBox.Show("Book and purchase added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookDataGridViewShow();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            bookNameTextBox.Clear();
            authorTextBox.Clear();
            isbnTextBox.Clear();
            bookPriceTextBox.Clear();
            bookQuantityTextBox.Clear();
            genreComboBox.SelectedIndex = -1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.supplierDataSet.Supplier);
            bookDataGridViewShow();
            updateButton.Visible = false;
        }

        private void bookDataGridViewShow()
        {
            string selectQuery = "SELECT BookID, Title, Author, ISBN, Genre, Price, StockQuantity FROM Book";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);

                bookTable.Clear(); // Clear previous data
                adapter.Fill(bookTable);
                con.Close();
            }

            // Clear the DataGridView rows
            bookDataGridView.Rows.Clear();

            // Loop through filtered rows
            foreach (DataRowView rowView in bookTable.DefaultView)
            {
                DataRow row = rowView.Row;

                bookDataGridView.Rows.Add(
                    row["BookID"],
                    row["Title"],
                    row["Author"],
                    row["ISBN"],
                    row["Genre"],
                    row["Price"],
                    row["StockQuantity"]
                );
            }
        }


        private int selectedBookID;

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (bookDataGridView.Columns[e.ColumnIndex].Name == "edit")
            {
                addBookButton.Visible = false;

                updateButton.Visible = true;

                selectedBookID = Convert.ToInt32(bookDataGridView.Rows[e.RowIndex].Cells["bookID"].Value);
                bookNameTextBox.Text = bookDataGridView.Rows[e.RowIndex].Cells["bookName"].Value.ToString();
                genreComboBox.Text = bookDataGridView.Rows[e.RowIndex].Cells["bookGenre"].Value.ToString();
                authorTextBox.Text = bookDataGridView.Rows[e.RowIndex].Cells["author"].Value.ToString();
                isbnTextBox.Text = bookDataGridView.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
                bookPriceTextBox.Text = Convert.ToDecimal(bookDataGridView.Rows[e.RowIndex].Cells["price"].Value).ToString();
                bookQuantityTextBox.Text = Convert.ToInt32(bookDataGridView.Rows[e.RowIndex].Cells["bookQuantity"].Value).ToString();

                addBookPanel.Visible = true;
                bookQuantityTextBox.Enabled = false;

                MessageBox.Show($"Selected Staff ID: {selectedBookID}", "Staff Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (bookDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                selectedBookID = Convert.ToInt32(bookDataGridView.Rows[e.RowIndex].Cells["bookID"].Value);
                string BookName = bookDataGridView.Rows[e.RowIndex].Cells["bookName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {bookNameTextBox.Text}?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    BookRespo.deleteBook(selectedBookID);
                    bookDataGridViewShow(); // Refresh DataGridView
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = bookNameTextBox.Text;
                string author = authorTextBox.Text;
                string isbn = isbnTextBox.Text;
                string genre = genreComboBox.SelectedItem?.ToString();
                decimal price = Convert.ToDecimal(bookPriceTextBox.Text); // Purchase price
                int quantity = Convert.ToInt32(bookQuantityTextBox.Text);
                int supplierId = Convert.ToInt32(supplierComboBox.SelectedValue);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Books book = new Books(title, author, isbn, genre, price, quantity, supplierId);
                bookRespotery.addBook(book);

                MessageBox.Show("Book and purchase added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookDataGridViewShow();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bookSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = bookSearchTextBox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(keyword))
            {
                bookTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                bookTable.DefaultView.RowFilter =
                    $"Title LIKE '%{keyword}%' OR Author LIKE '%{keyword}%' OR ISBN LIKE '%{keyword}%' OR Genre LIKE '%{keyword}%'";
            }

            bookDataGridViewShow();
        }
    }
}
