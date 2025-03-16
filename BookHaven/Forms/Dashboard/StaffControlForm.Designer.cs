namespace BookHaven.Forms.Dashboard
{
    partial class StaffControlForm
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
            this.staffDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStaffButton = new Guna.UI2.WinForms.Guna2Button();
            this.addStaffPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addStaffBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.userNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffRoleTextBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staffNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.closePictureBoc = new System.Windows.Forms.PictureBox();
            this.staffSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridview)).BeginInit();
            this.addStaffPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).BeginInit();
            this.SuspendLayout();
            // 
            // staffDataGridview
            // 
            this.staffDataGridview.AllowUserToAddRows = false;
            this.staffDataGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.staffDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffDataGridview.ColumnHeadersHeight = 50;
            this.staffDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.staffName,
            this.Email,
            this.UserName,
            this.UserRole,
            this.CreatedAt,
            this.edit,
            this.delete});
            this.staffDataGridview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffDataGridview.Location = new System.Drawing.Point(17, 80);
            this.staffDataGridview.Margin = new System.Windows.Forms.Padding(0);
            this.staffDataGridview.Name = "staffDataGridview";
            this.staffDataGridview.RowHeadersVisible = false;
            this.staffDataGridview.RowHeadersWidth = 100;
            this.staffDataGridview.RowTemplate.Height = 35;
            this.staffDataGridview.Size = new System.Drawing.Size(1297, 690);
            this.staffDataGridview.TabIndex = 7;
            this.staffDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.staffDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.staffDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.staffDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.staffDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.staffDataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.staffDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staffDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.staffDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffDataGridview.ThemeStyle.HeaderStyle.Height = 50;
            this.staffDataGridview.ThemeStyle.ReadOnly = false;
            this.staffDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffDataGridview.ThemeStyle.RowsStyle.Height = 35;
            this.staffDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridview_CellContentClick);
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.Width = 109;
            // 
            // staffName
            // 
            this.staffName.HeaderText = "Name";
            this.staffName.MinimumWidth = 6;
            this.staffName.Name = "staffName";
            // 
            // Email
            // 
            this.Email.FillWeight = 150F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // UserRole
            // 
            this.UserRole.HeaderText = "UserRole";
            this.UserRole.MinimumWidth = 6;
            this.UserRole.Name = "UserRole";
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            // 
            // addStaffButton
            // 
            this.addStaffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStaffButton.BorderRadius = 5;
            this.addStaffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStaffButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStaffButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStaffButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStaffButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStaffButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.addStaffButton.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffButton.ForeColor = System.Drawing.Color.White;
            this.addStaffButton.Location = new System.Drawing.Point(1110, 12);
            this.addStaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(204, 55);
            this.addStaffButton.TabIndex = 9;
            this.addStaffButton.Text = "Add Staff";
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // addStaffPanel
            // 
            this.addStaffPanel.BackColor = System.Drawing.Color.Transparent;
            this.addStaffPanel.Controls.Add(this.flowLayoutPanel1);
            this.addStaffPanel.Controls.Add(this.label1);
            this.addStaffPanel.Controls.Add(this.emailTextBox);
            this.addStaffPanel.Controls.Add(this.userNameTextBox);
            this.addStaffPanel.Controls.Add(this.staffRoleTextBox);
            this.addStaffPanel.Controls.Add(this.label5);
            this.addStaffPanel.Controls.Add(this.staffNameTextBox);
            this.addStaffPanel.Controls.Add(this.label6);
            this.addStaffPanel.Controls.Add(this.label4);
            this.addStaffPanel.Controls.Add(this.label3);
            this.addStaffPanel.Controls.Add(this.passwordTextBox);
            this.addStaffPanel.Controls.Add(this.label2);
            this.addStaffPanel.Controls.Add(this.closePictureBoc);
            this.addStaffPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addStaffPanel.FillColor = System.Drawing.Color.White;
            this.addStaffPanel.Location = new System.Drawing.Point(694, 0);
            this.addStaffPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addStaffPanel.Name = "addStaffPanel";
            this.addStaffPanel.ShadowColor = System.Drawing.Color.Black;
            this.addStaffPanel.ShadowDepth = 50;
            this.addStaffPanel.Size = new System.Drawing.Size(639, 836);
            this.addStaffPanel.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addStaffBtn);
            this.flowLayoutPanel1.Controls.Add(this.updateButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 424);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 203);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.BorderRadius = 4;
            this.addStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStaffBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStaffBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStaffBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStaffBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStaffBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.addStaffBtn.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffBtn.ForeColor = System.Drawing.Color.White;
            this.addStaffBtn.Location = new System.Drawing.Point(16, 4);
            this.addStaffBtn.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(601, 55);
            this.addStaffBtn.TabIndex = 16;
            this.addStaffBtn.Text = "Add Staff";
            this.addStaffBtn.Click += new System.EventHandler(this.addStaffBtn_Click);
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
            this.updateButton.Text = "Update Staff";
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
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email";
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
            this.emailTextBox.Location = new System.Drawing.Point(23, 368);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(285, 47);
            this.emailTextBox.TabIndex = 18;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderRadius = 2;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.DefaultText = "";
            this.userNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Location = new System.Drawing.Point(333, 134);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PlaceholderText = "";
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.Size = new System.Drawing.Size(285, 47);
            this.userNameTextBox.TabIndex = 2;
            // 
            // staffRoleTextBox
            // 
            this.staffRoleTextBox.BackColor = System.Drawing.Color.Transparent;
            this.staffRoleTextBox.BorderRadius = 2;
            this.staffRoleTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.staffRoleTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffRoleTextBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffRoleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffRoleTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.staffRoleTextBox.ForeColor = System.Drawing.Color.Black;
            this.staffRoleTextBox.ItemHeight = 30;
            this.staffRoleTextBox.Items.AddRange(new object[] {
            "Admin",
            "SalesClerk"});
            this.staffRoleTextBox.Location = new System.Drawing.Point(333, 259);
            this.staffRoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.staffRoleTextBox.Name = "staffRoleTextBox";
            this.staffRoleTextBox.Size = new System.Drawing.Size(285, 36);
            this.staffRoleTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(327, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Staff Role";
            // 
            // staffNameTextBox
            // 
            this.staffNameTextBox.BorderRadius = 2;
            this.staffNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffNameTextBox.DefaultText = "";
            this.staffNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffNameTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.staffNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.staffNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffNameTextBox.Location = new System.Drawing.Point(23, 134);
            this.staffNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.staffNameTextBox.Name = "staffNameTextBox";
            this.staffNameTextBox.PasswordChar = '\0';
            this.staffNameTextBox.PlaceholderText = "";
            this.staffNameTextBox.SelectedText = "";
            this.staffNameTextBox.Size = new System.Drawing.Size(285, 47);
            this.staffNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add Staff ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(327, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderRadius = 2;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(23, 254);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(285, 47);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::BookHaven.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 91;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::BookHaven.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 92;
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
            // staffSearchBox
            // 
            this.staffSearchBox.BorderRadius = 6;
            this.staffSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffSearchBox.DefaultText = "";
            this.staffSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffSearchBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffSearchBox.IconRight = global::BookHaven.Properties.Resources.search;
            this.staffSearchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.staffSearchBox.IconRightSize = new System.Drawing.Size(24, 24);
            this.staffSearchBox.Location = new System.Drawing.Point(21, 12);
            this.staffSearchBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.staffSearchBox.Name = "staffSearchBox";
            this.staffSearchBox.PasswordChar = '\0';
            this.staffSearchBox.PlaceholderText = "Search";
            this.staffSearchBox.SelectedText = "";
            this.staffSearchBox.Size = new System.Drawing.Size(443, 55);
            this.staffSearchBox.TabIndex = 8;
            this.staffSearchBox.TextChanged += new System.EventHandler(this.staffSearchBox_TextChanged);
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
            // StaffControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addStaffPanel);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.staffSearchBox);
            this.Controls.Add(this.staffDataGridview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffControlForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.StaffControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridview)).EndInit();
            this.addStaffPanel.ResumeLayout(false);
            this.addStaffPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView staffDataGridview;
        private Guna.UI2.WinForms.Guna2TextBox staffSearchBox;
        private Guna.UI2.WinForms.Guna2Button addStaffButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel addStaffPanel;
        private Guna.UI2.WinForms.Guna2TextBox userNameTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox staffRoleTextBox;
        private Guna.UI2.WinForms.Guna2TextBox staffNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closePictureBoc;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button addStaffBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}
