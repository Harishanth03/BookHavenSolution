namespace BookHaven.Forms.Report
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReportToDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reportFromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DownloadReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReportTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportDataGridview
            // 
            this.reportDataGridview.AllowUserToAddRows = false;
            this.reportDataGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.reportDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.reportDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.reportDataGridview.ColumnHeadersHeight = 50;
            this.reportDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportDataGridview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDataGridview.DefaultCellStyle = dataGridViewCellStyle24;
            this.reportDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportDataGridview.Location = new System.Drawing.Point(18, 201);
            this.reportDataGridview.Margin = new System.Windows.Forms.Padding(0);
            this.reportDataGridview.Name = "reportDataGridview";
            this.reportDataGridview.RowHeadersVisible = false;
            this.reportDataGridview.RowHeadersWidth = 100;
            this.reportDataGridview.RowTemplate.Height = 35;
            this.reportDataGridview.Size = new System.Drawing.Size(1297, 492);
            this.reportDataGridview.TabIndex = 8;
            this.reportDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reportDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reportDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reportDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reportDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reportDataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reportDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reportDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reportDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reportDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportDataGridview.ThemeStyle.HeaderStyle.Height = 50;
            this.reportDataGridview.ThemeStyle.ReadOnly = false;
            this.reportDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reportDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reportDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reportDataGridview.ThemeStyle.RowsStyle.Height = 35;
            this.reportDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            //this.reportDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridview_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ReportTypeComboBox);
            this.panel2.Controls.Add(this.ReportToDateTimePicker);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.reportFromDateTimePicker);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(18, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 76);
            this.panel2.TabIndex = 9;
            //this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ReportToDateTimePicker
            // 
            this.ReportToDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.ReportToDateTimePicker.BorderRadius = 6;
            this.ReportToDateTimePicker.Checked = true;
            this.ReportToDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportToDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ReportToDateTimePicker.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportToDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.ReportToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReportToDateTimePicker.Location = new System.Drawing.Point(435, 11);
            this.ReportToDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ReportToDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReportToDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReportToDateTimePicker.Name = "ReportToDateTimePicker";
            this.ReportToDateTimePicker.Size = new System.Drawing.Size(299, 55);
            this.ReportToDateTimePicker.TabIndex = 10;
            this.ReportToDateTimePicker.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.ReportToDateTimePicker.ValueChanged += new System.EventHandler(this.ReportToDateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(385, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // reportFromDateTimePicker
            // 
            this.reportFromDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.reportFromDateTimePicker.BorderRadius = 6;
            this.reportFromDateTimePicker.Checked = true;
            this.reportFromDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportFromDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.reportFromDateTimePicker.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportFromDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.reportFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.reportFromDateTimePicker.Location = new System.Drawing.Point(83, 11);
            this.reportFromDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.reportFromDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.reportFromDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.reportFromDateTimePicker.Name = "reportFromDateTimePicker";
            this.reportFromDateTimePicker.Size = new System.Drawing.Size(299, 55);
            this.reportFromDateTimePicker.TabIndex = 8;
            this.reportFromDateTimePicker.Value = new System.DateTime(2025, 3, 6, 21, 28, 40, 803);
            this.reportFromDateTimePicker.ValueChanged += new System.EventHandler(this.reportFromDateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
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
            this.panel1.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(105, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DownloadReportButton);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(18, 716);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 76);
            this.panel3.TabIndex = 18;
            // 
            // DownloadReportButton
            // 
            this.DownloadReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadReportButton.BorderRadius = 4;
            this.DownloadReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DownloadReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DownloadReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownloadReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DownloadReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.DownloadReportButton.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadReportButton.ForeColor = System.Drawing.Color.White;
            this.DownloadReportButton.Location = new System.Drawing.Point(435, 10);
            this.DownloadReportButton.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.DownloadReportButton.Name = "DownloadReportButton";
            this.DownloadReportButton.Size = new System.Drawing.Size(380, 55);
            this.DownloadReportButton.TabIndex = 17;
            this.DownloadReportButton.Text = "Download Report";
            this.DownloadReportButton.Click += new System.EventHandler(this.DownloadReportButton_Click);
            // 
            // ReportTypeComboBox
            // 
            this.ReportTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ReportTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ReportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReportTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ReportTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ReportTypeComboBox.ItemHeight = 30;
            this.ReportTypeComboBox.Items.AddRange(new object[] {
            "Sales Report",
            "Book Sales Summary",
            "Customer Purchase History"});
            this.ReportTypeComboBox.Location = new System.Drawing.Point(759, 20);
            this.ReportTypeComboBox.Name = "ReportTypeComboBox";
            this.ReportTypeComboBox.Size = new System.Drawing.Size(519, 36);
            this.ReportTypeComboBox.TabIndex = 18;
            this.ReportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ReportTypeComboBox_SelectedIndexChanged);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportDataGridview);
            this.Name = "ReportForm";
            this.Size = new System.Drawing.Size(1333, 836);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView reportDataGridview;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReportToDateTimePicker;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker reportFromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button DownloadReportButton;
        private Guna.UI2.WinForms.Guna2ComboBox ReportTypeComboBox;
    }
}
