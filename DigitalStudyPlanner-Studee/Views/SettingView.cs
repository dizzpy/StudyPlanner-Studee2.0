using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views
{
    public partial class SettingView : Form
    {
        public SettingView()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Saved");
            this.Close();
        }
    }
}
