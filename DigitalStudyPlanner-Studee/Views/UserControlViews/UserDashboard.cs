using DigitalStudyPlanner_Studee.Models;
using DigitalStudyPlanner_Studee.Views.NoteLibrary;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserDashboard : UserControl
    {
        private Quotes quotesObject;
        private System.Timers.Timer timer;
        private int currentIndex = 0;

        public UserDashboard()
        {
            InitializeComponent();
            quotesObject = new Quotes();

            InitializeTimer();
            UpdateLabels();

            LoadCustomListViews();
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
            List<NoteItem> notes = /* Fetch notes from Firestore or any other source */;
            foreach (NoteItem note in notes)
            {
                CustomNoteList customNoteList = new CustomNoteList(note);
                DashBoardFlowLayout.Controls.Add(customNoteList);
            }
        }


        private void DashBoardFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
