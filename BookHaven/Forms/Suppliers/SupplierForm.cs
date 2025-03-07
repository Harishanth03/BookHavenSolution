using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
