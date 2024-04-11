using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class EventsForm : Form
    {
        string connString = "Server=localhost; user id =root; database=db_calendar; sslmode=none";
        public EventsForm()
        {
            InitializeComponent();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            txdate.Text = Form1.static_month + "/" + UserControlDays.static_day + "/" + Form1.static_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String Sql = "INSERT INTO tbl_calender(date,event)values (?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = Sql;
            cmd.Parameters.AddWithValue("date", txdate.Text);
            cmd.Parameters.AddWithValue("event", txevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Event Saved");
            cmd.Dispose();
            conn.Close();
 
        }
    }
}
