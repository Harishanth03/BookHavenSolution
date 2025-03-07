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
    public partial class DashbaordForm: UserControl
    {
        public DashbaordForm()
        {
            InitializeComponent();
            GraphView graphView = new GraphView();
            graphView.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(graphView);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void lowInventoryBtn_Click(object sender, EventArgs e)
        {
            dashboardPanel.Controls.Clear();
            LowInventoryForm lowInventory = new LowInventoryForm();
            lowInventory.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(lowInventory);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            dashboardPanel.Controls.Clear();
            GraphView graphView = new GraphView();
            graphView.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(graphView);
        }

        private void orderManagmentBtn_Click(object sender, EventArgs e)
        {
            dashboardPanel.Controls.Clear();
            OrderSummaryForm orderSummary = new OrderSummaryForm();
            orderSummary.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(orderSummary);
        }
    }
}
