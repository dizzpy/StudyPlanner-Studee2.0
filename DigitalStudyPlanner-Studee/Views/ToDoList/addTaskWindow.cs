using DigitalStudyPlanner_Studee.Models;
using DigitalStudyPlanner_Studee.Views.ToDoList;
using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string userLoggedEmail = GlobalVariables.LoggedEmail;

        public addTaskWindow()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            // Change the credentials file path to the path of your own credentials file
            string projectId = "tsetingsampletodo";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\akila\\Desktop\\Studee-Files-New-Final\\Final_1.5\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\firecred.json");
            db = FirestoreDb.Create(projectId);
        }



        private string GenerateTaskID()
        {
            // Generate a unique task ID using timestamp and a random number
            string timestamp = System.DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            string randomNumber = new Random().Next(1000, 9999).ToString();
            string taskID = timestamp + randomNumber;
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

                DocumentReference taskDocument = db.Collection(userLoggedEmail).Document(task.TaskID);
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
