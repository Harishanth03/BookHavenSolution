namespace BookHaven
{
    partial class DashboardBookHaven
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.customerButton = new Guna.UI2.WinForms.Guna2Button();
            this.BookButton = new Guna.UI2.WinForms.Guna2Button();
            this.pointOfSaleButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderButton = new Guna.UI2.WinForms.Guna2Button();
            this.supplierButton = new Guna.UI2.WinForms.Guna2Button();
            this.reportButton = new Guna.UI2.WinForms.Guna2Button();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 679);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideBarPanel.BackColor = System.Drawing.Color.White;
            this.sideBarPanel.Controls.Add(this.pictureBox1);
            this.sideBarPanel.Controls.Add(this.dashboardButton);
            this.sideBarPanel.Controls.Add(this.customerButton);
            this.sideBarPanel.Controls.Add(this.BookButton);
            this.sideBarPanel.Controls.Add(this.pointOfSaleButton);
            this.sideBarPanel.Controls.Add(this.orderButton);
            this.sideBarPanel.Controls.Add(this.supplierButton);
            this.sideBarPanel.Controls.Add(this.reportButton);
            this.sideBarPanel.Controls.Add(this.logOutBtn);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(200, 679);
            this.sideBarPanel.TabIndex = 0;
            // 
            // dashboardButton
            // 
            this.dashboardButton.BorderRadius = 5;
            this.dashboardButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboardButton.Checked = true;
            this.dashboardButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.dashboardButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.space_dashboard;
            this.dashboardButton.CustomImages.Image = global::BookHaven.Properties.Resources.space_dashboard_Gray;
            this.dashboardButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.dashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardButton.FillColor = System.Drawing.Color.Transparent;
            this.dashboardButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.dashboardButton.ForeColor = System.Drawing.Color.Gray;
            this.dashboardButton.Location = new System.Drawing.Point(8, 86);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(187, 46);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.TextOffset = new System.Drawing.Point(30, 0);
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BorderRadius = 5;
            this.customerButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.customerButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.customerButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.group_White;
            this.customerButton.CustomImages.Image = global::BookHaven.Properties.Resources.group_Gary;
            this.customerButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.customerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerButton.FillColor = System.Drawing.Color.Transparent;
            this.customerButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.customerButton.ForeColor = System.Drawing.Color.Gray;
            this.customerButton.Location = new System.Drawing.Point(8, 136);
            this.customerButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(187, 46);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Customer";
            this.customerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerButton.TextOffset = new System.Drawing.Point(30, 0);
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BorderRadius = 5;
            this.BookButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BookButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.BookButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.Book_Checked;
            this.BookButton.CustomImages.Image = global::BookHaven.Properties.Resources.Book;
            this.BookButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.BookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookButton.FillColor = System.Drawing.Color.Transparent;
            this.BookButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.BookButton.ForeColor = System.Drawing.Color.Gray;
            this.BookButton.Location = new System.Drawing.Point(8, 186);
            this.BookButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(187, 46);
            this.BookButton.TabIndex = 3;
            this.BookButton.Text = "Book";
            this.BookButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookButton.TextOffset = new System.Drawing.Point(30, 0);
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // pointOfSaleButton
            // 
            this.pointOfSaleButton.BorderRadius = 5;
            this.pointOfSaleButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.pointOfSaleButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.pointOfSaleButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointOfSaleButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.pointOfSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointOfSaleButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.POS_CHecked;
            this.pointOfSaleButton.CustomImages.Image = global::BookHaven.Properties.Resources.POS;
            this.pointOfSaleButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pointOfSaleButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.pointOfSaleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pointOfSaleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pointOfSaleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pointOfSaleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pointOfSaleButton.FillColor = System.Drawing.Color.Transparent;
            this.pointOfSaleButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.pointOfSaleButton.ForeColor = System.Drawing.Color.Gray;
            this.pointOfSaleButton.Location = new System.Drawing.Point(8, 236);
            this.pointOfSaleButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pointOfSaleButton.Name = "pointOfSaleButton";
            this.pointOfSaleButton.Size = new System.Drawing.Size(187, 46);
            this.pointOfSaleButton.TabIndex = 7;
            this.pointOfSaleButton.Text = "Point Of Sales";
            this.pointOfSaleButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pointOfSaleButton.TextOffset = new System.Drawing.Point(30, 0);
            this.pointOfSaleButton.Click += new System.EventHandler(this.pointOfSaleButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BorderRadius = 5;
            this.orderButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.orderButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.orderButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.Order_Checked;
            this.orderButton.CustomImages.Image = global::BookHaven.Properties.Resources.Order;
            this.orderButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.orderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderButton.FillColor = System.Drawing.Color.Transparent;
            this.orderButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.orderButton.ForeColor = System.Drawing.Color.Gray;
            this.orderButton.Location = new System.Drawing.Point(8, 286);
            this.orderButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(187, 46);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Order";
            this.orderButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderButton.TextOffset = new System.Drawing.Point(30, 0);
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.BorderRadius = 5;
            this.supplierButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.supplierButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.supplierButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.supplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.Inventory_Checked;
            this.supplierButton.CustomImages.Image = global::BookHaven.Properties.Resources.Supplier;
            this.supplierButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.supplierButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.supplierButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supplierButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supplierButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supplierButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supplierButton.FillColor = System.Drawing.Color.Transparent;
            this.supplierButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.supplierButton.ForeColor = System.Drawing.Color.Gray;
            this.supplierButton.Location = new System.Drawing.Point(8, 336);
            this.supplierButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(187, 46);
            this.supplierButton.TabIndex = 5;
            this.supplierButton.Text = "Supplier";
            this.supplierButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.supplierButton.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // reportButton
            // 
            this.reportButton.BorderRadius = 5;
            this.reportButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.reportButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.reportButton.CheckedState.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.CustomImages.CheckedImage = global::BookHaven.Properties.Resources.Report_Checked;
            this.reportButton.CustomImages.Image = global::BookHaven.Properties.Resources.Report;
            this.reportButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportButton.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.reportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportButton.FillColor = System.Drawing.Color.Transparent;
            this.reportButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.reportButton.ForeColor = System.Drawing.Color.Gray;
            this.reportButton.Location = new System.Drawing.Point(8, 386);
            this.reportButton.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(187, 46);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Report";
            this.reportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportButton.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BorderRadius = 5;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.CustomImages.Image = global::BookHaven.Properties.Resources.SignOut;
            this.logOutBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logOutBtn.CustomImages.ImageSize = new System.Drawing.Size(23, 23);
            this.logOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.logOutBtn.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(8, 438);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(8, 4, 8, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(187, 46);
            this.logOutBtn.TabIndex = 10;
            this.logOutBtn.Text = "Logout Account";
            this.logOutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logOutBtn.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookHaven.Properties.Resources.BH_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(22, 20, 22, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardBookHaven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 687);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1154, 669);
            this.Name = "DashboardBookHaven";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardBookHaven";
            this.sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel sideBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
        private Guna.UI2.WinForms.Guna2Button customerButton;
        private Guna.UI2.WinForms.Guna2Button BookButton;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2Button supplierButton;
        private Guna.UI2.WinForms.Guna2Button reportButton;
        private Guna.UI2.WinForms.Guna2Button pointOfSaleButton;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
    }
}