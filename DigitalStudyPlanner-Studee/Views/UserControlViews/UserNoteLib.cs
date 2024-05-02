using DigitalStudyPlanner_Studee.Views.NoteLibrary;
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
    public partial class UserNoteLib : UserControl
    {
        private FirestoreDb db;
        private List<NoteItem> notes = new List<NoteItem>();

        public UserNoteLib()
        {
            InitializeComponent();
            InitializeFirestore();
            LoadNotesFromFirestore();
        }

        private void InitializeFirestore()
        {
            string projectId = "notelibrarytest2";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\akila\\Desktop\\Studee-Files-New-Final\\Final_1.5\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\notelibrarytest2.json");
            db = FirestoreDb.Create(projectId);
        }

        private async void LoadNotesFromFirestore()
        {
            try
            {
                CollectionReference noteCollection = db.Collection("Notes");
                QuerySnapshot querySnapshot = await noteCollection.GetSnapshotAsync();

                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Dictionary<string, object> noteData = documentSnapshot.ToDictionary();

                    NoteItem note = new NoteItem
                    {
                        NoteID = documentSnapshot.Id,
                        NoteTitle = noteData["Title"].ToString(),
                        NoteContent = noteData["Content"].ToString(),
                    };

                    notes.Add(note);
                    AddNoteToListView(note);
                }

                MessageBox.Show("Data loaded successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from Firestore: " + ex.Message);
            }
        }

        private void AddNoteToListView(NoteItem note)
        {
            try
            {
                CustomNoteList item = new CustomNoteList(note);
                item.DeleteNote += Item_DeleteNote;
                item.EditNote += Item_EditNote;
                flowLayoutPanel1.Controls.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note to UI: " + ex.Message);
            }
        }

        private async void Item_EditNote(object sender, NoteItem note)
        {
            using (var addNoteWindow = new AddNoteWindow(note))
            {
                addNoteWindow.NoteUpdated += AddNoteWindow_NoteUpdated;
                addNoteWindow.ShowDialog();
            }
        }

        private async void Item_DeleteNote(object sender, NoteItem note)
        {
            try
            {
                CustomNoteList cardToRemove = (CustomNoteList)sender;
                notes.Remove(note);
                flowLayoutPanel1.Controls.Remove(cardToRemove);

                await db.Collection("Notes").Document(note.NoteID).DeleteAsync();

                MessageBox.Show("Note deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting note: " + ex.Message);
            }
        }



        private void AddNoteWindow_NoteUpdated(object sender, NoteItem note)
        {
            // Find and update the note in the UI
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CustomNoteList customNoteList && customNoteList.Note.NoteID == note.NoteID)
                {
                    customNoteList.Note = note; // Update the note in the CustomNoteList control
                    break;
                }
            }
        }



        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            using (var addNoteWindow = new AddNoteWindow())
            {
                addNoteWindow.NoteUpdated += AddNoteWindow_NoteUpdated;
                addNoteWindow.ShowDialog();
            }
        }


    }
}

