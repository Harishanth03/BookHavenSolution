using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms.Dashboard
{
    public partial class StaffControlForm: UserControl
    {
        public StaffControlForm()
        {
            InitializeComponent();
            addStaffPanel.Visible = false;

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            addStaffPanel.Visible = true;
        }

        private void StaffControlForm_Load(object sender, EventArgs e)
        {

        }

        private void closePictureBoc_Click(object sender, EventArgs e)
        {
            addStaffPanel.Visible = false;
        }
    }
}
