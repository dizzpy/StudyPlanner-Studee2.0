﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.UserControlViews
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = UserEvent.static_year + "-" + UserEvent.static_month + "-" + UserControlDays.static_day;

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            /*
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
             */

            this.Hide();
            EventSavedForm f1 = new EventSavedForm();
            f1.ShowDialog();
            f1 = null;
            this.Show();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            /* this.Hide();
            UserEvent f2 = new UserEvent();
            f2.ShowDialog();
            f2 = null;
            this.Show(); */
        }
    }
}
