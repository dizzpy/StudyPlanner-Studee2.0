namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class UserToDoList
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
            this.openAddTaskWindow = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLoggedUserEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openAddTaskWindow
            // 
            this.openAddTaskWindow.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddTaskWindow.Location = new System.Drawing.Point(791, 13);
            this.openAddTaskWindow.Name = "openAddTaskWindow";
            this.openAddTaskWindow.Size = new System.Drawing.Size(152, 53);
            this.openAddTaskWindow.TabIndex = 4;
            this.openAddTaskWindow.Text = "Add Task";
            this.openAddTaskWindow.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 586);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblLoggedUserEmail
            // 
            this.lblLoggedUserEmail.AutoSize = true;
            this.lblLoggedUserEmail.Location = new System.Drawing.Point(11, 28);
            this.lblLoggedUserEmail.Name = "lblLoggedUserEmail";
            this.lblLoggedUserEmail.Size = new System.Drawing.Size(46, 23);
            this.lblLoggedUserEmail.TabIndex = 5;
            this.lblLoggedUserEmail.Text = "label1";
            // 
            // UserToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLoggedUserEmail);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.openAddTaskWindow);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserToDoList";
            this.Size = new System.Drawing.Size(962, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openAddTaskWindow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblLoggedUserEmail;
    }
}
