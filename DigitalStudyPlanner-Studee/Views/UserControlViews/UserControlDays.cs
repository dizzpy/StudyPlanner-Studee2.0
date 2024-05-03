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

        String connString = "server=localhost;user id=root;database=calender";
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

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            //start timer if usercontroldays is clicked
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        
        private async void displayEvent()
        {
            FirebaseResponse response = await client.GetAsync("tbl_calender/" + UserEvent.static_year + "-" + UserEvent.static_month + "-" + lbdays.Text);
            Data obj = response.ResultAs<Data>();
            lbdis.Text = obj.eventname;
            MessageBox.Show("Event is displayed");
            /*MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string Sql = "SELECT * FROM tbl_calender Where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Sql;
            cmd.Parameters.AddWithValue("date", UserEvent.static_year + "-" + UserEvent.static_year + "-" + lbdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();

            }

            reader.Dispose();
            cmd.Dispose();
            conn.Close();*/ 
        }

        
        //creat a timer for auto display event if new event is added
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //call the display event
            displayEvent();
        }
    }
}
