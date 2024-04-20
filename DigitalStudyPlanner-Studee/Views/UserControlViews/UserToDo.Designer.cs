namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class UserToDo
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
            this.SuspendLayout();
            // 
            // openAddTaskWindow
            // 
            this.openAddTaskWindow.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddTaskWindow.Location = new System.Drawing.Point(806, 17);
            this.openAddTaskWindow.Name = "openAddTaskWindow";
            this.openAddTaskWindow.Size = new System.Drawing.Size(139, 47);
            this.openAddTaskWindow.TabIndex = 0;
            this.openAddTaskWindow.Text = "Add Task";
            this.openAddTaskWindow.UseVisualStyleBackColor = true;
            this.openAddTaskWindow.Click += new System.EventHandler(this.openAddTaskWindow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(928, 586);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UserToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.openAddTaskWindow);
            this.Name = "UserToDo";
            this.Size = new System.Drawing.Size(962, 681);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAddTaskWindow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
