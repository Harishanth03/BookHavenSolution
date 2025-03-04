namespace BookHaven
{
    partial class loginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.signinButton = new Guna.UI2.WinForms.Guna2Button();
            this.eyeIcon = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.signinButton);
            this.panel3.Controls.Add(this.eyeIcon);
            this.panel3.Controls.Add(this.PasswordTextBox);
            this.panel3.Controls.Add(this.usernameTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(565, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 753);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookHaven.Properties.Resources.BH_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(202, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearButton.BorderRadius = 6;
            this.clearButton.BorderThickness = 1;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.clearButton.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(51, 582);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(514, 82);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.BorderRadius = 6;
            this.signinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinButton.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.signinButton.ForeColor = System.Drawing.Color.White;
            this.signinButton.Location = new System.Drawing.Point(51, 485);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(514, 82);
            this.signinButton.TabIndex = 4;
            this.signinButton.Text = "Sign in account";
            // 
            // eyeIcon
            // 
            this.eyeIcon.BackColor = System.Drawing.Color.White;
            this.eyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeIcon.Image = global::BookHaven.Properties.Resources.visibility;
            this.eyeIcon.Location = new System.Drawing.Point(520, 384);
            this.eyeIcon.Name = "eyeIcon";
            this.eyeIcon.Size = new System.Drawing.Size(35, 35);
            this.eyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeIcon.TabIndex = 3;
            this.eyeIcon.TabStop = false;
            this.eyeIcon.Click += new System.EventHandler(this.eyeIcon_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.BorderRadius = 6;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedState.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(51, 360);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(514, 82);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.usernameTextBox.BorderRadius = 6;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.ForeColor = System.Drawing.Color.Gray;
            this.usernameTextBox.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Location = new System.Drawing.Point(51, 233);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(514, 82);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Haven Login";
            this.Load += new System.EventHandler(this.loginFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox eyeIcon;
        private Guna.UI2.WinForms.Guna2Button signinButton;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

