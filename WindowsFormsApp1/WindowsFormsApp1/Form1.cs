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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(this.textBox3.Text);
            double n2 = Convert.ToDouble(this.textBox4.Text);

            double sum = n1 + n2;
            this.label6.Text = sum.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(this.textBox3.Text);
            double n2 = Convert.ToDouble(this.textBox4.Text);

            double sum = n1 * n2;
            this.label6.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double n1 ;
            double n2 ;
            if(!double.TryParse(this.textBox3.Text, out n1)|| !double.TryParse(this.textBox4.Text, out n2))
            {
               
            }

            //double sum = n1 - n2;
            //this.label6.Text = sum.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(this.textBox3.Text);
            double n2 = Convert.ToDouble(this.textBox4.Text);

            double sum = n1 / n2;
            this.label6.Text = sum.ToString();
        }

        
    }
}
