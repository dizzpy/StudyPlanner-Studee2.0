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
    }
}
