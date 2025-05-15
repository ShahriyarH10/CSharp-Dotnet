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
    public partial class RegistrationForm : Form
    {
        
        private string message;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPasswordRelated_Click(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.txtPassword.PasswordChar == '\0' ? '*' : '\0';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string gender = rbtnMale.Checked ? "Male" : rbtnFemale.Checked ? "Female" : "Not specified";

            
            List<string> skills = new List<string>();
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            if (cbCSharp.Checked) skills.Add("C#");
            if (cbJava.Checked) skills.Add("Java");
            if (cbCpp.Checked) skills.Add("C++");
            string skillsText = skills.Count > 0 ? string.Join(", ", skills) : "None";

            string dob = dateTimePicker1.Value.ToShortDateString();

            
            this.message = $"Name: {this.txtName.Text}\n" +
                           $"Email: {this.txtEmail.Text}\n" +
                           $"Password: {this.txtPassword.Text}\n" +
                           $"Gender: {gender}\n" +
                           $"Skills: {skillsText}\n" +
                           $"Date of Birth: {dob}";

            btnSubmit.Visible = false;
            btnShow.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(message, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes || result == DialogResult.No)
            {
                btnSubmit.Visible = true;
                btnShow.Visible = false;
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Hide();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();
        }
    }
}
