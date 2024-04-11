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
using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class UserControlDays : UserControl

    {
        string connString = "Server=localhost; user id =root; database=db_calendar; sslmode=none";
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
            timer1.Start();
            EventsForm eventform = new EventsForm();
            eventform.Show();
        }

        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
            string Sql = "SELECT * FROM tbl_calender Where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Sql;
            cmd.Parameters.AddWithValue("date", Form1.static_year + "-" + Form1.static_year + "-" + lbdays.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();

            }

            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
