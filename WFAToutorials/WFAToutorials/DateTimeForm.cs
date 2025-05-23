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
    public partial class DateTimeForm : Form
    {
        public DateTimeForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lbl1DateTime.Text = dtPicker.Value.ToString();

            lbl2Date.Text = dtPicker.Value.ToShortDateString();

            lbl3DateDay.Text = dtPicker.Value.ToLongTimeString();

            lbl4Time.Text = dtPicker.Value.ToShortTimeString();

            lbl5TimeSecond.Text = dtPicker.Value.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");

        }

        private void DateTimeForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void DateTimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
