using DigitalStudyPlanner_Studee.Views.UserControlViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.ToDoList
{
    public partial class CustomListItem : UserControl
    {
        private TaskItem task;

        public event EventHandler<TaskItem> DeleteTask;


        public CustomListItem(TaskItem taskItem)
        {
            InitializeComponent();
            task = taskItem;
            InitializeTask();
            deleteItemFromList.Click += DeleteItemFromList_Click;
        }

        private void InitializeTask()
        {
            taskname.Text = task.Name;
            taskcato.Text = task.Category;
            taskprio.Text = task.Priority;
            taskdate.Text = task.AddedDate.ToString();
            iscom.Checked = task.IsCompleted;
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
            addTaskWindow toDoListItem = new addTaskWindow();
            toDoListItem.Show();
        }

        private void DeleteItemFromList_Click(object sender, EventArgs e)
        {
            OnDeleteTask(task);
        }

        protected virtual void OnDeleteTask(TaskItem taskToDelete)
        {
            DeleteTask?.Invoke(this, taskToDelete);
        }

    }
}
