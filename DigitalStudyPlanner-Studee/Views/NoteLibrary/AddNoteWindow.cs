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
 //       private NoteItem noteToEdit;
        public event EventHandler<NoteItem> AddNoteClicked;

        string userLoggedEmail = GlobalVariables.LoggedEmail;


        public AddNoteWindow()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "notelibrarytest2";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\User\\Desktop\\New folder (2)\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\notelibrarytest2.json");
            db = FirestoreDb.Create(projectId);
        }

        private string GenerateNoteID()
        {
            string timestamp = System.DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            string randomNumber = new Random().Next(1000, 9999).ToString();
            string NoteID = "Note" + timestamp + randomNumber;
            return NoteID;
        }


        private async void AddNoteToListView_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a NoteItem object from the form's input fields
                NoteItem note = new NoteItem
                {
                    NoteID = GenerateNoteID(), // Generate a unique note ID
                    NoteTitle = NoteTitleTextBox.Text,
                    NoteContent = NoteContentTextBox.Text,
                };

                // Raise the AddNoteClicked event and pass the note data
                AddNoteClicked?.Invoke(this, note);

                // Create a dictionary to store the note data
                var noteData = new Dictionary<string, object>
                {
                    { "NoteID", note.NoteID },
                    { "Title", note.NoteTitle },
                    { "Content", note.NoteContent },
                };

                // Save the note data to Firestore
                DocumentReference noteDocument = db.Collection(userLoggedEmail).Document(note.NoteID);
                await noteDocument.SetAsync(noteData);

                MessageBox.Show("Note Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note: " + ex.Message);
            }

            // Close the form after adding the note
            this.Close();
        }
   

        private void NoteDiscardBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }


}
