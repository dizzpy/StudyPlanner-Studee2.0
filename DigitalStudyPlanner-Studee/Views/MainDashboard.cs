using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DigitalStudyPlanner_Studee.Views
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            userDashboard1.Show();
            userDashboard1.BringToFront();
            userEvent1.Hide();
            userNoteLib1.Hide();
            userTimer1.Hide();
            userToDoList1.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            userDashboard1.Show();
            userDashboard1.BringToFront();
            userEvent1.Hide();
            userNoteLib1.Hide();
            userTimer1.Hide();
            userToDoList1.Hide();
        }

        private void btn_toDoList_Click(object sender, EventArgs e)
        {
            userDashboard1.Hide();
            userEvent1.Hide();
            userNoteLib1.Hide();
            userTimer1.Hide();
            userToDoList1.Show();
            userToDoList1.BringToFront();
        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            userDashboard1.Hide();
            userEvent1.Show();
            userEvent1.BringToFront();
            userNoteLib1.Hide();
            userTimer1.Hide();
            userToDoList1.Hide();
        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            userDashboard1.Hide();
            userEvent1.Hide();
            userNoteLib1.Hide();
            userTimer1.Show();
            userTimer1.BringToFront();
            userToDoList1.Hide();
        }

        private void btn_noteLibrary_Click(object sender, EventArgs e)
        {
            userDashboard1.Hide();
            userEvent1.Hide();
            userNoteLib1.Show();
            userNoteLib1.BringToFront();
            userTimer1.Hide();
            userToDoList1.Hide();
        }
    }
}

