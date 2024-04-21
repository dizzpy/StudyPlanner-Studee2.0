namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    partial class UserNoteLib
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
            this.label_hello = new System.Windows.Forms.Label();
            this.AddNoteBtn = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Poppins SemiBold", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_hello.Location = new System.Drawing.Point(27, 34);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(268, 68);
            this.label_hello.TabIndex = 2;
            this.label_hello.Text = "Note Library";
            // 
            // AddNoteBtn
            // 
            this.AddNoteBtn.AnimationHoverSpeed = 0.07F;
            this.AddNoteBtn.AnimationSpeed = 0.03F;
            this.AddNoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddNoteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteBtn.BorderColor = System.Drawing.Color.Black;
            this.AddNoteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddNoteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddNoteBtn.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNoteBtn.ForeColor = System.Drawing.Color.White;
            this.AddNoteBtn.Image = null;
            this.AddNoteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddNoteBtn.Location = new System.Drawing.Point(736, 48);
            this.AddNoteBtn.Name = "AddNoteBtn";
            this.AddNoteBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.AddNoteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddNoteBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteBtn.OnHoverImage = null;
            this.AddNoteBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddNoteBtn.Radius = 10;
            this.AddNoteBtn.Size = new System.Drawing.Size(181, 52);
            this.AddNoteBtn.TabIndex = 3;
            this.AddNoteBtn.Text = "Add Note";
            this.AddNoteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddNoteBtn.Click += new System.EventHandler(this.AddNoteBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 563);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // UserNoteLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AddNoteBtn);
            this.Controls.Add(this.label_hello);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserNoteLib";
            this.Size = new System.Drawing.Size(962, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hello;
        private Guna.UI.WinForms.GunaButton AddNoteBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
