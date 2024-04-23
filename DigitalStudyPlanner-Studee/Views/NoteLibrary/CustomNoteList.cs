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
        public event EventHandler<NoteItem> DeleteNote;
        public event EventHandler<NoteItem> EditNote;

        public NoteItem Note
        {
            get { return note; }
            set
            {
                note = value;
                InitializeTask();
            }
        }

        public CustomNoteList(NoteItem noteItem)
        {
            InitializeComponent();
            Note = noteItem;
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
            EditNote?.Invoke(this, Note);
        }


        private void InitializeTask()
        {
            CustomNoteTitle.Text = Note.NoteTitle;
            CustomnoteContent.Text = Note.NoteContent;
        }

        private void CustomDeleteIcon_Click(object sender, EventArgs e)
        {
            OnDeleteNote();
        }

        protected virtual void OnDeleteNote()
        {
            DeleteNote?.Invoke(this, Note);
        }

        private void CustomNoteList_Load(object sender, EventArgs e)
        {

        }

        private void NotePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
