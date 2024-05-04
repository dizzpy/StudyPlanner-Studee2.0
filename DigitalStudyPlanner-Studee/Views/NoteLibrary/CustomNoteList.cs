using DigitalStudyPlanner_Studee.Views.ToDoList;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    public partial class CustomNoteList : UserControl
    {

        private NoteItem note;

        public object Note { get; internal set; }

        public event EventHandler<NoteItem> DeleteNote;
        public event EventHandler<NoteItem> EditNote;


        public CustomNoteList(NoteItem noteItem)
        {
            InitializeComponent();
            note = noteItem;
            InitializeNote();
            NotePanel.Click += EditNote_Click;
            CustomnoteContent.Click += EditNote_Click;
            CustomNoteTitle.Click += EditNote_Click;
        }

        private void EditNote_Click(object sender, EventArgs e)
        {
            OnEditNote();
        }


        protected virtual void OnEditNote()
        {
            EditNote?.Invoke(this, note);
        }


        private void InitializeNote()
        {
            CustomNoteTitle.Text = note.NoteTitle;
            CustomnoteContent.Text = note.NoteContent;
        }

        private void CustomDeleteIcon_Click(object sender, EventArgs e)
        {
            OnDeleteNote(note);
        }

        protected virtual void OnDeleteNote(NoteItem noteToDelete)
        {
            DeleteNote?.Invoke(this,noteToDelete);
        }


        /*private void NotePanel_Paint_click(object sender, PaintEventArgs e)
        {
            AddNoteWindow toDoListItem = new AddNoteWindow();
            toDoListItem.Show();
        }*/

        private void CustomNoteTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
