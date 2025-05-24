using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2LabTask
{
    public partial class RegristrationForm : Form
    {
        public RegristrationForm()
        {
            InitializeComponent();
        }

        private void RegristrationForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }


        private void RegristrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            string gender = rbtnMale.Checked ? "Male" : rbtnFemale.Checked ? "Female" : "Not specified";
            List<string> skills = new List<string>();
            if (cbCs.Checked) skills.Add("C#");
            if (cbJava.Checked) skills.Add("Java");
            if (cbHTML.Checked) skills.Add("HTML");
            if (cbSQL.Checked) skills.Add("SQL");
            string password = txtPassword.Text.ToString();
            string confirmPassword = txtCPassword.Text.ToString();

            if (password != confirmPassword)
            {

                txtCPassword.BackColor = Color.Red;
                lblWarn.Visible = true;

            }
            else if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                      string.IsNullOrWhiteSpace(txtFullName.Text) ||
                      string.IsNullOrWhiteSpace(txtEmail.Text) ||
                      string.IsNullOrWhiteSpace(password))
            {

                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                var result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    string info = $"Student ID: {txtStudentID.Text}\n" +
                                  $"Full Name: {txtFullName.Text}\n" +
                                  $"Email: {txtEmail.Text}\n" +
                                  $"Date of Birth: {dtPicker.Value.ToShortDateString()}\n" +
                                  $"Gender: {gender}\n" +
                                  $"Department: {comboBox1.Text}\n" +
                                  $"Skills: {string.Join(", ", skills)}\n" +
                                  $"Password: {password}";

                    this.Close();
                    if (this.Owner != null)
                    {
                        this.Owner.Show();
                    }
                }

            }

        }
    }
}
