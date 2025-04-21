namespace BookHaven.Forms.Customer
{
    partial class PurchaseHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.purchaseHistoryTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.purchaseHistoryFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.purchaseHistorySearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.purchaseHistoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseHistoryDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Purchased History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.purchaseHistoryTo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.purchaseHistoryFrom);
            this.panel2.Controls.Add(this.purchaseHistorySearchTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(16, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 76);
            this.panel2.TabIndex = 7;
            // 
            // purchaseHistoryTo
            // 
            this.purchaseHistoryTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseHistoryTo.BackColor = System.Drawing.Color.Transparent;
            this.purchaseHistoryTo.BorderRadius = 6;
            this.purchaseHistoryTo.Checked = true;
            this.purchaseHistoryTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.purchaseHistoryTo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistoryTo.ForeColor = System.Drawing.Color.White;
            this.purchaseHistoryTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.purchaseHistoryTo.Location = new System.Drawing.Point(977, 10);
            this.purchaseHistoryTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseHistoryTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.purchaseHistoryTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.purchaseHistoryTo.Name = "purchaseHistoryTo";
            this.purchaseHistoryTo.Size = new System.Drawing.Size(299, 55);
            this.purchaseHistoryTo.TabIndex = 10;
            this.purchaseHistoryTo.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.purchaseHistoryTo.ValueChanged += new System.EventHandler(this.purchaseHistoryTo_ValueChanged);
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
            // purchaseHistoryFrom
            // 
            this.purchaseHistoryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseHistoryFrom.BackColor = System.Drawing.Color.Transparent;
            this.purchaseHistoryFrom.BorderRadius = 6;
            this.purchaseHistoryFrom.Checked = true;
            this.purchaseHistoryFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.purchaseHistoryFrom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistoryFrom.ForeColor = System.Drawing.Color.White;
            this.purchaseHistoryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.purchaseHistoryFrom.Location = new System.Drawing.Point(576, 10);
            this.purchaseHistoryFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchaseHistoryFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.purchaseHistoryFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.purchaseHistoryFrom.Name = "purchaseHistoryFrom";
            this.purchaseHistoryFrom.Size = new System.Drawing.Size(299, 55);
            this.purchaseHistoryFrom.TabIndex = 8;
            this.purchaseHistoryFrom.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.purchaseHistoryFrom.ValueChanged += new System.EventHandler(this.purchaseHistoryFrom_ValueChanged);
            // 
            // purchaseHistorySearchTextbox
            // 
            this.purchaseHistorySearchTextbox.BorderRadius = 6;
            this.purchaseHistorySearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchaseHistorySearchTextbox.DefaultText = "";
            this.purchaseHistorySearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.purchaseHistorySearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.purchaseHistorySearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purchaseHistorySearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.purchaseHistorySearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purchaseHistorySearchTextbox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistorySearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.purchaseHistorySearchTextbox.IconRight = global::BookHaven.Properties.Resources.search;
            this.purchaseHistorySearchTextbox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseHistorySearchTextbox.IconRightSize = new System.Drawing.Size(24, 24);
            this.purchaseHistorySearchTextbox.Location = new System.Drawing.Point(13, 10);
            this.purchaseHistorySearchTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.purchaseHistorySearchTextbox.Name = "purchaseHistorySearchTextbox";
            this.purchaseHistorySearchTextbox.PasswordChar = '\0';
            this.purchaseHistorySearchTextbox.PlaceholderText = "Search";
            this.purchaseHistorySearchTextbox.SelectedText = "";
            this.purchaseHistorySearchTextbox.Size = new System.Drawing.Size(443, 55);
            this.purchaseHistorySearchTextbox.TabIndex = 5;
            this.purchaseHistorySearchTextbox.TextChanged += new System.EventHandler(this.purchaseHistorySearchTextbox_TextChanged);
            // 
            // purchaseHistoryDataGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.purchaseHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.purchaseHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.purchaseHistoryDataGridView.ColumnHeadersHeight = 50;
            this.purchaseHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.purchaseHistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseHistoryDataGridView.Location = new System.Drawing.Point(16, 214);
            this.purchaseHistoryDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.purchaseHistoryDataGridView.Name = "purchaseHistoryDataGridView";
            this.purchaseHistoryDataGridView.RowHeadersVisible = false;
            this.purchaseHistoryDataGridView.RowHeadersWidth = 100;
            this.purchaseHistoryDataGridView.Size = new System.Drawing.Size(1301, 517);
            this.purchaseHistoryDataGridView.TabIndex = 8;
            this.purchaseHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.purchaseHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.purchaseHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.purchaseHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.purchaseHistoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.purchaseHistoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.purchaseHistoryDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.purchaseHistoryDataGridView.ThemeStyle.ReadOnly = false;
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.purchaseHistoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.guna2Panel1.Location = new System.Drawing.Point(16, 751);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1301, 68);
            this.guna2Panel1.TabIndex = 9;
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
            this.PurchaseButton.Text = "Purchase History";
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
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.purchaseHistoryDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PurchaseHistory";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.PurchaseHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseHistoryDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox purchaseHistorySearchTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker purchaseHistoryFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker purchaseHistoryTo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView purchaseHistoryDataGridView;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button PurchaseButton;
        private Guna.UI2.WinForms.Guna2Button CustomerButton;
    }
}
