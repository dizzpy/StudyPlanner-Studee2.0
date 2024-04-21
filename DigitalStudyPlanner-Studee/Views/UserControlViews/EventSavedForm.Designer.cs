namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class EventSavedForm
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
            this.AddEvent = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // AddEvent
            // 
            this.AddEvent.AnimationHoverSpeed = 0.07F;
            this.AddEvent.AnimationSpeed = 0.03F;
            this.AddEvent.BackColor = System.Drawing.Color.Transparent;
            this.AddEvent.BaseColor = System.Drawing.Color.Turquoise;
            this.AddEvent.BorderColor = System.Drawing.Color.Black;
            this.AddEvent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddEvent.FocusedColor = System.Drawing.Color.Empty;
            this.AddEvent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent.ForeColor = System.Drawing.Color.White;
            this.AddEvent.Image = null;
            this.AddEvent.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEvent.Location = new System.Drawing.Point(169, 208);
            this.AddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.OnHoverBaseColor = System.Drawing.Color.Turquoise;
            this.AddEvent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEvent.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEvent.OnHoverImage = null;
            this.AddEvent.OnPressedColor = System.Drawing.Color.Black;
            this.AddEvent.Padding = new System.Windows.Forms.Padding(10, 28, 10, 28);
            this.AddEvent.Radius = 15;
            this.AddEvent.Size = new System.Drawing.Size(118, 47);
            this.AddEvent.TabIndex = 14;
            this.AddEvent.Text = "Done";
            this.AddEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(116, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(225, 146);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Event Saved\nSuccessfully !";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventSavedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 300);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventSavedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventSavedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton AddEvent;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}