using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    public partial class SignUp : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=SocialNetwork;Integrated Security=True;TrustServerCertificate=True");
        //private static string strConnString = "";

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            try { 

                con.Open();
                string userName = txtName.Text;
                string userPassword = txtPassword.Text;
                string userEmail = txtEmail.Text;
                string userCountry = cbCountry.Text;

                if (userName.Equals(""))
                {
                    MessageBox.Show("Please enter a username.");
                }
                else if (userPassword.Equals(""))
                {
                    MessageBox.Show("Please enter a password.");
                }
                else if (userEmail.Equals(""))
                {
                    MessageBox.Show("Please enter an email address.");
                }
                else if (userCountry.Equals(""))
                {
                    MessageBox.Show("Please select a country.");
                }
                else
                {
                    MessageBox.Show($"Welcome {userName}! You have successfully signed up.");
               
                    SqlCommand cmd = new SqlCommand("insert into Users(Name,Email,[Password],Country) values('"+userName+" ',' " +userEmail+" ',' "+userPassword+" ',' "+userCountry+"')");
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                return;
            }
           
        }
    }
}
