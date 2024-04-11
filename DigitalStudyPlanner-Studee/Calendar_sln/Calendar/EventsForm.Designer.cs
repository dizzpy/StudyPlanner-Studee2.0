namespace Calendar
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txevent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txdate = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.gunaLabel1.Image = ((System.Drawing.Image)(resources.GetObject("gunaLabel1.Image")));
            this.gunaLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel1.Location = new System.Drawing.Point(27, 52);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel1.Size = new System.Drawing.Size(139, 24);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "      Add your event";
            // 
            // txevent
            // 
            this.txevent.BackColor = System.Drawing.Color.Transparent;
            this.txevent.BaseColor = System.Drawing.Color.White;
            this.txevent.BorderColor = System.Drawing.Color.Silver;
            this.txevent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txevent.FocusedBaseColor = System.Drawing.Color.White;
            this.txevent.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txevent.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txevent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(66, 79);
            this.txevent.Name = "txevent";
            this.txevent.PasswordChar = '\0';
            this.txevent.Radius = 6;
            this.txevent.SelectedText = "";
            this.txevent.Size = new System.Drawing.Size(487, 50);
            this.txevent.TabIndex = 2;
            this.txevent.Text = "Event Name";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.gunaLabel3.Image = ((System.Drawing.Image)(resources.GetObject("gunaLabel3.Image")));
            this.gunaLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.Location = new System.Drawing.Point(28, 159);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(61, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "          Date";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txdate
            // 
            this.txdate.BackColor = System.Drawing.Color.Transparent;
            this.txdate.BaseColor = System.Drawing.SystemColors.Control;
            this.txdate.BorderColor = System.Drawing.SystemColors.Control;
            this.txdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txdate.Enabled = false;
            this.txdate.FocusedBaseColor = System.Drawing.Color.White;
            this.txdate.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txdate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(66, 187);
            this.txdate.Name = "txdate";
            this.txdate.PasswordChar = '\0';
            this.txdate.SelectedText = "";
            this.txdate.Size = new System.Drawing.Size(487, 50);
            this.txdate.TabIndex = 4;
            this.txdate.Text = "gunaTextBox2";
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(365, 279);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 28, 10, 28);
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(118, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Add Event";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(125, 279);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Padding = new System.Windows.Forms.Padding(10, 28, 10, 28);
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(118, 47);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Discard";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(616, 373);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txdate);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txevent;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txdate;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}