using System.CodeDom.Compiler;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Net.Mail;

namespace SocialMediaConcept
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginPanel.Location = new(73, 27);
            SignUpPanel.Location = new(12, 12);
        }

        private void SignUpLB_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            SignUpPanel.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginLB_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Yes");
        }

        private void CreateAccountBTN_Click(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string Username;
            string Password;
            LoginClass CurrentUser = new LoginClass();

            if (String.IsNullOrEmpty(UsernameTB.Text) & String.IsNullOrEmpty(PasswordTB.Text))
            {
                MessageBox.Show("You've not entered anything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Username = UsernameTB.Text;
                Password = PasswordTB.Text;

                try
                {
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand("LoginChecker", cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Username", Username);
                            cmd.Parameters.AddWithValue("@Password", Password);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string GetUsername = reader["Username"].ToString();
                                    string GetPassword = reader["Password_"].ToString();

                                    LoginClass TempUser = new LoginClass(GetUsername, GetPassword);
                                    CurrentUser = TempUser;
                                }
                            }
                            cmd.Dispose();
                            cnn.Close();
                        };

                        if (Username == CurrentUser.LoginUsername && Password == CurrentUser.LoginPassword)
                        {
                            MainWindow form1 = new MainWindow(CurrentUser.LoginUsername);
                            form1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password","Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

           


        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}