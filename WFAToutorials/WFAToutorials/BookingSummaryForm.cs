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
    public partial class BookingSummaryForm : Form
    {
        public BookingSummaryForm()
        {
            InitializeComponent();
        }

        private void BookingSummaryForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

            if(FlightBookingForm.IDcard)
            {
               lblChangeDocument.Text = "ID Card No.";
               lblChangeDocExpiry.Text = "ID Card Expiry Date:";

            }
            else
            {
                lblChangeDocument.Text = "Passport No.";
                lblChangeDocExpiry.Text = "Passport Expiry Date:";

            }

            lblFullName.Text = $"{FlightBookingForm.FirstName} {FlightBookingForm.LastName}";
            lblDepartureCity.Text = FlightBookingForm.From;
            lblDestinationCity.Text = FlightBookingForm.To;
            lblTripDate.Text = $"{FlightBookingForm.StartTripDate} to {FlightBookingForm.EndTripDate}";
            lblDocumentNo.Text = FlightBookingForm.DocumentNo;
            lblDocumentExpiryDate.Text = FlightBookingForm.ExpiryDate;
            lblBaggageWeight.Text = $"{FlightBookingForm.WeightBaggage} kg";

        }

        private void BookingSummaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
