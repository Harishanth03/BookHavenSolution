namespace BookHaven.Forms.Customer
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customerAddButton = new Guna.UI2.WinForms.Guna2Button();
            this.addCustomerPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.phoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.memberShipStatusTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closePictureBoc = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.customerSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.addCustomerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 82);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(297, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Managment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerAddButton
            // 
            this.customerAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerAddButton.BorderRadius = 5;
            this.customerAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerAddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerAddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerAddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerAddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerAddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.customerAddButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddButton.ForeColor = System.Drawing.Color.White;
            this.customerAddButton.Location = new System.Drawing.Point(1095, 97);
            this.customerAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(204, 55);
            this.customerAddButton.TabIndex = 0;
            this.customerAddButton.Text = "Add";
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // addCustomerPanel
            // 
            this.addCustomerPanel.BackColor = System.Drawing.Color.Transparent;
            this.addCustomerPanel.Controls.Add(this.flowLayoutPanel1);
            this.addCustomerPanel.Controls.Add(this.phoneNumberTextBox);
            this.addCustomerPanel.Controls.Add(this.memberShipStatusTextBox);
            this.addCustomerPanel.Controls.Add(this.label8);
            this.addCustomerPanel.Controls.Add(this.label5);
            this.addCustomerPanel.Controls.Add(this.addressTextBox);
            this.addCustomerPanel.Controls.Add(this.customerNameTextBox);
            this.addCustomerPanel.Controls.Add(this.label6);
            this.addCustomerPanel.Controls.Add(this.label4);
            this.addCustomerPanel.Controls.Add(this.label3);
            this.addCustomerPanel.Controls.Add(this.emailTextBox);
            this.addCustomerPanel.Controls.Add(this.label2);
            this.addCustomerPanel.Controls.Add(this.closePictureBoc);
            this.addCustomerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addCustomerPanel.FillColor = System.Drawing.Color.White;
            this.addCustomerPanel.Location = new System.Drawing.Point(692, 82);
            this.addCustomerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerPanel.Name = "addCustomerPanel";
            this.addCustomerPanel.ShadowColor = System.Drawing.Color.Black;
            this.addCustomerPanel.ShadowDepth = 30;
            this.addCustomerPanel.ShadowShift = 2;
            this.addCustomerPanel.Size = new System.Drawing.Size(641, 754);
            this.addCustomerPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addCustomerButton);
            this.flowLayoutPanel1.Controls.Add(this.updateButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 503);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 203);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BorderRadius = 4;
            this.addCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCustomerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCustomerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCustomerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCustomerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.addCustomerButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.White;
            this.addCustomerButton.Location = new System.Drawing.Point(16, 4);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(601, 55);
            this.addCustomerButton.TabIndex = 16;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.BorderRadius = 4;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.updateButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(16, 67);
            this.updateButton.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(601, 55);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update Customer";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.BorderColor = System.Drawing.Color.Gray;
            this.clearButton.BorderRadius = 4;
            this.clearButton.BorderThickness = 1;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearButton.FillColor = System.Drawing.Color.Transparent;
            this.clearButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.Gray;
            this.clearButton.Location = new System.Drawing.Point(16, 130);
            this.clearButton.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(601, 55);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BorderRadius = 2;
            this.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTextBox.DefaultText = "";
            this.phoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(333, 186);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PlaceholderText = "";
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(285, 47);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // memberShipStatusTextBox
            // 
            this.memberShipStatusTextBox.BackColor = System.Drawing.Color.Transparent;
            this.memberShipStatusTextBox.BorderRadius = 2;
            this.memberShipStatusTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.memberShipStatusTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberShipStatusTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.memberShipStatusTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.memberShipStatusTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.memberShipStatusTextBox.ForeColor = System.Drawing.Color.Black;
            this.memberShipStatusTextBox.ItemHeight = 30;
            this.memberShipStatusTextBox.Items.AddRange(new object[] {
            "Gold",
            "Regular",
            "Silver"});
            this.memberShipStatusTextBox.Location = new System.Drawing.Point(17, 427);
            this.memberShipStatusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberShipStatusTextBox.Name = "memberShipStatusTextBox";
            this.memberShipStatusTextBox.Size = new System.Drawing.Size(284, 36);
            this.memberShipStatusTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(11, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "MemberShip Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(327, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderRadius = 2;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.Location = new System.Drawing.Point(333, 306);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(285, 47);
            this.addressTextBox.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BorderRadius = 2;
            this.customerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameTextBox.DefaultText = "";
            this.customerNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.customerNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.customerNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTextBox.Location = new System.Drawing.Point(23, 186);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.PasswordChar = '\0';
            this.customerNameTextBox.PlaceholderText = "";
            this.customerNameTextBox.SelectedText = "";
            this.customerNameTextBox.Size = new System.Drawing.Size(285, 47);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Managment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(327, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderRadius = 2;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(23, 306);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(285, 47);
            this.emailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // closePictureBoc
            // 
            this.closePictureBoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBoc.Image = global::BookHaven.Properties.Resources.close;
            this.closePictureBoc.Location = new System.Drawing.Point(17, 15);
            this.closePictureBoc.Margin = new System.Windows.Forms.Padding(4);
            this.closePictureBoc.Name = "closePictureBoc";
            this.closePictureBoc.Size = new System.Drawing.Size(24, 24);
            this.closePictureBoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePictureBoc.TabIndex = 0;
            this.closePictureBoc.TabStop = false;
            this.closePictureBoc.Click += new System.EventHandler(this.closePictureBoc_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.PurchaseButton);
            this.guna2Panel1.Controls.Add(this.CustomerButton);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 90);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(505, 76);
            this.guna2Panel1.TabIndex = 6;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BorderRadius = 3;
            this.PurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PurchaseButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PurchaseButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.PurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PurchaseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PurchaseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PurchaseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PurchaseButton.FillColor = System.Drawing.Color.White;
            this.PurchaseButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.ForeColor = System.Drawing.Color.Gray;
            this.PurchaseButton.Location = new System.Drawing.Point(256, 12);
            this.PurchaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(240, 53);
            this.PurchaseButton.TabIndex = 1;
            this.PurchaseButton.Text = "Purchase History";
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BorderRadius = 3;
            this.CustomerButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerButton.Checked = true;
            this.CustomerButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CustomerButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.CustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerButton.FillColor = System.Drawing.Color.Transparent;
            this.CustomerButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.CustomerButton.ForeColor = System.Drawing.Color.Gray;
            this.CustomerButton.Location = new System.Drawing.Point(8, 12);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(240, 53);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerSearchTextBox.BorderRadius = 6;
            this.customerSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerSearchTextBox.DefaultText = "";
            this.customerSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerSearchTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerSearchTextBox.IconRight = global::BookHaven.Properties.Resources.search;
            this.customerSearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.customerSearchTextBox.IconRightSize = new System.Drawing.Size(24, 24);
            this.customerSearchTextBox.Location = new System.Drawing.Point(643, 97);
            this.customerSearchTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.PasswordChar = '\0';
            this.customerSearchTextBox.PlaceholderText = "Search";
            this.customerSearchTextBox.SelectedText = "";
            this.customerSearchTextBox.Size = new System.Drawing.Size(443, 55);
            this.customerSearchTextBox.TabIndex = 4;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.customerDataGridView.ColumnHeadersHeight = 50;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.phoneNumber,
            this.email,
            this.address,
            this.membership,
            this.totalSpent,
            this.edit,
            this.delete});
            this.customerDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.customerDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGridView.Location = new System.Drawing.Point(33, 192);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 100;
            this.customerDataGridView.RowTemplate.Height = 35;
            this.customerDataGridView.Size = new System.Drawing.Size(1266, 690);
            this.customerDataGridView.TabIndex = 8;
            this.customerDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.customerDataGridView.ThemeStyle.ReadOnly = false;
            this.customerDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.customerDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Num";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // membership
            // 
            this.membership.HeaderText = "Membership";
            this.membership.MinimumWidth = 6;
            this.membership.Name = "membership";
            // 
            // totalSpent
            // 
            this.totalSpent.HeaderText = "Total Spent";
            this.totalSpent.MinimumWidth = 6;
            this.totalSpent.Name = "totalSpent";
            // 
            // edit
            // 
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "Edit";
            this.edit.Image = global::BookHaven.Properties.Resources.Edit;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // delete
            // 
            this.delete.FillWeight = 50F;
            this.delete.HeaderText = "Delete";
            this.delete.Image = global::BookHaven.Properties.Resources.delete;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.addCustomerPanel);
            this.Controls.Add(this.customerSearchTextBox);
            this.Controls.Add(this.customerAddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addCustomerPanel.ResumeLayout(false);
            this.addCustomerPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button customerAddButton;
        private Guna.UI2.WinForms.Guna2TextBox customerSearchTextBox;
        private Guna.UI2.WinForms.Guna2ShadowPanel addCustomerPanel;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox memberShipStatusTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox customerNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closePictureBoc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button PurchaseButton;
        private Guna.UI2.WinForms.Guna2Button CustomerButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button addCustomerButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSpent;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
