using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.Auth
{
    public partial class LoginView : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=studeedb;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dr;


        public LoginView()
        {
            InitializeComponent();
        }

        private void ToReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterView registerView = new RegisterView();
            registerView.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(LogEmailText.Text) || string.IsNullOrEmpty(LogPasswordText.Text))
                {
                    MessageBox.Show("Please enter EmailAddress and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();
                string selectQuery = "SELECT * FROM users WHERE EmailAddress = @EmailAddress AND Password = @Password";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@EmailAddress", LogEmailText.Text);
                command.Parameters.AddWithValue("@Password", LogPasswordText.Text);
                dr = command.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    string LoggedUserName = LogEmailText.Text;
                    MainDashboard dashboardForm = new MainDashboard();
                    dashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid EmailAddress or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
