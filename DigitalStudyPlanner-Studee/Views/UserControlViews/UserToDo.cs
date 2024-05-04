using DigitalStudyPlanner_Studee.Models;
using DigitalStudyPlanner_Studee.Views.ToDoList;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserToDo : UserControl
    {
        private FirestoreDb db;
        private List<TaskItem> tasks = new List<TaskItem>();

        string userLoggedEmail = GlobalVariables.LoggedEmail;

        public UserToDo()
        {
            InitializeComponent();
            openAddTaskWindow.Click += openAddTaskWindow_Click;
            InitializeFirestore();
            LoadTasksFromFirestore();
        }

        private void InitializeFirestore()
        {
            // Change the credentials file path to the path of your own credentials file
            string projectId = "tsetingsampletodo";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\akila\\Desktop\\Studee-Files-New-Final\\Final_1.8\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\firecred.json");
            db = FirestoreDb.Create(projectId);
        }



        private async void LoadTasksFromFirestore()
        {
            try
            {
                CollectionReference userCollection = db.Collection(userLoggedEmail);
                QuerySnapshot querySnapshot = await userCollection.GetSnapshotAsync();

                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Dictionary<string, object> taskData = documentSnapshot.ToDictionary();

                    TaskItem task = new TaskItem
                    {
                        TaskID = documentSnapshot.Id,
                        Name = taskData["Name"].ToString(),
                        Category = taskData["Category"].ToString(),
                        Priority = taskData["Priority"].ToString(),
                        AddedDate = ((Timestamp)taskData["AddedDate"]).ToDateTime(),
                        IsCompleted = (bool)taskData["IsCompleted"]
                    };

                    tasks.Add(task);
                    AddTaskToListView(task);
                }

                MessageBox.Show("To Do List Item Load Successful !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from Firestore: " + ex.Message);
            }
        }

        private void AddTaskToListView(TaskItem task)
        {
            try
            {
                CustomListItem item = new CustomListItem(task);
                item.DeleteTask += Item_DeleteTask;
                flowLayoutPanel1.Controls.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task to UI: " + ex.Message);
            }
        }

        private async void Item_DeleteTask(object sender, TaskItem task)
        {
            try
            {
                // Remove the task from the tasks list
                tasks.Remove(task);

                // Remove the corresponding CustomListItem control from the flowLayoutPanel
                flowLayoutPanel1.Controls.Remove((CustomListItem)sender);

                // Delete the task document from Firestore
                await db.Collection(userLoggedEmail).Document(task.TaskID).DeleteAsync();

                MessageBox.Show("Task deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task: " + ex.Message);
            }
        }

        private void openAddTaskWindow_Click(object sender, EventArgs e)
        {
            using (var addTaskForm = new addTaskWindow())
            {
                addTaskForm.AddTaskClicked += AddTaskForm_AddTaskClicked;
                addTaskForm.ShowDialog();
            }
        }

        private void AddTaskForm_AddTaskClicked(object sender, TaskItem task)
        {
            // Add the task to the tasks list
            tasks.Add(task);
            // Display the task on the form
            AddTaskToListView(task);
        }
    }
}
