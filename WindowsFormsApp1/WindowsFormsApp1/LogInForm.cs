using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text;
            string password = this.txtPassword.Text;

            if (userName.ToLower() != "Shahriyar".ToLower() || password != "12345")
            {
                this.lblMessage.Visible = true;
                //MessageBox.Show("Invalid username or password");
                return;
            }
            this.lblMessage.Visible = false;

            HomeForm hf = new HomeForm();
            hf.Show();
            this.Hide();
        }
    }
}
