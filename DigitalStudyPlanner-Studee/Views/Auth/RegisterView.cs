using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace DigitalStudyPlanner_Studee.Views.Auth
{
    public partial class RegisterView : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=studeedb;port=3306;username=root;password=");

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
            try
            {
                if (string.IsNullOrEmpty(RegFullNameText.Text) || string.IsNullOrEmpty(RegOccuText.Text) || string.IsNullOrEmpty(RegEmailText.Text) || string.IsNullOrEmpty(RegPassText.Text))
                {
                    MessageBox.Show("Please Fill The All Information");
                    return;
                }

                connection.Open();
                MySqlCommand mySqlCommand1 = new MySqlCommand("SELECT * FROM users WHERE EmailAddress = @EmailAddress", connection);
                mySqlCommand1.Parameters.AddWithValue("@EmailAddress", RegFullNameText.Text);
                bool userExists = false;

                using (var dr1 = mySqlCommand1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username Allready Exist");

                if (!userExists)
                {
                    string iquery = "INSERT INTO studeedb.users(`ID`, `FullName`, `Occupation`, `EmailAddress`, `Password`, `ProfilePicture`) VALUES(NULL,@FullName, @Occupation,@EmailAddress, @Password, @ProfilePicture)";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@FullName", RegFullNameText.Text);
                    commandDatabase.Parameters.AddWithValue("@Occupation", RegOccuText.Text);
                    commandDatabase.Parameters.AddWithValue("@EmailAddress", RegEmailText.Text);
                    commandDatabase.Parameters.AddWithValue("@Password", RegPassText.Text);

                    if (RegProPicButton.Image != null)
                    {
                        byte[] imageData = ImageToByteArray(RegProPicButton.Image);
                        commandDatabase.Parameters.AddWithValue("@ProfilePicture", imageData);
                    }
                    else
                    {
                        commandDatabase.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                    }


                    commandDatabase.CommandTimeout = 60;
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    string LoggedUserName = RegEmailText.Text;
                    MainDashboard dashboardForm = new MainDashboard(LoggedUserName);
                    dashboardForm.Show(); ;
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



            // Convert Image to Byte Array
            byte[] ImageToByteArray(Image image)
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(image, typeof(byte[]));
            }
        }

        private void RegProPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*jpg;*jpeg;*png";
            fileDialog.Title = "Select an Image File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                RegProPicButton.Image = new Bitmap(fileDialog.FileName);
            }
        }
    }
}
