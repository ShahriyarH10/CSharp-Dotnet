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
    public partial class CalculatorForm: Form
    {
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewEntry = false;
        public CalculatorForm()
        {
            InitializeComponent();
            HookUpButtons();
        }
        private void HookUpButtons()
        {
            
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;
            btnDot.Click += NumberButton_Click;

            btnSum.Click += OperationButton_Click;
            btnSub.Click += OperationButton_Click;
            btnMulti.Click += OperationButton_Click;
            btnDiv.Click += OperationButton_Click;

           
            btnResult.Click += EqualsButton_Click;
            btnAC.Click += ClearButton_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text += ".";
                    isNewEntry = false;
                }
               
                else if (isNewEntry)
                {
                    txtResult.Text = "0.";
                    isNewEntry = false;
                }
                
                return;
            }

            if (isNewEntry || txtResult.Text == "0")
            {
                txtResult.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
        }


        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(txtResult.Text);
            operation = btn.Text;
            isNewEntry = true;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtResult.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            txtResult.Text = result.ToString();
            isNewEntry = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewEntry = false;
        }

       
    }
}
