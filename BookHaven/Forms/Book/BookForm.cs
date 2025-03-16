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
        private BookRespo bookRespotery = new BookRespo();

        public BookForm()
        {
            InitializeComponent();
            addBookPanel.Visible = false;
            this.ActiveControl = addBookPanel;

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

                decimal price = Convert.ToDecimal(bookPriceTextBox.Text);

                int stockQuantity = Convert.ToInt32(bookQuantityTextBox.Text);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Books book = new Books(title, author, isbn, genre, price, stockQuantity);

                bookRespotery.addBook(book);

                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bookDataGridViewShow();

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            
            bookDataGridViewShow();
            updateButton.Visible = false;
        }

        private void bookDataGridViewShow()
        {
            string selectQuery = "SELECT BookID, Title, Author, ISBN, Genre, Price, StockQuantity FROM Book";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    bookDataGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        bookDataGridView.Rows.Add(
                            reader["BookID"],
                            reader["Title"],
                            reader["Author"],
                            reader["ISBN"],
                            reader["Genre"],
                            reader["Price"],
                            reader["StockQuantity"]
                        );
                    }
                }

                con.Close();
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

                decimal price = Convert.ToDecimal(bookPriceTextBox.Text);

                int stockQuantity = Convert.ToInt32(bookQuantityTextBox.Text);

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Books bookUpdate = new Books(title, author, isbn, genre, price, stockQuantity);
                bool isUpdated  = BookRespo.updateBook( selectedBookID ,bookUpdate);

                if(isUpdated)
                {
                    ClearFields();

                    addBookPanel.Visible=false;

                    bookDataGridViewShow();
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting staff: " + ex.Message);
                throw;
            }
        }
    }
}
