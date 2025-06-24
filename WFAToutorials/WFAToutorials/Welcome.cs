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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }

        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            ProjectDeveloperForm pdf = new ProjectDeveloperForm();
            pdf.Show(this);
            //this.Hide();

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTimeForm dtF = new DateTimeForm();
            dtF.Show(this);
            //this.Hide();
        }


        private void btnPurchase_Click_1(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("1: To Purchase, Press = Yes. \n 2: For trial Version, Press = No \n Cancel Order, Press = Cancel", "Purchase Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                lblPerchase.Text = "You have selected to purchase the software";
            }
            else if (dr == DialogResult.No)
            {
                lblPerchase.Text = "You have selected to try the software";
            }
            else if (dr == DialogResult.Cancel)
            {
                lblPerchase.Text = "You have cancelled the order";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightBookingForm fbF = new FlightBookingForm();
            fbF.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClinicAppForm caf = new ClinicAppForm();
            caf.Show(this);
        }
    }
}
