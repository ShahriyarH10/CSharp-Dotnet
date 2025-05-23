using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAToutorials
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string id = txtUserId.Text;
            string pass = txtPassword.Text;


            if (id == "i25" && pass == "123456")
            {
                
                Welcome f1 = new Welcome();
                f1.Show(this);
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }
        private void ResetMyForm()
        {
            txtUserId.Text = "";
            txtPassword.Text = "";

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SignUpForm sf = new SignUpForm();
            sf.Show(this);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
