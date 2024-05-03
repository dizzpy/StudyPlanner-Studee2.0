namespace DigitalStudyPlanner_Studee.Views.UserControlViews
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
            this.lbdays = new System.Windows.Forms.Label();
            this.lbevent = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbdis = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(2, 2);
            this.lbdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(28, 21);
            this.lbdays.TabIndex = 1;
            this.lbdays.Text = "00";
            // 
            // lbevent
            // 
            this.lbevent.AutoSize = true;
            this.lbevent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbevent.Location = new System.Drawing.Point(6, 27);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(0, 13);
            this.lbevent.TabIndex = 2;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbdis
            // 
            this.lbdis.AutoSize = true;
            this.lbdis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbdis.Location = new System.Drawing.Point(6, 27);
            this.lbdis.Name = "lbdis";
            this.lbdis.Size = new System.Drawing.Size(0, 15);
            this.lbdis.TabIndex = 3;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbdis);
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(94, 52);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private Guna.UI.WinForms.GunaLabel lbevent;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel lbdis;
    }
}
