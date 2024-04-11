namespace Calendar
{
    partial class Form1
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnnext = new Guna.UI.WinForms.GunaButton();
            this.btnprevious = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.lbdate = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daycontainer.Location = new System.Drawing.Point(42, 178);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(2);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1628, 816);
            this.daycontainer.TabIndex = 0;
            // 
            // btnnext
            // 
            this.btnnext.AnimationHoverSpeed = 0.07F;
            this.btnnext.AnimationSpeed = 0.03F;
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.BaseColor = System.Drawing.Color.White;
            this.btnnext.BorderColor = System.Drawing.Color.Black;
            this.btnnext.BorderSize = 3;
            this.btnnext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnnext.FocusedColor = System.Drawing.Color.Empty;
            this.btnnext.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.Black;
            this.btnnext.Image = null;
            this.btnnext.ImageSize = new System.Drawing.Size(20, 20);
            this.btnnext.Location = new System.Drawing.Point(380, 29);
            this.btnnext.Name = "btnnext";
            this.btnnext.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnnext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnnext.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnnext.OnHoverImage = null;
            this.btnnext.OnPressedColor = System.Drawing.Color.Black;
            this.btnnext.Radius = 8;
            this.btnnext.Size = new System.Drawing.Size(50, 50);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = ">";
            this.btnnext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.AnimationHoverSpeed = 0.07F;
            this.btnprevious.AnimationSpeed = 0.03F;
            this.btnprevious.BackColor = System.Drawing.Color.Transparent;
            this.btnprevious.BaseColor = System.Drawing.Color.White;
            this.btnprevious.BorderColor = System.Drawing.Color.Black;
            this.btnprevious.BorderSize = 3;
            this.btnprevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnprevious.FocusedColor = System.Drawing.Color.Empty;
            this.btnprevious.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.Black;
            this.btnprevious.Image = null;
            this.btnprevious.ImageSize = new System.Drawing.Size(20, 20);
            this.btnprevious.Location = new System.Drawing.Point(307, 29);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnprevious.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnprevious.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnprevious.OnHoverImage = null;
            this.btnprevious.OnPressedColor = System.Drawing.Color.Black;
            this.btnprevious.Radius = 8;
            this.btnprevious.Size = new System.Drawing.Size(50, 50);
            this.btnprevious.TabIndex = 2;
            this.btnprevious.Text = "<";
            this.btnprevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(37, 125);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Monday";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(270, 125);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Tuesday";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(503, 125);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Wednesday";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(736, 125);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Thursday";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(969, 125);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Friday";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(1202, 125);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel6.TabIndex = 7;
            this.gunaLabel6.Text = "Saturday";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(1435, 125);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel7.TabIndex = 8;
            this.gunaLabel7.Text = "Sunday";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(1202, 43);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(464, 36);
            this.lbdate.TabIndex = 9;
            this.lbdate.Text = "MONTH YEAR";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 1039);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private Guna.UI.WinForms.GunaButton btnnext;
        private Guna.UI.WinForms.GunaButton btnprevious;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel lbdate;
    }
}

