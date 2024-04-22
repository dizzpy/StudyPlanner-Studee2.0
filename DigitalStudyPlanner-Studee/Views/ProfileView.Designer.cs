namespace DigitalStudyPlanner_Studee.Views
{
    partial class ProfileView
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
            this.ProfilePicBox = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.DEmailAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.DFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.DOccupation = new Guna.UI2.WinForms.Guna2TextBox();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProfilePicBox.BaseColor = System.Drawing.Color.Transparent;
            this.ProfilePicBox.Location = new System.Drawing.Point(53, 48);
            this.ProfilePicBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(120, 120);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicBox.TabIndex = 12;
            this.ProfilePicBox.TabStop = false;
            this.ProfilePicBox.UseTransfarantBackground = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.lblEmail.Location = new System.Drawing.Point(48, 277);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 28);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email Address :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEmailAddress
            // 
            this.DEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DEmailAddress.AutoSize = true;
            this.DEmailAddress.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.DEmailAddress.Location = new System.Drawing.Point(46, 306);
            this.DEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DEmailAddress.Name = "DEmailAddress";
            this.DEmailAddress.Size = new System.Drawing.Size(219, 37);
            this.DEmailAddress.TabIndex = 14;
            this.DEmailAddress.Text = "Email  Address Text";
            this.DEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(49, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "You are :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BorderRadius = 8;
            this.LogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.LogoutButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(276, 470);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(129, 45);
            this.LogoutButton.TabIndex = 24;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DFullName
            // 
            this.DFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DFullName.DefaultText = "";
            this.DFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DFullName.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.DFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DFullName.Location = new System.Drawing.Point(54, 206);
            this.DFullName.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.DFullName.Name = "DFullName";
            this.DFullName.PasswordChar = '\0';
            this.DFullName.PlaceholderText = "";
            this.DFullName.SelectedText = "";
            this.DFullName.Size = new System.Drawing.Size(360, 52);
            this.DFullName.TabIndex = 25;
            // 
            // DOccupation
            // 
            this.DOccupation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DOccupation.DefaultText = "";
            this.DOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DOccupation.Font = new System.Drawing.Font("Poppins", 15.75F);
            this.DOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DOccupation.Location = new System.Drawing.Point(54, 399);
            this.DOccupation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.DOccupation.Name = "DOccupation";
            this.DOccupation.PasswordChar = '\0';
            this.DOccupation.PlaceholderText = "";
            this.DOccupation.SelectedText = "";
            this.DOccupation.Size = new System.Drawing.Size(351, 50);
            this.DOccupation.TabIndex = 26;
            // 
            // SaveButton
            // 
            this.SaveButton.BorderRadius = 8;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.SaveButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(53, 470);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(198, 45);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save Changes";
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 561);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DOccupation);
            this.Controls.Add(this.DFullName);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.DEmailAddress);
            this.Controls.Add(this.ProfilePicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ProfileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCirclePictureBox ProfilePicBox;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label DEmailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private Guna.UI2.WinForms.Guna2TextBox DFullName;
        private Guna.UI2.WinForms.Guna2TextBox DOccupation;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
    }
}