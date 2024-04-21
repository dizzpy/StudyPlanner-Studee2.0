namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    partial class CustomNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomNoteList));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.CustomNoteTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomDeleteIcon = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.gunaElipsePanel1.Controls.Add(this.CustomDeleteIcon);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.CustomNoteTitle);
            this.gunaElipsePanel1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 23;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(407, 244);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // CustomNoteTitle
            // 
            this.CustomNoteTitle.Font = new System.Drawing.Font("Poppins SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomNoteTitle.ForeColor = System.Drawing.Color.White;
            this.CustomNoteTitle.Location = new System.Drawing.Point(26, 27);
            this.CustomNoteTitle.Name = "CustomNoteTitle";
            this.CustomNoteTitle.Size = new System.Drawing.Size(226, 38);
            this.CustomNoteTitle.TabIndex = 0;
            this.CustomNoteTitle.Text = "Lorem ipsum";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 159);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // CustomDeleteIcon
            // 
            this.CustomDeleteIcon.AnimationHoverSpeed = 0.07F;
            this.CustomDeleteIcon.AnimationSpeed = 0.03F;
            this.CustomDeleteIcon.BaseColor = System.Drawing.Color.Transparent;
            this.CustomDeleteIcon.BorderColor = System.Drawing.Color.Black;
            this.CustomDeleteIcon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CustomDeleteIcon.FocusedColor = System.Drawing.Color.Empty;
            this.CustomDeleteIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomDeleteIcon.ForeColor = System.Drawing.Color.White;
            this.CustomDeleteIcon.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.DeleteImgWhite;
            this.CustomDeleteIcon.ImageSize = new System.Drawing.Size(20, 20);
            this.CustomDeleteIcon.Location = new System.Drawing.Point(346, 23);
            this.CustomDeleteIcon.Name = "CustomDeleteIcon";
            this.CustomDeleteIcon.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.CustomDeleteIcon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CustomDeleteIcon.OnHoverForeColor = System.Drawing.Color.White;
            this.CustomDeleteIcon.OnHoverImage = null;
            this.CustomDeleteIcon.OnPressedColor = System.Drawing.Color.Transparent;
            this.CustomDeleteIcon.Size = new System.Drawing.Size(39, 42);
            this.CustomDeleteIcon.TabIndex = 2;
            // 
            // CustomNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "CustomNoteList";
            this.Size = new System.Drawing.Size(407, 244);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton CustomDeleteIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomNoteTitle;
    }
}
