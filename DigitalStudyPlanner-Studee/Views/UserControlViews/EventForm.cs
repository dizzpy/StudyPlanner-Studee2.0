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
using MySql.Data.MySqlClient;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class EventForm : Form
    {
        //to set the authentication secret and the base path (firebase)
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wt0ghU5wn2oVMJ4QH1vLmoWrUdGHp41Evp4p3avG",
            BasePath = "https://calendar-backend-c77aa-default-rtdb.firebaseio.com/ "
        };

        //creat a variable of firbase client
        IFirebaseClient client;

        /*
        //create a connectionstring (SQL)
        String connString = "server=localhost;user id=root;database=calender";
        */
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            //call the static variable 
            txdate.Text = UserEvent.static_year + "-" + UserEvent.static_month + "-" + UserControlDays.static_day;

            client = new FireSharp.FirebaseClient(config);
            //to check wathever the connection is established
            if (client != null)
            {
                MessageBox.Show("Connection is established");
            }

        }

        private async void AddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Guid.NewGuid().ToString(); // Generate a unique ID
                var data = new Data
                {
                    id = id,
                    date = txdate.Text,
                    eventname = txevent.Text
                };

                // Assuming `client` is your Firebase client instance
                SetResponse response = await client.SetAsync("Event/" + id, data);
                Data result = response.ResultAs<Data>(); // Deserialize Firebase response if needed

                MessageBox.Show("Event Saved with ID: " + id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving event: " + ex.Message);
            }

            /*
            var data = new Data
            {
                id = id,
                date = txdate.Text,
                eventname = txevent.Text
            };
            //for sending data to c# to firebase

            SetResponse response = await client.SetAsync("Event/" + txdate.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Event Saved");
            */

            /*MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String Sql = "INSERT INTO tbl_calender(date,event)values (?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event Saved");
            cmd.Dispose();
            conn.Close();*/


            this.Hide();
            EventSavedForm f1 = new EventSavedForm();
            f1.ShowDialog();
            f1 = null;
            this.Show();
            this.Hide();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
