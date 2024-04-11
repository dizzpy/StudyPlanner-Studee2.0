using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DigitalStudyPlanner_Studee.Views
{
    public partial class MainDashboard : Form
    {
        private readonly string EmailAddress;
        private readonly MySqlConnection connection;


        public MainDashboard(string EmailAddress)
        {
            InitializeComponent();
            this.EmailAddress = EmailAddress;
            connection = new MySqlConnection("server=localhost;database=studeedb;port=3306;username=root;password=");
            DisplayUserData();
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

            // Show the to-do list user control
            userToDoList1.Show();
            userToDoList1.BringToFront();

            // Pass the logged user's email address to the to-do list user control
            //userToDoList1.SetLoggedUserEmail(EmailAddress);
            // Alternatively, you can use a method to set the email address
            // userToDoList1.SetLoggedUserEmail(EmailAddress);
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            string LoggedUserName = EmailAddress;
            ProfileView profileView = new ProfileView(LoggedUserName);
            profileView.Show();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingView settingView = new SettingView();
            settingView.Show();
        }

        private void DisplayUserData()
        {
            // Display User Username in "DisplayUserNameText" label
            try
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE EmailAddress = @EmailAddress";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmailAddress", EmailAddress);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DisplayUserNameText.Text = reader["FullName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }   


        }
    }
}

