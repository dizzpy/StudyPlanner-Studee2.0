namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    partial class AddNoteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteWindow));
            this.NoteTitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NoteContentTextBox = new System.Windows.Forms.RichTextBox();
            this.AddNoteToListView = new Guna.UI.WinForms.GunaAdvenceButton();
            this.NoteDiscardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // NoteTitleTextBox
            // 
            this.NoteTitleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.NoteTitleTextBox.BorderRadius = 3;
            this.NoteTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoteTitleTextBox.DefaultText = "";
            this.NoteTitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NoteTitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NoteTitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteTitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteTitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteTitleTextBox.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteTitleTextBox.Location = new System.Drawing.Point(24, 32);
            this.NoteTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NoteTitleTextBox.Name = "NoteTitleTextBox";
            this.NoteTitleTextBox.PasswordChar = '\0';
            this.NoteTitleTextBox.PlaceholderText = "Enter Task Tile";
            this.NoteTitleTextBox.SelectedText = "";
            this.NoteTitleTextBox.Size = new System.Drawing.Size(976, 52);
            this.NoteTitleTextBox.TabIndex = 5;
            // 
            // NoteContentTextBox
            // 
            this.NoteContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteContentTextBox.Font = new System.Drawing.Font("Poppins ExtraLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteContentTextBox.Location = new System.Drawing.Point(24, 117);
            this.NoteContentTextBox.Name = "NoteContentTextBox";
            this.NoteContentTextBox.Size = new System.Drawing.Size(976, 539);
            this.NoteContentTextBox.TabIndex = 6;
            this.NoteContentTextBox.Text = resources.GetString("NoteContentTextBox.Text");
            // 
            // AddNoteToListView
            // 
            this.AddNoteToListView.AnimationHoverSpeed = 0.07F;
            this.AddNoteToListView.AnimationSpeed = 0.03F;
            this.AddNoteToListView.BackColor = System.Drawing.Color.Transparent;
            this.AddNoteToListView.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteToListView.BorderColor = System.Drawing.Color.Black;
            this.AddNoteToListView.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddNoteToListView.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddNoteToListView.CheckedForeColor = System.Drawing.Color.White;
            this.AddNoteToListView.CheckedImage = null;
            this.AddNoteToListView.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddNoteToListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNoteToListView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddNoteToListView.FocusedColor = System.Drawing.Color.Empty;
            this.AddNoteToListView.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNoteToListView.ForeColor = System.Drawing.Color.White;
            this.AddNoteToListView.Image = null;
            this.AddNoteToListView.ImageSize = new System.Drawing.Size(20, 20);
            this.AddNoteToListView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteToListView.Location = new System.Drawing.Point(791, 682);
            this.AddNoteToListView.Name = "AddNoteToListView";
            this.AddNoteToListView.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteToListView.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddNoteToListView.OnHoverForeColor = System.Drawing.Color.White;
            this.AddNoteToListView.OnHoverImage = null;
            this.AddNoteToListView.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.AddNoteToListView.OnPressedColor = System.Drawing.Color.Black;
            this.AddNoteToListView.Radius = 8;
            this.AddNoteToListView.Size = new System.Drawing.Size(209, 52);
            this.AddNoteToListView.TabIndex = 13;
            this.AddNoteToListView.Text = "Save Changes";
            this.AddNoteToListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddNoteToListView.Click += new System.EventHandler(this.AddNoteToListView_Click);
            // 
            // NoteDiscardBtn
            // 
            this.NoteDiscardBtn.AnimationHoverSpeed = 0.07F;
            this.NoteDiscardBtn.AnimationSpeed = 0.03F;
            this.NoteDiscardBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoteDiscardBtn.BaseColor = System.Drawing.Color.Transparent;
            this.NoteDiscardBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NoteDiscardBtn.BorderSize = 2;
            this.NoteDiscardBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.NoteDiscardBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.NoteDiscardBtn.CheckedForeColor = System.Drawing.Color.White;
            this.NoteDiscardBtn.CheckedImage = null;
            this.NoteDiscardBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.NoteDiscardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoteDiscardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoteDiscardBtn.FocusedColor = System.Drawing.Color.Empty;
            this.NoteDiscardBtn.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteDiscardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NoteDiscardBtn.Image = null;
            this.NoteDiscardBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.NoteDiscardBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.NoteDiscardBtn.Location = new System.Drawing.Point(578, 682);
            this.NoteDiscardBtn.Name = "NoteDiscardBtn";
            this.NoteDiscardBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NoteDiscardBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NoteDiscardBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.NoteDiscardBtn.OnHoverImage = null;
            this.NoteDiscardBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NoteDiscardBtn.OnPressedColor = System.Drawing.Color.Black;
            this.NoteDiscardBtn.Radius = 8;
            this.NoteDiscardBtn.Size = new System.Drawing.Size(186, 52);
            this.NoteDiscardBtn.TabIndex = 14;
            this.NoteDiscardBtn.Text = "Discard";
            this.NoteDiscardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoteDiscardBtn.Click += new System.EventHandler(this.NoteDiscardBtn_Click_1);
            // 
            // AddNoteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 751);
            this.Controls.Add(this.NoteDiscardBtn);
            this.Controls.Add(this.AddNoteToListView);
            this.Controls.Add(this.NoteContentTextBox);
            this.Controls.Add(this.NoteTitleTextBox);
            this.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddNoteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNoteWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NoteTitleTextBox;
        private System.Windows.Forms.RichTextBox NoteContentTextBox;
        private Guna.UI.WinForms.GunaAdvenceButton AddNoteToListView;
        private Guna.UI.WinForms.GunaAdvenceButton NoteDiscardBtn;
    }
}