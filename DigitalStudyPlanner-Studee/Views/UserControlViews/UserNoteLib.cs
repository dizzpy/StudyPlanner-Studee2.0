using DigitalStudyPlanner_Studee.Models;
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
        private string userLoggedEmail = GlobalVariables.LoggedEmail;

        public UserNoteLib()
        {
            InitializeComponent();
            AddNoteBtn.Click += AddNoteBtn_Click_1;
            InitializeFirestore();
            LoadNotesFromFirestore();
        }

        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "notelibrarytest2";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\User\\Desktop\\New folder (2)\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\notelibrarytest2.json");
            db = FirestoreDb.Create(projectId);
        }

        private async void LoadNotesFromFirestore()
        {
            try
            {
                CollectionReference noteCollection = db.Collection(userLoggedEmail);
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
            //  item.EditNote += Item_EditNote;
                flowLayoutPanel1.Controls.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note to UI: " + ex.Message);
            }
        }


        /* private void Item_EditNote(object sender, NoteItem note)
        {
            using (var addNoteWindow = new AddNoteWindow(note))
            {
                addNoteWindow.NoteUpdated += AddNoteWindow_NoteUpdated;
                addNoteWindow.ShowDialog();
            }
        } */

        /* private void AddNoteWindow_NoteUpdated(object sender, NoteItem note)
        {
            // Find and update the note in the UI
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CustomNoteList customNoteList && customNoteList.Note.NoteId == note.NoteID)
                {
                    customNoteList.Note = note; // Update the note in the CustomNoteList control
                    break;
                }
            }
        } */



        private async void Item_DeleteNote(object sender, NoteItem note)
        {
            try
            {
                // Remove the note from the notes list
                notes.Remove(note);

                // Remove the corresponding CustomNoteList control from the flowLayoutPanel
                flowLayoutPanel1.Controls.Remove((CustomNoteList)sender);

                // Delete the note document from Firestore
                await db.Collection(userLoggedEmail).Document(note.NoteID).DeleteAsync();

                MessageBox.Show("Note deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting note: " + ex.Message);
            }
        }


        private void AddNoteForm_AddNoteClicked(object sender, NoteItem note)
        {
            // Add the note to the notes list
            notes.Add(note);
            // Display the note on the form
            AddNoteToListView(note);
        }


        private void AddNoteBtn_Click_1(object sender, EventArgs e)
        {
            using (var addNoteForm = new AddNoteWindow())
            {
                addNoteForm.AddNoteClicked += AddNoteForm_AddNoteClicked;
                addNoteForm.ShowDialog();
            }
        }


    }
}

