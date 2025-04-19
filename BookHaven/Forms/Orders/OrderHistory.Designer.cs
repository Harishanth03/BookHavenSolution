namespace BookHaven.Forms.Orders
{
    partial class OrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderHistoryTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderHistoryFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.customerSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderHistoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(308, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Order History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.OrderHistoryTo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.OrderHistoryFrom);
            this.panel2.Controls.Add(this.customerSearchTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 76);
            this.panel2.TabIndex = 8;
            // 
            // OrderHistoryTo
            // 
            this.OrderHistoryTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderHistoryTo.BackColor = System.Drawing.Color.Transparent;
            this.OrderHistoryTo.BorderRadius = 6;
            this.OrderHistoryTo.Checked = true;
            this.OrderHistoryTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderHistoryTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OrderHistoryTo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistoryTo.ForeColor = System.Drawing.Color.White;
            this.OrderHistoryTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OrderHistoryTo.Location = new System.Drawing.Point(977, 10);
            this.OrderHistoryTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderHistoryTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OrderHistoryTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OrderHistoryTo.Name = "OrderHistoryTo";
            this.OrderHistoryTo.Size = new System.Drawing.Size(299, 55);
            this.OrderHistoryTo.TabIndex = 10;
            this.OrderHistoryTo.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.OrderHistoryTo.ValueChanged += new System.EventHandler(this.OrderHistoryTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(927, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // OrderHistoryFrom
            // 
            this.OrderHistoryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderHistoryFrom.BackColor = System.Drawing.Color.Transparent;
            this.OrderHistoryFrom.BorderRadius = 6;
            this.OrderHistoryFrom.Checked = true;
            this.OrderHistoryFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderHistoryFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OrderHistoryFrom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistoryFrom.ForeColor = System.Drawing.Color.White;
            this.OrderHistoryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.OrderHistoryFrom.Location = new System.Drawing.Point(576, 10);
            this.OrderHistoryFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderHistoryFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.OrderHistoryFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.OrderHistoryFrom.Name = "OrderHistoryFrom";
            this.OrderHistoryFrom.Size = new System.Drawing.Size(299, 55);
            this.OrderHistoryFrom.TabIndex = 8;
            this.OrderHistoryFrom.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.OrderHistoryFrom.ValueChanged += new System.EventHandler(this.OrderHistoryFrom_ValueChanged);
            // 
            // customerSearchTextBox
            // 
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
            this.customerSearchTextBox.Location = new System.Drawing.Point(13, 10);
            this.customerSearchTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.PasswordChar = '\0';
            this.customerSearchTextBox.PlaceholderText = "Search";
            this.customerSearchTextBox.SelectedText = "";
            this.customerSearchTextBox.Size = new System.Drawing.Size(443, 55);
            this.customerSearchTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(496, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // OrderHistoryDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrderHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderHistoryDataGridView.ColumnHeadersHeight = 50;
            this.OrderHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.customerName,
            this.bookTitle,
            this.quantity,
            this.price,
            this.totalPrice,
            this.orderDate,
            this.deliveryOption,
            this.estimatedDeliveryDate});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderHistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderHistoryDataGridView.Location = new System.Drawing.Point(12, 190);
            this.OrderHistoryDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.OrderHistoryDataGridView.Name = "OrderHistoryDataGridView";
            this.OrderHistoryDataGridView.RowHeadersVisible = false;
            this.OrderHistoryDataGridView.RowHeadersWidth = 100;
            this.OrderHistoryDataGridView.RowTemplate.Height = 35;
            this.OrderHistoryDataGridView.Size = new System.Drawing.Size(1301, 533);
            this.OrderHistoryDataGridView.TabIndex = 9;
            this.OrderHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderHistoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderHistoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderHistoryDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.OrderHistoryDataGridView.ThemeStyle.ReadOnly = false;
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderHistoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.PurchaseButton);
            this.guna2Panel1.Controls.Add(this.CustomerButton);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 752);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1301, 68);
            this.guna2Panel1.TabIndex = 10;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PurchaseButton.BorderRadius = 3;
            this.PurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PurchaseButton.Checked = true;
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
            this.PurchaseButton.Location = new System.Drawing.Point(635, 7);
            this.PurchaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(240, 53);
            this.PurchaseButton.TabIndex = 1;
            this.PurchaseButton.Text = "Order History";
            // 
            // CustomerButton
            // 
            this.CustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CustomerButton.BorderRadius = 3;
            this.CustomerButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
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
            this.CustomerButton.Location = new System.Drawing.Point(387, 7);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(240, 53);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Back To Order";
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            // 
            // bookTitle
            // 
            this.bookTitle.HeaderText = "Book Title";
            this.bookTitle.MinimumWidth = 6;
            this.bookTitle.Name = "bookTitle";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price (Per Unit)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.MinimumWidth = 6;
            this.orderDate.Name = "orderDate";
            // 
            // deliveryOption
            // 
            this.deliveryOption.HeaderText = "Delivery Option";
            this.deliveryOption.MinimumWidth = 6;
            this.deliveryOption.Name = "deliveryOption";
            // 
            // estimatedDeliveryDate
            // 
            this.estimatedDeliveryDate.HeaderText = "Estimated Delivery";
            this.estimatedDeliveryDate.MinimumWidth = 6;
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.OrderHistoryDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderHistory";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderHistoryDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker OrderHistoryTo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker OrderHistoryFrom;
        private Guna.UI2.WinForms.Guna2TextBox customerSearchTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView OrderHistoryDataGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button PurchaseButton;
        private Guna.UI2.WinForms.Guna2Button CustomerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedDeliveryDate;
    }
}
