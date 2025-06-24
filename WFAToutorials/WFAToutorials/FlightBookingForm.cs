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
        public static string To, From, DocumentNo, IssueDate, ExpiryDate, SeatNo, FlightNo, Class, Price, FirstName, LastName, StartTripDate, EndTripDate, WeightBaggage;
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
            else
            {
                IDcard = false;
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpIssueDate.Value;
            dtpExpiryDate.MinDate = dt;
        }

        private void FlightBookingForm_Load(object sender, EventArgs e)
        {


            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

        }

        private void FlightBookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.Owner != null)
            {
                this.Owner.Show();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            To = txtTo.Text;
            From = txtFrom.Text;

            StartTripDate = monthCalendar1.SelectionStart.ToString("dd MM yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd MM yyyy");

            FirstName = txtFName.Text;
            LastName = txtLName.Text;
            DocumentNo = txtDocumentNo.Text;
            IssueDate = dtpIssueDate.Value.ToString("dd MM yyyy");
            ExpiryDate = dtpExpiryDate.Value.ToString("dd MM yyyy");

            WeightBaggage = numericUpDown1.Value.ToString();

            BookingSummaryForm bsF = new BookingSummaryForm();
            bsF.Show(this);
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
