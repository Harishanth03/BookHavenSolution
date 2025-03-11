namespace BookHaven.Forms.Suppliers
{
    partial class SupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSupplies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.addSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.supplierSidePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SupplierPhoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SupplierTypeTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.addCustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.supplierNametextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closePictureBoc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.supplierSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(277, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier Managment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // supplierDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.supplierDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supplierDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supplierDataGridView.ColumnHeadersHeight = 50;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.supplierName,
            this.ContactPerson,
            this.PhoneNumber,
            this.TotalSupplies});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.supplierDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.supplierDataGridView.Location = new System.Drawing.Point(27, 167);
            this.supplierDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.RowHeadersVisible = false;
            this.supplierDataGridView.RowHeadersWidth = 100;
            this.supplierDataGridView.RowTemplate.Height = 40;
            this.supplierDataGridView.Size = new System.Drawing.Size(1271, 613);
            this.supplierDataGridView.TabIndex = 9;
            this.supplierDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.supplierDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.supplierDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.supplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.supplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.supplierDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.supplierDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.supplierDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.supplierDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.supplierDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.supplierDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.supplierDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.supplierDataGridView.ThemeStyle.ReadOnly = false;
            this.supplierDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.supplierDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.supplierDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.supplierDataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.supplierDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.supplierDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.MinimumWidth = 6;
            this.SupplierID.Name = "SupplierID";
            // 
            // supplierName
            // 
            this.supplierName.HeaderText = "Supplier Name";
            this.supplierName.MinimumWidth = 6;
            this.supplierName.Name = "supplierName";
            // 
            // ContactPerson
            // 
            this.ContactPerson.HeaderText = "Contact Person";
            this.ContactPerson.MinimumWidth = 6;
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // TotalSupplies
            // 
            this.TotalSupplies.HeaderText = "Total Supplies";
            this.TotalSupplies.MinimumWidth = 6;
            this.TotalSupplies.Name = "TotalSupplies";
            // 
            // searchSupplier
            // 
            this.searchSupplier.BorderRadius = 6;
            this.searchSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchSupplier.DefaultText = "";
            this.searchSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchSupplier.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchSupplier.IconRight = global::BookHaven.Properties.Resources.search;
            this.searchSupplier.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchSupplier.IconRightSize = new System.Drawing.Size(24, 24);
            this.searchSupplier.Location = new System.Drawing.Point(27, 97);
            this.searchSupplier.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.PasswordChar = '\0';
            this.searchSupplier.PlaceholderText = "Search";
            this.searchSupplier.SelectedText = "";
            this.searchSupplier.Size = new System.Drawing.Size(443, 55);
            this.searchSupplier.TabIndex = 11;
            // 
            // addSupplier
            // 
            this.addSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSupplier.BorderRadius = 5;
            this.addSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.addSupplier.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplier.ForeColor = System.Drawing.Color.White;
            this.addSupplier.Location = new System.Drawing.Point(1109, 97);
            this.addSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(204, 55);
            this.addSupplier.TabIndex = 10;
            this.addSupplier.Text = "Add Supplier";
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // supplierSidePanel
            // 
            this.supplierSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.supplierSidePanel.Controls.Add(this.SupplierPhoneNumberTextBox);
            this.supplierSidePanel.Controls.Add(this.SupplierTypeTextBox);
            this.supplierSidePanel.Controls.Add(this.clearButton);
            this.supplierSidePanel.Controls.Add(this.addCustomerButton);
            this.supplierSidePanel.Controls.Add(this.label8);
            this.supplierSidePanel.Controls.Add(this.label5);
            this.supplierSidePanel.Controls.Add(this.addressTextBox);
            this.supplierSidePanel.Controls.Add(this.supplierNametextBox);
            this.supplierSidePanel.Controls.Add(this.label6);
            this.supplierSidePanel.Controls.Add(this.label4);
            this.supplierSidePanel.Controls.Add(this.label3);
            this.supplierSidePanel.Controls.Add(this.emailTextBox);
            this.supplierSidePanel.Controls.Add(this.label2);
            this.supplierSidePanel.Controls.Add(this.closePictureBoc);
            this.supplierSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.supplierSidePanel.FillColor = System.Drawing.Color.White;
            this.supplierSidePanel.Location = new System.Drawing.Point(685, 82);
            this.supplierSidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierSidePanel.Name = "supplierSidePanel";
            this.supplierSidePanel.ShadowColor = System.Drawing.Color.Black;
            this.supplierSidePanel.ShadowDepth = 30;
            this.supplierSidePanel.ShadowShift = 2;
            this.supplierSidePanel.Size = new System.Drawing.Size(648, 754);
            this.supplierSidePanel.TabIndex = 12;
            // 
            // SupplierPhoneNumberTextBox
            // 
            this.SupplierPhoneNumberTextBox.BorderRadius = 2;
            this.SupplierPhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierPhoneNumberTextBox.DefaultText = "";
            this.SupplierPhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SupplierPhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SupplierPhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SupplierPhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SupplierPhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierPhoneNumberTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.SupplierPhoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.SupplierPhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierPhoneNumberTextBox.Location = new System.Drawing.Point(333, 186);
            this.SupplierPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SupplierPhoneNumberTextBox.Name = "SupplierPhoneNumberTextBox";
            this.SupplierPhoneNumberTextBox.PasswordChar = '\0';
            this.SupplierPhoneNumberTextBox.PlaceholderText = "";
            this.SupplierPhoneNumberTextBox.SelectedText = "";
            this.SupplierPhoneNumberTextBox.Size = new System.Drawing.Size(285, 47);
            this.SupplierPhoneNumberTextBox.TabIndex = 2;
            // 
            // SupplierTypeTextBox
            // 
            this.SupplierTypeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SupplierTypeTextBox.BorderRadius = 2;
            this.SupplierTypeTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SupplierTypeTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierTypeTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierTypeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierTypeTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.SupplierTypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.SupplierTypeTextBox.ItemHeight = 30;
            this.SupplierTypeTextBox.Items.AddRange(new object[] {
            "Publisher",
            "Distributor"});
            this.SupplierTypeTextBox.Location = new System.Drawing.Point(23, 433);
            this.SupplierTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SupplierTypeTextBox.Name = "SupplierTypeTextBox";
            this.SupplierTypeTextBox.Size = new System.Drawing.Size(597, 36);
            this.SupplierTypeTextBox.TabIndex = 15;
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
            this.clearButton.Location = new System.Drawing.Point(23, 582);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(601, 55);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
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
            this.addCustomerButton.Location = new System.Drawing.Point(23, 516);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(601, 55);
            this.addCustomerButton.TabIndex = 13;
            this.addCustomerButton.Text = "Add Book";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(16, 398);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Supplier Type";
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
            // supplierNametextBox
            // 
            this.supplierNametextBox.BorderRadius = 2;
            this.supplierNametextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supplierNametextBox.DefaultText = "";
            this.supplierNametextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.supplierNametextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.supplierNametextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierNametextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.supplierNametextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierNametextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.supplierNametextBox.ForeColor = System.Drawing.Color.Black;
            this.supplierNametextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.supplierNametextBox.Location = new System.Drawing.Point(23, 186);
            this.supplierNametextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.supplierNametextBox.Name = "supplierNametextBox";
            this.supplierNametextBox.PasswordChar = '\0';
            this.supplierNametextBox.PlaceholderText = "";
            this.supplierNametextBox.SelectedText = "";
            this.supplierNametextBox.Size = new System.Drawing.Size(285, 47);
            this.supplierNametextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
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
            this.label4.Size = new System.Drawing.Size(277, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Supplier Managment";
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
            this.label2.Size = new System.Drawing.Size(156, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // closePictureBoc
            // 
            this.closePictureBoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBoc.Image = global::BookHaven.Properties.Resources.close;
            this.closePictureBoc.Location = new System.Drawing.Point(17, 15);
            this.closePictureBoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closePictureBoc.Name = "closePictureBoc";
            this.closePictureBoc.Size = new System.Drawing.Size(24, 24);
            this.closePictureBoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePictureBoc.TabIndex = 0;
            this.closePictureBoc.TabStop = false;
            this.closePictureBoc.Click += new System.EventHandler(this.closePictureBoc_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierSidePanel);
            this.Controls.Add(this.searchSupplier);
            this.Controls.Add(this.addSupplier);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SupplierForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.supplierSidePanel.ResumeLayout(false);
            this.supplierSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSupplies;
        private Guna.UI2.WinForms.Guna2TextBox searchSupplier;
        private Guna.UI2.WinForms.Guna2Button addSupplier;
        private Guna.UI2.WinForms.Guna2ShadowPanel supplierSidePanel;
        private Guna.UI2.WinForms.Guna2TextBox SupplierPhoneNumberTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox SupplierTypeTextBox;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button addCustomerButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox supplierNametextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closePictureBoc;
    }
}
