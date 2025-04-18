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

namespace BookHaven.Forms.Suppliers
{
    public partial class SupplierForm: UserControl
    {
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

                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(supplierType))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Supplier supplier = new Supplier(name, contactedPerson, phone, email, address, supplierType); //create supplier OBJ

                SupplierRespo respo = new SupplierRespo();
                respo.AddSupplier(supplier);
                Clear();
                supplierSidePanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
