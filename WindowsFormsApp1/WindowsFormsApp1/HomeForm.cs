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
    public partial class HomeForm: Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            if(this.Owner != null)
                this.Owner.Hide();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show(this);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm lI = new LogInForm();
            lI.Show();
            this.Close();
        }
    }
}
