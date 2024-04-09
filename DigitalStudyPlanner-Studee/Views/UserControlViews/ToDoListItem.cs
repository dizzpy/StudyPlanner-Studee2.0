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
    public partial class ToDoListItem : Form
    {
        public ToDoListItem()
        {
            InitializeComponent();
        }

        private void label_goodMorning_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            ToDoListDiscardWindow toDoListDiscardWindow = new ToDoListDiscardWindow();
            toDoListDiscardWindow.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            String text = TextBox1.Text;
            String text2 = CateTextBox1.Text;
            String combobox = PriorityBox.SelectedItem.ToString();

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(combobox);


        }
    }
}
