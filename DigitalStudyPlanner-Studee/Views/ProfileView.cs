using DigitalStudyPlanner_Studee.Views.Auth;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DigitalStudyPlanner_Studee.Views
{
    public partial class ProfileView : Form
    {
        private readonly string EmailAddress;
        private readonly MySqlConnection connection;

        public ProfileView( string EmailAddress)
        {
            InitializeComponent();
            this.EmailAddress = EmailAddress;
            connection = new MySqlConnection("server=localhost;database=studeedb;port=3306;username=root;password=");
            DisplayProfile();
        }

        private void DisplayProfile()
        {
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
                        DFullName.Text = reader["FullName"].ToString();
                        DOccupation.Text = reader["Occupation"].ToString();
                        DEmailAddress.Text = reader["EmailAddress"].ToString();

                        if (reader["ProfilePicture"] != DBNull.Value)
                        {
                            byte[] img = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                ProfilePicBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Profile Picture Found");
                            this.Close();
                        }
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

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
