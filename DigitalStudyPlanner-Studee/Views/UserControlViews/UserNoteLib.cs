using DigitalStudyPlanner_Studee.Views.NoteLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserNoteLib : UserControl
    {
        public UserNoteLib()
        {
            InitializeComponent();

        }

        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            AddNoteWindow addNoteWindow = new AddNoteWindow();
            addNoteWindow.Show();

           

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
