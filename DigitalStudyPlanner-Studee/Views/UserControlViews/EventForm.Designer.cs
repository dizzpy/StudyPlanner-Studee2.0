namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.txevent = new Guna.UI.WinForms.GunaTextBox();
            this.AddEvent = new Guna.UI.WinForms.GunaButton();
            this.Discard = new Guna.UI.WinForms.GunaButton();
            this.txdate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lbevent = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // txevent
            // 
            this.txevent.BackColor = System.Drawing.Color.Transparent;
            this.txevent.BaseColor = System.Drawing.Color.Transparent;
            this.txevent.BorderColor = System.Drawing.Color.Silver;
            this.txevent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txevent.FocusedBaseColor = System.Drawing.Color.White;
            this.txevent.FocusedBorderColor = System.Drawing.Color.Black;
            this.txevent.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txevent.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(56, 71);
            this.txevent.Margin = new System.Windows.Forms.Padding(2);
            this.txevent.Name = "txevent";
            this.txevent.PasswordChar = '\0';
            this.txevent.Radius = 6;
            this.txevent.SelectedText = "";
            this.txevent.Size = new System.Drawing.Size(392, 49);
            this.txevent.TabIndex = 22;
            this.txevent.Text = " ";
            // 
            // AddEvent
            // 
            this.AddEvent.AnimationHoverSpeed = 0.07F;
            this.AddEvent.AnimationSpeed = 0.03F;
            this.AddEvent.BackColor = System.Drawing.Color.Transparent;
            this.AddEvent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddEvent.BorderColor = System.Drawing.Color.Black;
            this.AddEvent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddEvent.FocusedColor = System.Drawing.Color.Empty;
            this.AddEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent.ForeColor = System.Drawing.Color.White;
            this.AddEvent.Image = null;
            this.AddEvent.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEvent.Location = new System.Drawing.Point(265, 239);
            this.AddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.OnHoverBaseColor = System.Drawing.Color.Green;
            this.AddEvent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEvent.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEvent.OnHoverImage = null;
            this.AddEvent.OnPressedColor = System.Drawing.Color.Black;
            this.AddEvent.Padding = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.AddEvent.Radius = 15;
            this.AddEvent.Size = new System.Drawing.Size(88, 38);
            this.AddEvent.TabIndex = 21;
            this.AddEvent.Text = "Add Event";
            this.AddEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // Discard
            // 
            this.Discard.AnimationHoverSpeed = 0.07F;
            this.Discard.AnimationSpeed = 0.03F;
            this.Discard.BackColor = System.Drawing.Color.Transparent;
            this.Discard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Discard.BorderColor = System.Drawing.Color.Black;
            this.Discard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Discard.FocusedColor = System.Drawing.Color.Empty;
            this.Discard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discard.ForeColor = System.Drawing.Color.White;
            this.Discard.Image = null;
            this.Discard.ImageSize = new System.Drawing.Size(20, 20);
            this.Discard.Location = new System.Drawing.Point(150, 239);
            this.Discard.Margin = new System.Windows.Forms.Padding(2);
            this.Discard.Name = "Discard";
            this.Discard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Discard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Discard.OnHoverForeColor = System.Drawing.Color.White;
            this.Discard.OnHoverImage = null;
            this.Discard.OnPressedColor = System.Drawing.Color.Black;
            this.Discard.Padding = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.Discard.Radius = 15;
            this.Discard.Size = new System.Drawing.Size(88, 38);
            this.Discard.TabIndex = 20;
            this.Discard.Text = "Discard";
            this.Discard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // txdate
            // 
            this.txdate.AutoSize = true;
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.txdate.Location = new System.Drawing.Point(79, 161);
            this.txdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(160, 21);
            this.txdate.TabIndex = 19;
            this.txdate.Text = "DATA MONTH YEAR";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.gunaLabel3.Image = ((System.Drawing.Image)(resources.GetObject("gunaLabel3.Image")));
            this.gunaLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel3.Location = new System.Drawing.Point(53, 134);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(72, 21);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "       Date";
            // 
            // lbevent
            // 
            this.lbevent.AutoSize = true;
            this.lbevent.BackColor = System.Drawing.Color.Transparent;
            this.lbevent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.lbevent.Image = ((System.Drawing.Image)(resources.GetObject("lbevent.Image")));
            this.lbevent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbevent.Location = new System.Drawing.Point(52, 43);
            this.lbevent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbevent.Name = "lbevent";
            this.lbevent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbevent.Size = new System.Drawing.Size(139, 20);
            this.lbevent.TabIndex = 17;
            this.lbevent.Text = "      Add your event";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.Discard);
            this.Controls.Add(this.txdate);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lbevent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txevent;
        private Guna.UI.WinForms.GunaButton AddEvent;
        private Guna.UI.WinForms.GunaButton Discard;
        private Guna.UI.WinForms.GunaLabel txdate;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lbevent;
    }
}