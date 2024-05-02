using DigitalStudyPlanner_Studee.Models;
using DigitalStudyPlanner_Studee.Views.NoteLibrary;
using DigitalStudyPlanner_Studee.Views.ToDoList;
using Google.Cloud.Firestore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DigitalStudyPlanner_Studee.Views.NoteLibrary
{
    public partial class AddNoteWindow : Form
    {
        private FirestoreDb db;
        private NoteItem noteToEdit;
        public event EventHandler<NoteItem> AddNoteClicked;

        string userLoggedEmail = GlobalVariables.LoggedEmail;


        // Event handler delegate for note updated event
        public delegate void NoteUpdatedEventHandler(object sender, NoteItem note);

        // Event raised when a note is updated
        public event NoteUpdatedEventHandler NoteUpdated;

        public AddNoteWindow(NoteItem note = null)
        {
            InitializeComponent();
            InitializeFirestore();

            if (note != null)
            {
                noteToEdit = note;
                NoteTitleTextBox.Text = note.NoteTitle;
                NoteContentTextBox.Text = note.NoteContent;
                AddNoteToListView.Text = "Save Changes";
            }
        }

        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "notelibrarytest2";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\akila\\Desktop\\Studee-Files-New-Final\\Final_1.5\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\notelibrarytest2.json");
            db = FirestoreDb.Create(projectId);
        }

        private string GenerateNoteID()
        {
            string timestamp = System.DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            string randomNumber = new Random().Next(1000, 9999).ToString();
            string NoteID = "Note" + timestamp + randomNumber;
            return NoteID;
        }

        /*private async void NoteDiscardBtn_Click(object sender, EventArgs e)
        {
            Close();
        }*/

        private async void AddNoteToListView_Click(object sender, EventArgs e)
        {
            // Create a TaskItem object from the form's input fields
            NoteItem note = new NoteItem
            {
                NoteID = GenerateNoteID(), // Generate a unique task ID
                NoteTitle = NoteTitleTextBox.Text,
                NoteContent = NoteContentTextBox.Text,

            };

            // Raise the AddTaskClicked event and pass the task data
            AddNoteClicked?.Invoke(this, note);

            // Create a dictionary to store the task data
            var noteData = new Dictionary<string, object>
            {
                { "NoteID", note.NoteID },
                { "Title", note.NoteTitle},
                { "Content", note.NoteContent },

            };

            try
            {
                string noteID = GenerateNoteID();

                DocumentReference noteDocument = db.Collection(userLoggedEmail).Document(note.NoteID);
                await noteDocument.SetAsync(noteData);

                MessageBox.Show("Note Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note: " + ex.Message);
            }

            // Close the form after adding the task
            this.Close();
        }
    

        protected virtual void OnNoteUpdated(NoteItem note)
        {
            NoteUpdated?.Invoke(this, note);
        }





        private void NoteDiscardBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }


}
