﻿using DigitalStudyPlanner_Studee.Views.ToDoList;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class addTaskWindow : Form
    {
        private FirestoreDb db;

        public event EventHandler<TaskItem> AddTaskClicked;

        public addTaskWindow()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "lastfiretodo";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\User\\Desktop\\Studee\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\FileBase-Credentials\\lastfiretodo-firebase.json");
            db = FirestoreDb.Create(projectId);
        }

        private string GenerateTaskID()
        {
            // Generate a unique task ID using timestamp and a random number
            string timestamp = System.DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // Current timestamp
            string randomNumber = new Random().Next(1000, 9999).ToString(); // Random 4-digit number
            string taskID = timestamp + randomNumber; // Concatenate timestamp and random number
            return taskID;
        }

        private async void AddTaskToListView_Click(object sender, EventArgs e)
        {
            // Create a TaskItem object from the form's input fields
            TaskItem task = new TaskItem
            {
                TaskID = GenerateTaskID(), // Generate a unique task ID
                Name = taskNameTextBox.Text,
                Category = categoryTextBox.Text,
                Priority = priorityTextBox.Text,
                AddedDate = addedDateTimePicker.Value.ToUniversalTime(), // Convert to UTC
                IsCompleted = completedCheckBox.Checked
            };

            // Raise the AddTaskClicked event and pass the task data
            AddTaskClicked?.Invoke(this, task);

            // Create a dictionary to store the task data
            var taskData = new Dictionary<string, object>
            {
                { "taskID", task.TaskID },
                { "Name", task.Name },
                { "Category", task.Category },
                { "Priority", task.Priority },
                { "AddedDate", Timestamp.FromDateTime(task.AddedDate) },
                { "IsCompleted", task.IsCompleted }
            };

            try
            {
                string taskID = GenerateTaskID();

                DocumentReference taskDocument = db.Collection("UserEmailAddrass").Document(task.TaskID);
                await taskDocument.SetAsync(taskData);

                MessageBox.Show("Task Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message);
            }

            // Close the form after adding the task
            this.Close();
        }
    }
}