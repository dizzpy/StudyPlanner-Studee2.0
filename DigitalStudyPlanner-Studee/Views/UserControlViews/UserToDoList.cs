using DigitalStudyPlanner_Studee.Views.ToDoList;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserToDoList : UserControl
    {
        private FirestoreDb db;
        private List<TaskItem> tasks = new List<TaskItem>();

        public void SetLoggedUserEmail(string email)
        {
            // Set the text of the label to the logged user's email address
            lblLoggedUserEmail.Text = email;
        }


        public UserToDoList()
        {
            InitializeComponent();
            openAddTaskWindow.Click += OpenAddTaskWindow_Click;
            InitializeFirestore();
            LoadTasksFromFirestore();
        }
        // Fire Base Initialization
        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "lastfiretodo";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\User\\Desktop\\Studee\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\FileBase-Credentials\\lastfiretodo-firebase.json");
            db = FirestoreDb.Create(projectId);
        }


        private async void LoadTasksFromFirestore()
        {
            try
            {
                CollectionReference userCollection = db.Collection("UserEmailAddrass");
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

                MessageBox.Show("Data loaded successfully");
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
                await db.Collection("UserEmailAddrass").Document(task.TaskID).DeleteAsync();

                MessageBox.Show("Task deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task: " + ex.Message);
            }
        }



        private void OpenAddTaskWindow_Click(object sender, EventArgs e)
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