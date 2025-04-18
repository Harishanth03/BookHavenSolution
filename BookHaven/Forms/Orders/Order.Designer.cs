namespace BookHaven.Forms.Orders
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.orderHistoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.orderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addOrderPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.totalPriceTextBox = new System.Windows.Forms.Label();
            this.deliveryDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceLable = new System.Windows.Forms.Label();
            this.selectedBookComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet = new BookHaven.BookDataSet();
            this.deliveryOptionComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.customerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new BookHaven.CustomerDataSet();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.placeOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closePictureBoc = new System.Windows.Forms.PictureBox();
            this.orderSearchSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerTableAdapter = new BookHaven.CustomerDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new BookHaven.CustomerDataSetTableAdapters.TableAdapterManager();
            this.bookTableAdapter = new BookHaven.BookDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager1 = new BookHaven.BookDataSetTableAdapters.TableAdapterManager();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridview)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.addOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Order Managment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // orderDataGridview
            // 
            this.orderDataGridview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGridview.ColumnHeadersHeight = 50;
            this.orderDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerID,
            this.BookID,
            this.Quantity,
            this.Price,
            this.TotalPrice,
            this.DeliveryOption,
            this.EstimatedDelivery});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDataGridview.Location = new System.Drawing.Point(35, 186);
            this.orderDataGridview.Margin = new System.Windows.Forms.Padding(0);
            this.orderDataGridview.Name = "orderDataGridview";
            this.orderDataGridview.RowHeadersVisible = false;
            this.orderDataGridview.RowHeadersWidth = 100;
            this.orderDataGridview.RowTemplate.Height = 70;
            this.orderDataGridview.Size = new System.Drawing.Size(1264, 601);
            this.orderDataGridview.TabIndex = 4;
            this.orderDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderDataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDataGridview.ThemeStyle.HeaderStyle.Height = 50;
            this.orderDataGridview.ThemeStyle.ReadOnly = false;
            this.orderDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.orderDataGridview.ThemeStyle.RowsStyle.Height = 70;
            this.orderDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridview_CellContentClick);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderBtn.BorderRadius = 5;
            this.addOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.addOrderBtn.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderBtn.ForeColor = System.Drawing.Color.White;
            this.addOrderBtn.Location = new System.Drawing.Point(1095, 107);
            this.addOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(204, 55);
            this.addOrderBtn.TabIndex = 7;
            this.addOrderBtn.Text = "Add Order";
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.orderHistoryBtn);
            this.guna2Panel1.Controls.Add(this.orderBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 96);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(505, 76);
            this.guna2Panel1.TabIndex = 9;
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BorderRadius = 3;
            this.orderHistoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.orderHistoryBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.orderHistoryBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.orderHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderHistoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.orderHistoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.orderHistoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.orderHistoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.orderHistoryBtn.FillColor = System.Drawing.Color.White;
            this.orderHistoryBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.ForeColor = System.Drawing.Color.Gray;
            this.orderHistoryBtn.Location = new System.Drawing.Point(256, 12);
            this.orderHistoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(240, 53);
            this.orderHistoryBtn.TabIndex = 1;
            this.orderHistoryBtn.Text = "Orders History";
            this.orderHistoryBtn.Click += new System.EventHandler(this.orderHistoryBtn_Click);
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
            this.orderBtn.FillColor = System.Drawing.Color.Transparent;
            this.orderBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.orderBtn.ForeColor = System.Drawing.Color.Gray;
            this.orderBtn.Location = new System.Drawing.Point(8, 12);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(240, 53);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "Orders";
            // 
            // addOrderPanel
            // 
            this.addOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.addOrderPanel.Controls.Add(this.totalPriceTextBox);
            this.addOrderPanel.Controls.Add(this.deliveryDatePicker);
            this.addOrderPanel.Controls.Add(this.label7);
            this.addOrderPanel.Controls.Add(this.PriceLable);
            this.addOrderPanel.Controls.Add(this.selectedBookComboBox);
            this.addOrderPanel.Controls.Add(this.deliveryOptionComboBox);
            this.addOrderPanel.Controls.Add(this.customerComboBox);
            this.addOrderPanel.Controls.Add(this.clearButton);
            this.addOrderPanel.Controls.Add(this.placeOrderBtn);
            this.addOrderPanel.Controls.Add(this.label5);
            this.addOrderPanel.Controls.Add(this.quantityTextBox);
            this.addOrderPanel.Controls.Add(this.label6);
            this.addOrderPanel.Controls.Add(this.label4);
            this.addOrderPanel.Controls.Add(this.label3);
            this.addOrderPanel.Controls.Add(this.label2);
            this.addOrderPanel.Controls.Add(this.closePictureBoc);
            this.addOrderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addOrderPanel.FillColor = System.Drawing.Color.White;
            this.addOrderPanel.Location = new System.Drawing.Point(694, 82);
            this.addOrderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderPanel.Name = "addOrderPanel";
            this.addOrderPanel.ShadowColor = System.Drawing.Color.Black;
            this.addOrderPanel.ShadowDepth = 30;
            this.addOrderPanel.ShadowShift = 2;
            this.addOrderPanel.Size = new System.Drawing.Size(639, 754);
            this.addOrderPanel.TabIndex = 10;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceTextBox.AutoSize = true;
            this.totalPriceTextBox.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.totalPriceTextBox.Location = new System.Drawing.Point(329, 446);
            this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(260, 42);
            this.totalPriceTextBox.TabIndex = 28;
            this.totalPriceTextBox.Text = "Total Price: රු.00.00";
            this.totalPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.BorderRadius = 2;
            this.deliveryDatePicker.Checked = true;
            this.deliveryDatePicker.FillColor = System.Drawing.Color.White;
            this.deliveryDatePicker.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.deliveryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.deliveryDatePicker.Location = new System.Drawing.Point(23, 549);
            this.deliveryDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.deliveryDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.deliveryDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(596, 47);
            this.deliveryDatePicker.TabIndex = 27;
            this.deliveryDatePicker.Value = new System.DateTime(2025, 3, 7, 11, 20, 0, 434);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 513);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "Delivery Date (Optional)";
            // 
            // PriceLable
            // 
            this.PriceLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PriceLable.AutoSize = true;
            this.PriceLable.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLable.ForeColor = System.Drawing.Color.DimGray;
            this.PriceLable.Location = new System.Drawing.Point(329, 306);
            this.PriceLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(259, 42);
            this.PriceLable.TabIndex = 25;
            this.PriceLable.Text = "Book Price: රු.00.00";
            this.PriceLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedBookComboBox
            // 
            this.selectedBookComboBox.BackColor = System.Drawing.Color.Transparent;
            this.selectedBookComboBox.BorderRadius = 2;
            this.selectedBookComboBox.DataSource = this.bookBindingSource;
            this.selectedBookComboBox.DisplayMember = "Title";
            this.selectedBookComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedBookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedBookComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectedBookComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectedBookComboBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.selectedBookComboBox.ForeColor = System.Drawing.Color.Black;
            this.selectedBookComboBox.ItemHeight = 30;
            this.selectedBookComboBox.Location = new System.Drawing.Point(23, 306);
            this.selectedBookComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectedBookComboBox.Name = "selectedBookComboBox";
            this.selectedBookComboBox.Size = new System.Drawing.Size(284, 36);
            this.selectedBookComboBox.TabIndex = 20;
            this.selectedBookComboBox.ValueMember = "BookID";
            this.selectedBookComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedBookComboBox_SelectedIndexChanged);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bookDataSet;
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryOptionComboBox
            // 
            this.deliveryOptionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.deliveryOptionComboBox.BorderRadius = 2;
            this.deliveryOptionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.deliveryOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryOptionComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deliveryOptionComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deliveryOptionComboBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.deliveryOptionComboBox.ForeColor = System.Drawing.Color.Black;
            this.deliveryOptionComboBox.ItemHeight = 30;
            this.deliveryOptionComboBox.Items.AddRange(new object[] {
            "PickUp",
            "HomeDelivery"});
            this.deliveryOptionComboBox.Location = new System.Drawing.Point(333, 186);
            this.deliveryOptionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.deliveryOptionComboBox.Name = "deliveryOptionComboBox";
            this.deliveryOptionComboBox.Size = new System.Drawing.Size(284, 36);
            this.deliveryOptionComboBox.TabIndex = 19;
            // 
            // customerComboBox
            // 
            this.customerComboBox.BackColor = System.Drawing.Color.Transparent;
            this.customerComboBox.BorderRadius = 2;
            this.customerComboBox.DataSource = this.customerBindingSource;
            this.customerComboBox.DisplayMember = "FullName";
            this.customerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerComboBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.customerComboBox.ForeColor = System.Drawing.Color.Black;
            this.customerComboBox.ItemHeight = 30;
            this.customerComboBox.Location = new System.Drawing.Point(23, 186);
            this.customerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(284, 36);
            this.customerComboBox.TabIndex = 18;
            this.customerComboBox.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.clearButton.Location = new System.Drawing.Point(17, 681);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.PressedColor = System.Drawing.Color.DarkGray;
            this.clearButton.Size = new System.Drawing.Size(601, 55);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BorderRadius = 4;
            this.placeOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.placeOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.placeOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.placeOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.placeOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.placeOrderBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderBtn.Location = new System.Drawing.Point(17, 613);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.PressedColor = System.Drawing.Color.DarkGray;
            this.placeOrderBtn.Size = new System.Drawing.Size(601, 55);
            this.placeOrderBtn.TabIndex = 13;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(16, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BorderRadius = 2;
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.DefaultText = "";
            this.quantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.quantityTextBox.ForeColor = System.Drawing.Color.Black;
            this.quantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTextBox.Location = new System.Drawing.Point(23, 443);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.PlaceholderText = "";
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.Size = new System.Drawing.Size(285, 47);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Book";
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
            this.label4.Size = new System.Drawing.Size(201, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add Pre Orders";
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
            this.label3.Size = new System.Drawing.Size(160, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delivery Option";
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
            this.closePictureBoc.Click += new System.EventHandler(this.closePictureBoc_Click);
            // 
            // orderSearchSearchBox
            // 
            this.orderSearchSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderSearchSearchBox.BorderRadius = 6;
            this.orderSearchSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderSearchSearchBox.DefaultText = "";
            this.orderSearchSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.orderSearchSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.orderSearchSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderSearchSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.orderSearchSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderSearchSearchBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSearchSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.orderSearchSearchBox.IconRight = global::BookHaven.Properties.Resources.search;
            this.orderSearchSearchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.orderSearchSearchBox.IconRightSize = new System.Drawing.Size(24, 24);
            this.orderSearchSearchBox.Location = new System.Drawing.Point(643, 107);
            this.orderSearchSearchBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.orderSearchSearchBox.Name = "orderSearchSearchBox";
            this.orderSearchSearchBox.PasswordChar = '\0';
            this.orderSearchSearchBox.PlaceholderText = "Search";
            this.orderSearchSearchBox.SelectedText = "";
            this.orderSearchSearchBox.Size = new System.Drawing.Size(443, 55);
            this.orderSearchSearchBox.TabIndex = 8;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = BookHaven.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BookHaven.BookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer Name";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Book Title";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // DeliveryOption
            // 
            this.DeliveryOption.HeaderText = "Delivery Option";
            this.DeliveryOption.MinimumWidth = 6;
            this.DeliveryOption.Name = "DeliveryOption";
            // 
            // EstimatedDelivery
            // 
            this.EstimatedDelivery.HeaderText = "Delivery Date";
            this.EstimatedDelivery.MinimumWidth = 6;
            this.EstimatedDelivery.Name = "EstimatedDelivery";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addOrderPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.orderSearchSearchBox);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.orderDataGridview);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridview)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.addOrderPanel.ResumeLayout(false);
            this.addOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView orderDataGridview;
        private Guna.UI2.WinForms.Guna2TextBox orderSearchSearchBox;
        private Guna.UI2.WinForms.Guna2Button addOrderBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button orderHistoryBtn;
        private Guna.UI2.WinForms.Guna2Button orderBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel addOrderPanel;
        private Guna.UI2.WinForms.Guna2ComboBox selectedBookComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox deliveryOptionComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox customerComboBox;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button placeOrderBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox quantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closePictureBoc;
        private Guna.UI2.WinForms.Guna2DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PriceLable;
        private System.Windows.Forms.Label totalPriceTextBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerDataSet customerDataSet;
        private CustomerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private CustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookDataSet bookDataSet;
        private BookDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private BookDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDelivery;
    }
}
