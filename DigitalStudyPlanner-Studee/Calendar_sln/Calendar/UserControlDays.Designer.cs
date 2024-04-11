namespace Calendar
{
    partial class UserControlDays
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
            this.lbdays = new Guna.UI.WinForms.GunaLabel();
            this.lbevent = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(12, 11);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(28, 21);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // lbevent
            // 
            this.lbevent.BackColor = System.Drawing.Color.White;
            this.lbevent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbevent.Location = new System.Drawing.Point(13, 58);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(199, 45);
            this.lbevent.TabIndex = 1;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbdays);
            this.Controls.Add(this.lbevent);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(226, 129);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbdays;
        private Guna.UI.WinForms.GunaLabel lbevent;
        private System.Windows.Forms.Timer timer1;
    }
}
