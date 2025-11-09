using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double firstNumber = 0;
        string operation = string.Empty;
        bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("An operator is already selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            operation = "+";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                firstNumber = 0;
                textBox1.Text = "0+";
            }
            else
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + operation;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("An operator is already selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            operation = "-";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                firstNumber = 0;
                textBox1.Text = "0-";
            }
            else
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + operation;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("An operator is already selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            operation = "*";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                firstNumber = 0;
                textBox1.Text = "0*";
            }
            else
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + operation;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("An operator is already selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            operation = "/";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                firstNumber = 0;
                textBox1.Text = "0/";
            }
            else
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + operation;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("No operation selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                char lastChar = textBox1.Text[textBox1.Text.Length - 1];
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    MessageBox.Show("Insert second number to complete operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int operatorIndex = textBox1.Text.IndexOf(operation);
            string secondPart = textBox1.Text.Substring(operatorIndex + 1);
            double secondNumber = Convert.ToDouble(secondPart);
            double result;

            //Add
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }

            //Substract
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }

            //Multiply
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }

            //Divide
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Error";
                    MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.ResetText();
                }
                else
                {
                    result = firstNumber / secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                } 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }
    }
}
