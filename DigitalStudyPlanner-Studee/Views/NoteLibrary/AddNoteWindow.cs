using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    public partial class AddNoteWindow : Form
    {
        public AddNoteWindow()
        {
            InitializeComponent();
            AddNoteToListView.Click += AddNoteToListView_Click;
        }

        private void NoteDiscardBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNoteToListView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
