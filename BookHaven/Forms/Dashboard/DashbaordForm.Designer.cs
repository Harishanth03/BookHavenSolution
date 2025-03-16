namespace BookHaven.Forms.Dashboard
{
    partial class DashbaordForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.staffManagmentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderManagmentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lowInventoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 82);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel1.Location = new System.Drawing.Point(37, 96);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1260, 76);
            this.guna2Panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.staffManagmentBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderManagmentBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lowInventoryBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1252, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // staffManagmentBtn
            // 
            this.staffManagmentBtn.BorderRadius = 3;
            this.staffManagmentBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.staffManagmentBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.staffManagmentBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.staffManagmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffManagmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staffManagmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staffManagmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staffManagmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staffManagmentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffManagmentBtn.FillColor = System.Drawing.Color.White;
            this.staffManagmentBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffManagmentBtn.ForeColor = System.Drawing.Color.Gray;
            this.staffManagmentBtn.Location = new System.Drawing.Point(943, 4);
            this.staffManagmentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffManagmentBtn.Name = "staffManagmentBtn";
            this.staffManagmentBtn.Size = new System.Drawing.Size(305, 57);
            this.staffManagmentBtn.TabIndex = 14;
            this.staffManagmentBtn.Text = "Staff Managment";
            this.staffManagmentBtn.Click += new System.EventHandler(this.staffManagmentBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BorderRadius = 3;
            this.orderBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.orderBtn.Checked = true;
            this.orderBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.orderBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderBtn.FillColor = System.Drawing.Color.Transparent;
            this.orderBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.orderBtn.ForeColor = System.Drawing.Color.Gray;
            this.orderBtn.Location = new System.Drawing.Point(4, 4);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(305, 57);
            this.orderBtn.TabIndex = 11;
            this.orderBtn.Text = "Graph report";
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // orderManagmentBtn
            // 
            this.orderManagmentBtn.BorderRadius = 3;
            this.orderManagmentBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.orderManagmentBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.orderManagmentBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.orderManagmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderManagmentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderManagmentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderManagmentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderManagmentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderManagmentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderManagmentBtn.FillColor = System.Drawing.Color.White;
            this.orderManagmentBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderManagmentBtn.ForeColor = System.Drawing.Color.Gray;
            this.orderManagmentBtn.Location = new System.Drawing.Point(630, 4);
            this.orderManagmentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderManagmentBtn.Name = "orderManagmentBtn";
            this.orderManagmentBtn.Size = new System.Drawing.Size(305, 57);
            this.orderManagmentBtn.TabIndex = 13;
            this.orderManagmentBtn.Text = "Order managment";
            this.orderManagmentBtn.Click += new System.EventHandler(this.orderManagmentBtn_Click);
            // 
            // lowInventoryBtn
            // 
            this.lowInventoryBtn.BorderRadius = 3;
            this.lowInventoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.lowInventoryBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lowInventoryBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.lowInventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowInventoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lowInventoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lowInventoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lowInventoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lowInventoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowInventoryBtn.FillColor = System.Drawing.Color.White;
            this.lowInventoryBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowInventoryBtn.ForeColor = System.Drawing.Color.Gray;
            this.lowInventoryBtn.Location = new System.Drawing.Point(317, 4);
            this.lowInventoryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowInventoryBtn.Name = "lowInventoryBtn";
            this.lowInventoryBtn.Size = new System.Drawing.Size(305, 57);
            this.lowInventoryBtn.TabIndex = 12;
            this.lowInventoryBtn.Text = "Low Inventory";
            this.lowInventoryBtn.Click += new System.EventHandler(this.lowInventoryBtn_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardPanel.BackColor = System.Drawing.Color.White;
            this.dashboardPanel.Location = new System.Drawing.Point(37, 180);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1260, 630);
            this.dashboardPanel.TabIndex = 11;
            // 
            // DashbaordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboardPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashbaordForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.DashbaordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button orderBtn;
        private Guna.UI2.WinForms.Guna2Button staffManagmentBtn;
        private Guna.UI2.WinForms.Guna2Button orderManagmentBtn;
        private Guna.UI2.WinForms.Guna2Button lowInventoryBtn;
        private System.Windows.Forms.Panel dashboardPanel;
    }
}
