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
    public partial class ProjectDeveloperForm : Form
    {
        public ProjectDeveloperForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string input;
            if (rbtnCs.Checked == true)
            {
                input = rbtnCs.Text;
                MessageBox.Show("You have selected " + input, "Project Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rbtnJava.Checked == true)
            {
                input = rbtnJava.Text;
                MessageBox.Show("You have selected " + input, "Project Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (rbtnCpp.Checked == true)
            {
                input = rbtnCpp.Text;
                MessageBox.Show("You have selected " + input, "Project Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void ProjectDeveloperForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void ProjectDeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
