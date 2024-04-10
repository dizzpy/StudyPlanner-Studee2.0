using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.Auth
{
    public partial class RegisterView : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=csharploginform;port=3306;username=root;password=");

        public RegisterView()
        {
            InitializeComponent();
        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegFullNameText.Text) || string.IsNullOrEmpty(RegOccuText.Text) || string.IsNullOrEmpty(RegEmailText.Text) || string.IsNullOrEmpty(RegPassText.Text))
            {
                MessageBox.Show("Please Fill The All Information");
                return;
            }
        }
    }
}
