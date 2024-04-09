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
    public partial class ToDoItemRow : UserControl
    {
        public ToDoItemRow()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
            ToDoListItem toDoListItem = new ToDoListItem();
            toDoListItem.Show();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
