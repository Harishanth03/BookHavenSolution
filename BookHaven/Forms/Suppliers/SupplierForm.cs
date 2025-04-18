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

namespace BookHaven.Forms.Suppliers
{
    public partial class SupplierForm: UserControl
    {

        private int selectedSupplierID = -1;
        private string currentAction = "add";


        public SupplierForm()
        {
            InitializeComponent();
            supplierSidePanel.Visible = false;
        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            supplierSidePanel.Visible = false;
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            supplierSidePanel.Visible = true;
        }

        public void Clear()
        {
            supplierNametextBox.Clear();
            SupplierPhoneNumberTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
            SupplierTypeComboBox.SelectedIndex = -1;
        }



        //============================================================================ Add Supplier =====================================================================================

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = supplierNametextBox.Text;
                string phone = SupplierPhoneNumberTextBox.Text;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;
                string supplierType = SupplierTypeComboBox.SelectedItem?.ToString();
                string contactedPerson = loginFrm.staffName;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(supplierType))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SupplierRespo respo = new SupplierRespo();

                if (currentAction == "update" && selectedSupplierID > 0)
                {
                    Supplier updatedSupplier = new Supplier(selectedSupplierID, name, contactedPerson, phone, email, address, supplierType);
                    bool isUpdated = respo.UpdateSupplier(updatedSupplier);

                    if (isUpdated)
                    {
                        MessageBox.Show("Supplier updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetSupplierForm();
                    }
                }
                else
                {
                    Supplier newSupplier = new Supplier(name, contactedPerson, phone, email, address, supplierType);
                    respo.AddSupplier(newSupplier);
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetSupplierForm();
                }

                LoadSupplierData();
                supplierSidePanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetSupplierForm()
        {
            Clear();
            currentAction = "add";
            selectedSupplierID = -1;
            AddSupplierBtn.Text = "Add Supplier";
            AddSupplierBtn.BackColor = Color.RoyalBlue;
            AddSupplierBtn.ForeColor = Color.White;
        }


        //================================================================= Load Data Grid view ================================================================

        private void LoadSupplierData()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT SupplierID, Name, ContactPerson, Phone, Email, Address, SupplierType FROM Supplier";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        supplierDataGridView.Rows.Clear();

                        while (reader.Read())
                        {
                            supplierDataGridView.Rows.Add(
                                reader["SupplierID"],
                                reader["Name"],
                                reader["ContactPerson"],
                                reader["Phone"],
                                reader["Email"],
                                reader["Address"],
                                reader["SupplierType"]
                            );
                        }
                    }

                    con.Close();
                }
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplierData();
            searchSupplierTextBox.TextChanged += searchSupplierTextBox_TextChanged;


        }

        private void supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ========== EDIT ==========
            if (supplierDataGridView.Columns[e.ColumnIndex].Name == "edit")
            {
                supplierSidePanel.Visible = true;
                AddSupplierBtn.Text = "Update";
                AddSupplierBtn.FillColor = Color.FromArgb(255, 193, 7);  
                AddSupplierBtn.ForeColor = Color.White;
                currentAction = "update";

                selectedSupplierID = Convert.ToInt32(supplierDataGridView.Rows[e.RowIndex].Cells["supplierID"].Value);

                supplierNametextBox.Text = supplierDataGridView.Rows[e.RowIndex].Cells["supplierName"].Value.ToString();
                SupplierPhoneNumberTextBox.Text = supplierDataGridView.Rows[e.RowIndex].Cells["Phone"].Value?.ToString() ?? "";
                emailTextBox.Text = supplierDataGridView.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? "";
                addressTextBox.Text = supplierDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();
                SupplierTypeComboBox.Text = supplierDataGridView.Rows[e.RowIndex].Cells["supplierType"].Value.ToString();
            }

            // ========== DELETE ==========
            if (supplierDataGridView.Columns[e.ColumnIndex].Name == "delete")
            {
                int supplierID = Convert.ToInt32(supplierDataGridView.Rows[e.RowIndex].Cells["supplierID"].Value);
                string supplierName = supplierDataGridView.Rows[e.RowIndex].Cells["supplierName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {supplierName}?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    SupplierRespo respo = new SupplierRespo();
                    bool isDeleted = respo.DeleteSupplier(supplierID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Supplier deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierData();
                        ResetSupplierForm();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void searchSupplierTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchSupplierTextBox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in supplierDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Combine all searchable columns into one string and convert to lowercase
                    string combined = (
                        row.Cells["SupplierName"].Value?.ToString() + " " +
                        row.Cells["ContactPerson"].Value?.ToString() + " " +
                        row.Cells["Phone"].Value?.ToString() + " " +
                        row.Cells["Email"].Value?.ToString() + " " +
                        row.Cells["Address"].Value?.ToString() + " " +
                        row.Cells["SupplierType"].Value?.ToString()
                    ).ToLower();

                    // Show/hide row based on match
                    row.Visible = combined.Contains(keyword);
                }
            }
        }
    }
}
