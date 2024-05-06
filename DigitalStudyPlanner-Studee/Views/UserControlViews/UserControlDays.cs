using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using MySql.Data.MySqlClient;
using FireSharp.Config;
using FireSharp.Interfaces;


namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class UserControlDays : UserControl


    {
        //to set the authentication secret and the base path (firebase)
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wt0ghU5wn2oVMJ4QH1vLmoWrUdGHp41Evp4p3avG",
            BasePath = "https://calendar-backend-c77aa-default-rtdb.firebaseio.com/ "
        };

        //creat a variable of firbase client
        IFirebaseClient client;
        //static variable
        public static string static_day;


        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private async void UserControlDays_Click(object sender, EventArgs e)
        {
            string selectedDate = $"{UserEvent.static_year}-{UserEvent.static_month}-{lbdays.Text}";

            try
            {
                // Initialize Firebase client
                client = new FireSharp.FirebaseClient(config);

                // Query Firebase for event data based on the selected date
                FirebaseResponse response = await client.GetAsync($"Event/{selectedDate}");

                if (response.Body != "null")
                {
                    Data eventData = response.ResultAs<Data>();

                    // Update the label with the retrieved event name
                    lbdis.Text = eventData.eventname;
                }
                else
                {
                    // Clear the label if no event is found for the selected date
                    lbdis.Text = "No event scheduled for this day";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving event: " + ex.Message);
            }
            static_day = lbdays.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        
        private async void displayEvent()
        {
           /* // Ensure static_day has a valid value
            if (string.IsNullOrEmpty(static_day))
                return;

            try
            {
                // Firebase configuration
                IFirebaseConfig config = new FirebaseConfig
                {
                    AuthSecret = "wt0ghU5wn2oVMJ4QH1vLmoWrUdGHp41Evp4p3avG",
                    BasePath = "https://calendar-backend-c77aa-default-rtdb.firebaseio.com/"
                };

                // Initialize Firebase client
                IFirebaseClient client = new FireSharp.FirebaseClient(config);

                // Fetch event data for the current day (static_day)
                FirebaseResponse response = await client.GetAsync("Event/" + static_day);

                if (response.Body != "null")
                {
                    Data eventData = response.ResultAs<Data>();

                    // Update the label with the retrieved event name
                    lbdis.Text = eventData.eventname;
                }
                else
                {
                    // Clear the label if no event is found for the current day
                    lbdis.Text = "No event scheduled for this day";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., network issues, Firebase errors)
                MessageBox.Show("Error retrieving event: " + ex.Message);
            }*/
        }
        

        //creat a timer for auto display event if new event is added
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Call the displayEvent method on every timer tick
            displayEvent();
        }
    }
}
