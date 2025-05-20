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
    public partial class SignUpForm : Form
    {
        public static string fName;
        public static string lName;
        public static string emailAddress;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void cbSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSMS.Checked)
            {
                sms = true;

                lblSMS.Text = "SMS Subscription: Yes";

            }
            else
            {
                sms = false;
                lblSMS.Text = "SMS Subscription: No";
            }
        }

        private void cbReports_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReports.Checked)
            {
                reports = true;

            }
            else
            {
                reports = false;
                
            }

        }

        private void cbTransaction_CheckedChanged(object sender, EventArgs e)
        {

            if (cbTransaction.Checked)
            {
                transactions = true;

                lblTransaction.Text = "Services Chargers Apply for Transcations";

            }
            else
            {
                transactions = false;
                lblSMS.Text = "No";
            }

        }
    }
}
