namespace BookHaven.Forms.Book
{
    partial class BookForm
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
            this.bookDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAddButton = new Guna.UI2.WinForms.Guna2Button();
            this.addBookPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookTitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.memberShipStatusTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.addCustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closePictureBoc = new System.Windows.Forms.PictureBox();
            this.bookSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.addBookPanel.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Managment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.bookDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookDataGridView.ColumnHeadersHeight = 50;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookDataGridView.Location = new System.Drawing.Point(35, 167);
            this.bookDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersVisible = false;
            this.bookDataGridView.RowHeadersWidth = 100;
            this.bookDataGridView.RowTemplate.Height = 35;
            this.bookDataGridView.Size = new System.Drawing.Size(1264, 646);
            this.bookDataGridView.TabIndex = 3;
            this.bookDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.bookDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.bookDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.bookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.bookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.bookDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.bookDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bookDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.bookDataGridView.ThemeStyle.ReadOnly = false;
            this.bookDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bookDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.bookDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.bookDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CusName
            // 
            this.CusName.HeaderText = "Book Name";
            this.CusName.MinimumWidth = 6;
            this.CusName.Name = "CusName";
            // 
            // bookAddButton
            // 
            this.bookAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookAddButton.BorderRadius = 5;
            this.bookAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookAddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookAddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookAddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookAddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookAddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.bookAddButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAddButton.ForeColor = System.Drawing.Color.White;
            this.bookAddButton.Location = new System.Drawing.Point(1095, 97);
            this.bookAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookAddButton.Name = "bookAddButton";
            this.bookAddButton.Size = new System.Drawing.Size(204, 55);
            this.bookAddButton.TabIndex = 5;
            this.bookAddButton.Text = "Add Book";
            this.bookAddButton.Click += new System.EventHandler(this.bookAddButton_Click);
            // 
            // addBookPanel
            // 
            this.addBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.addBookPanel.Controls.Add(this.label7);
            this.addBookPanel.Controls.Add(this.guna2TextBox1);
            this.addBookPanel.Controls.Add(this.label9);
            this.addBookPanel.Controls.Add(this.guna2TextBox2);
            this.addBookPanel.Controls.Add(this.bookTitleTextBox);
            this.addBookPanel.Controls.Add(this.memberShipStatusTextBox);
            this.addBookPanel.Controls.Add(this.clearButton);
            this.addBookPanel.Controls.Add(this.addCustomerButton);
            this.addBookPanel.Controls.Add(this.label8);
            this.addBookPanel.Controls.Add(this.label5);
            this.addBookPanel.Controls.Add(this.addressTextBox);
            this.addBookPanel.Controls.Add(this.bookNameTextBox);
            this.addBookPanel.Controls.Add(this.label6);
            this.addBookPanel.Controls.Add(this.label4);
            this.addBookPanel.Controls.Add(this.label3);
            this.addBookPanel.Controls.Add(this.emailTextBox);
            this.addBookPanel.Controls.Add(this.label2);
            this.addBookPanel.Controls.Add(this.closePictureBoc);
            this.addBookPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addBookPanel.FillColor = System.Drawing.Color.White;
            this.addBookPanel.Location = new System.Drawing.Point(692, 82);
            this.addBookPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBookPanel.Name = "addBookPanel";
            this.addBookPanel.ShadowColor = System.Drawing.Color.Black;
            this.addBookPanel.ShadowDepth = 30;
            this.addBookPanel.ShadowShift = 2;
            this.addBookPanel.Size = new System.Drawing.Size(641, 754);
            this.addBookPanel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(329, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 34);
            this.label7.TabIndex = 19;
            this.label7.Text = "Book Quantity";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(336, 426);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(285, 47);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(16, 390);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Book Price";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(23, 426);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(285, 47);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.BorderRadius = 2;
            this.bookTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTitleTextBox.DefaultText = "";
            this.bookTitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookTitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookTitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookTitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTitleTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.bookTitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.bookTitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookTitleTextBox.Location = new System.Drawing.Point(333, 186);
            this.bookTitleTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.PasswordChar = '\0';
            this.bookTitleTextBox.PlaceholderText = "";
            this.bookTitleTextBox.SelectedText = "";
            this.bookTitleTextBox.Size = new System.Drawing.Size(285, 47);
            this.bookTitleTextBox.TabIndex = 2;
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
            this.memberShipStatusTextBox.Location = new System.Drawing.Point(23, 535);
            this.memberShipStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memberShipStatusTextBox.Name = "memberShipStatusTextBox";
            this.memberShipStatusTextBox.Size = new System.Drawing.Size(597, 36);
            this.memberShipStatusTextBox.TabIndex = 15;
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
            this.clearButton.Location = new System.Drawing.Point(17, 670);
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
            this.addCustomerButton.Location = new System.Drawing.Point(17, 603);
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
            this.label8.Location = new System.Drawing.Point(16, 500);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(327, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN";
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
            // bookNameTextBox
            // 
            this.bookNameTextBox.BorderRadius = 2;
            this.bookNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookNameTextBox.DefaultText = "";
            this.bookNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookNameTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.bookNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.bookNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookNameTextBox.Location = new System.Drawing.Point(23, 186);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.PasswordChar = '\0';
            this.bookNameTextBox.PlaceholderText = "";
            this.bookNameTextBox.SelectedText = "";
            this.bookNameTextBox.Size = new System.Drawing.Size(285, 47);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author";
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
            this.label4.Size = new System.Drawing.Size(236, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Book Managment";
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
            this.label3.Size = new System.Drawing.Size(98, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Tile";
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
            this.label2.Size = new System.Drawing.Size(124, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
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
            // bookSearchTextBox
            // 
            this.bookSearchTextBox.BorderRadius = 6;
            this.bookSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookSearchTextBox.DefaultText = "";
            this.bookSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookSearchTextBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookSearchTextBox.IconRight = global::BookHaven.Properties.Resources.search;
            this.bookSearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bookSearchTextBox.IconRightSize = new System.Drawing.Size(24, 24);
            this.bookSearchTextBox.Location = new System.Drawing.Point(35, 97);
            this.bookSearchTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bookSearchTextBox.Name = "bookSearchTextBox";
            this.bookSearchTextBox.PasswordChar = '\0';
            this.bookSearchTextBox.PlaceholderText = "Search";
            this.bookSearchTextBox.SelectedText = "";
            this.bookSearchTextBox.Size = new System.Drawing.Size(443, 55);
            this.bookSearchTextBox.TabIndex = 6;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addBookPanel);
            this.Controls.Add(this.bookSearchTextBox);
            this.Controls.Add(this.bookAddButton);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.addBookPanel.ResumeLayout(false);
            this.addBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView bookDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox bookSearchTextBox;
        private Guna.UI2.WinForms.Guna2Button bookAddButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel addBookPanel;
        private Guna.UI2.WinForms.Guna2TextBox bookTitleTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox memberShipStatusTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox bookNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closePictureBoc;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button addCustomerButton;
    }
}
