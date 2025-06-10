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
    public partial class FlightBookingForm : Form
    {

        public static Boolean Passport, IDcard;
        public FlightBookingForm()
        {
            InitializeComponent();
        }

        private void rbtnIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIDCard.Checked)
            {
                lblDocumentNo.Text = "ID Card No.";
                lblIssueDate.Text = "Issue Date";
                lblExpiryDate.Text = "Expiry Date";


                IDcard = true;
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpIssueDate.Value;
            dtpExpiryDate.MinDate = dt;
        }

        private void rbtnPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPassport.Checked)
            {
                lblDocumentNo.Text = "Passport No.";
                lblIssueDate.Text = "Issue Date";
                lblExpiryDate.Text = "Expiry Date";


                Passport = true;
            }
        }
    }
}
