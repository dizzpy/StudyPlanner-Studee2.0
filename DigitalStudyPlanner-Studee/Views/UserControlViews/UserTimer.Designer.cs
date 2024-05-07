namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class UserTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTimer));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ongoingBTN = new Guna.UI.WinForms.GunaButton();
            this.breakBTN = new Guna.UI.WinForms.GunaButton();
            this.startBTN = new Guna.UI.WinForms.GunaButton();
            this.resetBTN = new Guna.UI.WinForms.GunaButton();
            this.stopBTN = new Guna.UI.WinForms.GunaButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Poppins", 70.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.gunaLabel1.Location = new System.Drawing.Point(158, 212);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(639, 166);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "00:00:00:00";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ongoingBTN
            // 
            this.ongoingBTN.AnimationHoverSpeed = 0.07F;
            this.ongoingBTN.AnimationSpeed = 0.03F;
            this.ongoingBTN.BackColor = System.Drawing.Color.Transparent;
            this.ongoingBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.ongoingBTN.BorderColor = System.Drawing.Color.Black;
            this.ongoingBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ongoingBTN.FocusedColor = System.Drawing.Color.Empty;
            this.ongoingBTN.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongoingBTN.ForeColor = System.Drawing.Color.White;
            this.ongoingBTN.Image = null;
            this.ongoingBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.ongoingBTN.Location = new System.Drawing.Point(336, 126);
            this.ongoingBTN.Name = "ongoingBTN";
            this.ongoingBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.ongoingBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ongoingBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.ongoingBTN.OnHoverImage = null;
            this.ongoingBTN.OnPressedColor = System.Drawing.Color.Black;
            this.ongoingBTN.OnPressedDepth = 18;
            this.ongoingBTN.Radius = 20;
            this.ongoingBTN.Size = new System.Drawing.Size(138, 50);
            this.ongoingBTN.TabIndex = 9;
            this.ongoingBTN.Text = "Ongoing";
            this.ongoingBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ongoingBTN.UseTransfarantBackground = true;
            // 
            // breakBTN
            // 
            this.breakBTN.AnimationHoverSpeed = 0.07F;
            this.breakBTN.AnimationSpeed = 0.03F;
            this.breakBTN.BackColor = System.Drawing.Color.Transparent;
            this.breakBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.breakBTN.BorderColor = System.Drawing.Color.Black;
            this.breakBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.breakBTN.FocusedColor = System.Drawing.Color.Empty;
            this.breakBTN.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.breakBTN.Image = null;
            this.breakBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.breakBTN.Location = new System.Drawing.Point(480, 126);
            this.breakBTN.Name = "breakBTN";
            this.breakBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.breakBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.breakBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.breakBTN.OnHoverImage = null;
            this.breakBTN.OnPressedColor = System.Drawing.Color.Black;
            this.breakBTN.Radius = 20;
            this.breakBTN.Size = new System.Drawing.Size(138, 50);
            this.breakBTN.TabIndex = 8;
            this.breakBTN.Text = "Break";
            this.breakBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBTN
            // 
            this.startBTN.AnimationHoverSpeed = 0.07F;
            this.startBTN.AnimationSpeed = 0.03F;
            this.startBTN.BackColor = System.Drawing.Color.Transparent;
            this.startBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.startBTN.BorderColor = System.Drawing.Color.Black;
            this.startBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBTN.FocusedColor = System.Drawing.Color.Empty;
            this.startBTN.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.White;
            this.startBTN.Image = ((System.Drawing.Image)(resources.GetObject("startBTN.Image")));
            this.startBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.startBTN.Location = new System.Drawing.Point(98, 441);
            this.startBTN.Name = "startBTN";
            this.startBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.startBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.startBTN.OnHoverImage = null;
            this.startBTN.OnPressedColor = System.Drawing.Color.Black;
            this.startBTN.Radius = 23;
            this.startBTN.Size = new System.Drawing.Size(180, 65);
            this.startBTN.TabIndex = 13;
            this.startBTN.Text = "Start";
            this.startBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBTN.UseTransfarantBackground = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.AnimationHoverSpeed = 0.07F;
            this.resetBTN.AnimationSpeed = 0.03F;
            this.resetBTN.BackColor = System.Drawing.Color.Transparent;
            this.resetBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.resetBTN.BorderColor = System.Drawing.Color.Black;
            this.resetBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetBTN.FocusedColor = System.Drawing.Color.Empty;
            this.resetBTN.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBTN.ForeColor = System.Drawing.Color.White;
            this.resetBTN.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.icons8_reset_24;
            this.resetBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.resetBTN.Location = new System.Drawing.Point(668, 441);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.resetBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.resetBTN.OnHoverImage = null;
            this.resetBTN.OnPressedColor = System.Drawing.Color.Black;
            this.resetBTN.Radius = 23;
            this.resetBTN.Size = new System.Drawing.Size(180, 65);
            this.resetBTN.TabIndex = 12;
            this.resetBTN.Text = "Reset";
            this.resetBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetBTN.UseTransfarantBackground = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.AnimationHoverSpeed = 0.07F;
            this.stopBTN.AnimationSpeed = 0.03F;
            this.stopBTN.BackColor = System.Drawing.Color.Transparent;
            this.stopBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.stopBTN.BorderColor = System.Drawing.Color.Black;
            this.stopBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopBTN.FocusedColor = System.Drawing.Color.Empty;
            this.stopBTN.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBTN.ForeColor = System.Drawing.Color.White;
            this.stopBTN.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.icons8_stop_24;
            this.stopBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.stopBTN.Location = new System.Drawing.Point(384, 441);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.stopBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.stopBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.stopBTN.OnHoverImage = null;
            this.stopBTN.OnPressedColor = System.Drawing.Color.Black;
            this.stopBTN.Radius = 23;
            this.stopBTN.Size = new System.Drawing.Size(180, 65);
            this.stopBTN.TabIndex = 11;
            this.stopBTN.Text = "Stop";
            this.stopBTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopBTN.UseTransfarantBackground = true;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // UserTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.ongoingBTN);
            this.Controls.Add(this.breakBTN);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserTimer";
            this.Size = new System.Drawing.Size(962, 681);
            this.Load += new System.EventHandler(this.UserTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton startBTN;
        private Guna.UI.WinForms.GunaButton resetBTN;
        private Guna.UI.WinForms.GunaButton stopBTN;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton ongoingBTN;
        private Guna.UI.WinForms.GunaButton breakBTN;
        private System.Windows.Forms.Timer timer1;
    }
}
