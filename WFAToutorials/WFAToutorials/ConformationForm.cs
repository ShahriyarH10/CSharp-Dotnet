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
    public partial class ConformationForm : Form
    {
        public ConformationForm()
        {
            InitializeComponent();
        }

        private void ConformationForm_Load(object sender, EventArgs e)
        {

            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

            lblYFName.Text = SignUpForm.fName;
            lblYLName.Text = SignUpForm.lName;
            lblYEmail.Text = SignUpForm.emailAddress;

            if(SignUpForm.sms == true)
            {
                lblSMS.Text = "✓";
            }
            if (SignUpForm.sms == true)
            {
                lblReports.Text = "✓";
            }
            if (SignUpForm.sms == true)
            {
                lblTransaction.Text = "✓";
            }

        }

        private void ConformationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
