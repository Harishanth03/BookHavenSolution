using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms.Book
{
    public partial class BookForm: UserControl
    {
        public BookForm()
        {
            InitializeComponent();
            addBookPanel.Visible = false;
        }

        private void bookAddButton_Click(object sender, EventArgs e)
        {
            addBookPanel.Visible = true;
        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addBookPanel.Visible = false;
        }
    }
}
