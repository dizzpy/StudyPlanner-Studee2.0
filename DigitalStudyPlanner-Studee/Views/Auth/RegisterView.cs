using System;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.Auth
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {

        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView loginView = new LoginView();
            loginView.Show();
        }
    }
}
