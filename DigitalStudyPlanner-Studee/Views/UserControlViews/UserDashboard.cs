using Google.Cloud.Firestore;
using DigitalStudyPlanner_Studee.Models;
using DigitalStudyPlanner_Studee.Views.NoteLibrary;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserDashboard : UserControl
    {
        private Quotes quotesObject;
        private System.Timers.Timer timer ;
        private int currentIndex = 0;
        int h, m, s, ms;

        //For Note
        private FirestoreDb db;
        private List<NoteItem> notes = new List<NoteItem>();
        private string userLoggedEmail = GlobalVariables.LoggedEmail;

        public UserDashboard()
        {
            InitializeComponent();
            quotesObject = new Quotes();

            InitializeTimer();
            UpdateLabels();

            LoadCustomListViews();

            //For Note
            InitializeFirestore();
            LoadNotesFromFirestore();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            TimerManager.InitializeTimer(timer, 5000, Timer_Elapsed);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % quotesObject.GetAllQuotes().Count;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (MotiQuoteLabel.InvokeRequired)
            {
                MotiQuoteLabel.Invoke(new MethodInvoker(delegate {
                    MotiQuoteLabel.Text = quotesObject.GetAllQuotes()[currentIndex];
                }));
            }
            else
            {
                MotiQuoteLabel.Text = quotesObject.GetAllQuotes()[currentIndex];
            }
        }

        private void LoadCustomListViews()
        {
            // Clear existing controls in the DashBoardFlowLayout panel
            DashBoardFlowLayout.Controls.Clear();

            // Add custom list views
            /*List<NoteItem> notes = /* Fetch notes from Firestore or any other source */
            /*foreach (NoteItem note in notes)
            {
                CustomNoteList customNoteList = new CustomNoteList(note);
                DashBoardFlowLayout.Controls.Add(customNoteList);
            }*/
        }


        private void DashBoardFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }



        

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {

            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;

        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            label18.Text = "00:00:00:00";
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }

                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                gunaLabel1.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));

            }));


        }


        //For Note
        private void InitializeFirestore()
        {
            // Set up Firestore with your project ID
            string projectId = "notelibrarytest2";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\akila\\Desktop\\Studee-Files-New-Final\\Final_1.8\\StudyPlanner-Studee2.0\\DigitalStudyPlanner-Studee\\notelibrarytest2.json");
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
                //  item.EditNote += Item_EditNote;
                DashBoardFlowLayout.Controls.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note to UI: " + ex.Message);
            }
        }

    }
}
