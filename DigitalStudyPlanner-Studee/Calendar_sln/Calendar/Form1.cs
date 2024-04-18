using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace Calendar
{
    public partial class Form1 : Form
    {
        private int month, year;
        private FirestoreDb _db;

        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
            InitializeFirestore();
        }

        private void InitializeFirestore()
        {
            try
            {
                string projectId = "your-project-id";
                string pathToServiceAccountKey = "path/to/serviceAccountKey.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToServiceAccountKey);
                _db = FirestoreDb.Create(projectId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Firestore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displadays();
        }

        private void displadays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            static_month = month;
            static_year = year;

            lbdate.Text = $"{monthName} {year}";

            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)startOfMonth.DayOfWeek;

            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= daysInMonth; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                ucDays.Click += UserControlDays_Click;
                daycontainer.Controls.Add(ucDays);
            }
        }
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            UserControlDays clickedDay = sender as UserControlDays;
            static_day = clickedDay.lbdays.Text;
            ShowEventsForm();
        }

        private async void ShowEventsForm()
        {
            EventsForm eventForm = new EventsForm();

            try
            {
                CollectionReference eventsRef = _db.Collection("events");

                QuerySnapshot querySnapshot = await eventsRef
                    .WhereEqualTo("date", $"{static_year}-{static_month}-{static_day}")
                    .Limit(1)
                    .GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    DocumentSnapshot eventDoc = querySnapshot.Documents[0];
                    string eventName = eventDoc.GetValue<string>("eventName");
                    eventForm.SetEventName(eventName);
                }
                else
                {
                    eventForm.SetEventName("No event for this date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            eventForm.Show();
        }
        private void btnprevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            static_month = month;
            static_year = year;

            DisplayDays();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;

            DisplayDays();
        }
    }
}
}
