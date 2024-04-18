using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace Calendar
{
    public partial class UserControlDays : UserControl

    {
        private FirestoreDb _db;
        private string _selectedDate;

        public UserControlDays()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            try
            {

                string projectId = "your-project-id";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "path/to/serviceAccountKey.json");
                _db = FirestoreDb.Create(projectId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Firestore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            _selectedDate = $"{Form1.static_year}-{Form1.static_month}-{lbdays.Text}";
            await DisplayEvent();
        }

        private void displayEvent()
        {
            try
            {
                CollectionReference eventsRef = _db.Collection("events");

                QuerySnapshot querySnapshot = await eventsRef
                    .WhereEqualTo("date", _selectedDate)
                    .Limit(1)
                    .GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    DocumentSnapshot eventDoc = querySnapshot.Documents[0];
                    string eventName = eventDoc.GetValue<string>("eventName");
                    lbevent.Text = eventName;
                }
                else
                {
                    lbevent.Text = "No event for this date.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
