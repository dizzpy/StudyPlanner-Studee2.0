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
            this.NotePanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.CustomDeleteIcon = new Guna.UI.WinForms.GunaButton();
            this.CustomnoteContent = new System.Windows.Forms.Label();
            this.CustomNoteTitle = new System.Windows.Forms.Label();
            this.NotePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotePanel
            // 
            this.NotePanel.BackColor = System.Drawing.Color.Transparent;
            this.NotePanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.NotePanel.Controls.Add(this.CustomDeleteIcon);
            this.NotePanel.Controls.Add(this.CustomnoteContent);
            this.NotePanel.Controls.Add(this.CustomNoteTitle);
            this.NotePanel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotePanel.Location = new System.Drawing.Point(0, 0);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Radius = 23;
            this.NotePanel.Size = new System.Drawing.Size(310, 135);
            this.NotePanel.TabIndex = 0;
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
            this.CustomDeleteIcon.Location = new System.Drawing.Point(270, 6);
            this.CustomDeleteIcon.Name = "CustomDeleteIcon";
            this.CustomDeleteIcon.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.CustomDeleteIcon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CustomDeleteIcon.OnHoverForeColor = System.Drawing.Color.White;
            this.CustomDeleteIcon.OnHoverImage = null;
            this.CustomDeleteIcon.OnPressedColor = System.Drawing.Color.Transparent;
            this.CustomDeleteIcon.Size = new System.Drawing.Size(40, 39);
            this.CustomDeleteIcon.TabIndex = 2;
            this.CustomDeleteIcon.Click += new System.EventHandler(this.CustomDeleteIcon_Click);
            // 
            // CustomnoteContent
            // 
            this.CustomnoteContent.Font = new System.Drawing.Font("Poppins Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomnoteContent.ForeColor = System.Drawing.Color.White;
            this.CustomnoteContent.Location = new System.Drawing.Point(8, 50);
            this.CustomnoteContent.Name = "CustomnoteContent";
            this.CustomnoteContent.Size = new System.Drawing.Size(299, 85);
            this.CustomnoteContent.TabIndex = 1;
            this.CustomnoteContent.Text = resources.GetString("CustomnoteContent.Text");
            // 
            // CustomNoteTitle
            // 
            this.CustomNoteTitle.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomNoteTitle.ForeColor = System.Drawing.Color.White;
            this.CustomNoteTitle.Location = new System.Drawing.Point(12, 16);
            this.CustomNoteTitle.Name = "CustomNoteTitle";
            this.CustomNoteTitle.Size = new System.Drawing.Size(234, 36);
            this.CustomNoteTitle.TabIndex = 0;
            this.CustomNoteTitle.Text = "Lorem ipsum";
            this.CustomNoteTitle.Click += new System.EventHandler(this.CustomNoteTitle_Click);
            // 
            // CustomNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotePanel);
            this.Name = "CustomNoteList";
            this.Size = new System.Drawing.Size(310, 135);
            this.NotePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel NotePanel;
        private Guna.UI.WinForms.GunaButton CustomDeleteIcon;
        private System.Windows.Forms.Label CustomnoteContent;
        private System.Windows.Forms.Label CustomNoteTitle;
    }
}
