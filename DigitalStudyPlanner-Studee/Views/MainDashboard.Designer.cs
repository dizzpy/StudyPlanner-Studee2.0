﻿namespace DigitalStudyPlanner_Studee.Views
{
    partial class MainDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_noteLibrary = new System.Windows.Forms.Button();
            this.btn_timer = new System.Windows.Forms.Button();
            this.btn_events = new System.Windows.Forms.Button();
            this.btn_toDoList = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DisplayUserNameText = new System.Windows.Forms.Label();
            this.label_goodMorning = new System.Windows.Forms.Label();
            this.label_hello = new System.Windows.Forms.Label();
            this.userNoteLib2 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserNoteLib();
            this.userEvent2 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserEvent();
            this.userDashboard3 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserDashboard();
            this.userTimer2 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserTimer();
            this.userNoteLib3 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserNoteLib();
            this.userDashboard4 = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserDashboard();
            this.userToDo = new DigitalStudyPlanner_Studee.Views.UserControlViews.UserToDo();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SettingButton);
            this.panel5.Controls.Add(this.ProfileButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 563);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 118);
            this.panel5.TabIndex = 3;
            // 
            // SettingButton
            // 
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.SettingButton.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.settings;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(0, 57);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.SettingButton.Size = new System.Drawing.Size(302, 57);
            this.SettingButton.TabIndex = 3;
            this.SettingButton.Text = "Settings";
            this.SettingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.ProfileButton.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.profile;
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.Location = new System.Drawing.Point(0, 0);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ProfileButton.Size = new System.Drawing.Size(302, 57);
            this.ProfileButton.TabIndex = 2;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_noteLibrary);
            this.panel3.Controls.Add(this.btn_timer);
            this.panel3.Controls.Add(this.btn_events);
            this.panel3.Controls.Add(this.btn_toDoList);
            this.panel3.Controls.Add(this.btn_dashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 287);
            this.panel3.TabIndex = 2;
            // 
            // btn_noteLibrary
            // 
            this.btn_noteLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_noteLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_noteLibrary.FlatAppearance.BorderSize = 0;
            this.btn_noteLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_noteLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_noteLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noteLibrary.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btn_noteLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_noteLibrary.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.notes;
            this.btn_noteLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noteLibrary.Location = new System.Drawing.Point(0, 228);
            this.btn_noteLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.btn_noteLibrary.Name = "btn_noteLibrary";
            this.btn_noteLibrary.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_noteLibrary.Size = new System.Drawing.Size(302, 57);
            this.btn_noteLibrary.TabIndex = 5;
            this.btn_noteLibrary.Text = "Note Library";
            this.btn_noteLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noteLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_noteLibrary.UseVisualStyleBackColor = true;
            this.btn_noteLibrary.Click += new System.EventHandler(this.btn_noteLibrary_Click);
            // 
            // btn_timer
            // 
            this.btn_timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_timer.FlatAppearance.BorderSize = 0;
            this.btn_timer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_timer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timer.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btn_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_timer.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.timer;
            this.btn_timer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timer.Location = new System.Drawing.Point(0, 171);
            this.btn_timer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_timer.Name = "btn_timer";
            this.btn_timer.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_timer.Size = new System.Drawing.Size(302, 57);
            this.btn_timer.TabIndex = 4;
            this.btn_timer.Text = "Timer";
            this.btn_timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timer.UseVisualStyleBackColor = true;
            this.btn_timer.Click += new System.EventHandler(this.btn_timer_Click);
            // 
            // btn_events
            // 
            this.btn_events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_events.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_events.FlatAppearance.BorderSize = 0;
            this.btn_events.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_events.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_events.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btn_events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_events.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.events;
            this.btn_events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.Location = new System.Drawing.Point(0, 114);
            this.btn_events.Margin = new System.Windows.Forms.Padding(2);
            this.btn_events.Name = "btn_events";
            this.btn_events.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_events.Size = new System.Drawing.Size(302, 57);
            this.btn_events.TabIndex = 3;
            this.btn_events.Text = "Events";
            this.btn_events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_events.UseVisualStyleBackColor = true;
            this.btn_events.Click += new System.EventHandler(this.btn_events_Click);
            // 
            // btn_toDoList
            // 
            this.btn_toDoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toDoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_toDoList.FlatAppearance.BorderSize = 0;
            this.btn_toDoList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_toDoList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_toDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toDoList.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btn_toDoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_toDoList.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.task1;
            this.btn_toDoList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toDoList.Location = new System.Drawing.Point(0, 57);
            this.btn_toDoList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_toDoList.Name = "btn_toDoList";
            this.btn_toDoList.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_toDoList.Size = new System.Drawing.Size(302, 57);
            this.btn_toDoList.TabIndex = 2;
            this.btn_toDoList.Text = "To Do List";
            this.btn_toDoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toDoList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_toDoList.UseVisualStyleBackColor = true;
            this.btn_toDoList.Click += new System.EventHandler(this.btn_toDoList_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(209)))), ((int)(((byte)(172)))));
            this.btn_dashboard.Image = global::DigitalStudyPlanner_Studee.Properties.Resources.home1;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(302, 57);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DisplayUserNameText);
            this.panel2.Controls.Add(this.label_goodMorning);
            this.panel2.Controls.Add(this.label_hello);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 118);
            this.panel2.TabIndex = 1;
            // 
            // DisplayUserNameText
            // 
            this.DisplayUserNameText.AutoSize = true;
            this.DisplayUserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayUserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.DisplayUserNameText.Location = new System.Drawing.Point(30, 65);
            this.DisplayUserNameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DisplayUserNameText.Name = "DisplayUserNameText";
            this.DisplayUserNameText.Size = new System.Drawing.Size(137, 29);
            this.DisplayUserNameText.TabIndex = 3;
            this.DisplayUserNameText.Text = "Yashohara";
            // 
            // label_goodMorning
            // 
            this.label_goodMorning.AutoSize = true;
            this.label_goodMorning.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goodMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_goodMorning.Location = new System.Drawing.Point(30, 37);
            this.label_goodMorning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_goodMorning.Name = "label_goodMorning";
            this.label_goodMorning.Size = new System.Drawing.Size(129, 28);
            this.label_goodMorning.TabIndex = 2;
            this.label_goodMorning.Text = "Good Morning!";
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.label_hello.Location = new System.Drawing.Point(30, 9);
            this.label_hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(51, 28);
            this.label_hello.TabIndex = 1;
            this.label_hello.Text = "Hello";
            // 
            // userNoteLib2
            // 
            this.userNoteLib2.BackColor = System.Drawing.Color.White;
            this.userNoteLib2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoteLib2.Location = new System.Drawing.Point(304, 0);
            this.userNoteLib2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNoteLib2.Name = "userNoteLib2";
            this.userNoteLib2.Size = new System.Drawing.Size(962, 681);
            this.userNoteLib2.TabIndex = 4;
            // 
            // userEvent2
            // 
            this.userEvent2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEvent2.Location = new System.Drawing.Point(304, 0);
            this.userEvent2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userEvent2.Name = "userEvent2";
            this.userEvent2.Size = new System.Drawing.Size(962, 681);
            this.userEvent2.TabIndex = 3;
            // 
            // userDashboard3
            // 
            this.userDashboard3.BackColor = System.Drawing.Color.White;
            this.userDashboard3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDashboard3.Location = new System.Drawing.Point(304, 0);
            this.userDashboard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userDashboard3.Name = "userDashboard3";
            this.userDashboard3.Size = new System.Drawing.Size(962, 681);
            this.userDashboard3.TabIndex = 2;
            // 
            // userTimer2
            // 
            this.userTimer2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTimer2.Location = new System.Drawing.Point(304, 0);
            this.userTimer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userTimer2.Name = "userTimer2";
            this.userTimer2.Size = new System.Drawing.Size(962, 681);
            this.userTimer2.TabIndex = 1;
            // 
            // userNoteLib3
            // 
            this.userNoteLib3.BackColor = System.Drawing.Color.White;
            this.userNoteLib3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoteLib3.Location = new System.Drawing.Point(304, -4);
            this.userNoteLib3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNoteLib3.Name = "userNoteLib3";
            this.userNoteLib3.Size = new System.Drawing.Size(962, 681);
            this.userNoteLib3.TabIndex = 5;
            // 
            // userDashboard4
            // 
            this.userDashboard4.BackColor = System.Drawing.Color.White;
            this.userDashboard4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDashboard4.Location = new System.Drawing.Point(308, 0);
            this.userDashboard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userDashboard4.Name = "userDashboard4";
            this.userDashboard4.Size = new System.Drawing.Size(962, 681);
            this.userDashboard4.TabIndex = 6;
            // 
            // userToDo
            // 
            this.userToDo.BackColor = System.Drawing.Color.White;
            this.userToDo.Location = new System.Drawing.Point(304, 3);
            this.userToDo.Name = "userToDo";
            this.userToDo.Size = new System.Drawing.Size(962, 681);
            this.userToDo.TabIndex = 7;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userToDo);
            this.Controls.Add(this.userDashboard4);
            this.Controls.Add(this.userNoteLib3);
            this.Controls.Add(this.userNoteLib2);
            this.Controls.Add(this.userEvent2);
            this.Controls.Add(this.userDashboard3);
            this.Controls.Add(this.userTimer2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_goodMorning;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_timer;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_toDoList;
        private System.Windows.Forms.Button btn_noteLibrary;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SettingButton;
        private UserControlViews.UserDashboard userDashboard1;
        private UserControlViews.UserDashboard userDashboard2;
        private UserControlViews.UserEvent userEvent1;
        private UserControlViews.UserNoteLib userNoteLib1;
        private UserControlViews.UserTimer userTimer1;
        private System.Windows.Forms.Label DisplayUserNameText;
        private UserControlViews.UserTimer userTimer2;
        private UserControlViews.UserDashboard userDashboard3;
        private UserControlViews.UserEvent userEvent2;
        private UserControlViews.UserNoteLib userNoteLib2;
        private UserControlViews.UserNoteLib userNoteLib3;
        private UserControlViews.UserDashboard userDashboard4;
        private UserControlViews.UserToDo userToDo;
    }
}