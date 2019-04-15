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
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0;
        double num2 = 0;
        string operand = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Number buttons

        private void button0_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10);
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                textBox1.Text = num2.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 1;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                textBox1.Text = num2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 2;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                textBox1.Text = num2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 3;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                textBox1.Text = num2.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 4;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                textBox1.Text = num2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 5;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                textBox1.Text = num2.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 6;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                textBox1.Text = num2.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 7;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                textBox1.Text = num2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 8;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                textBox1.Text = num2.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = (num1 * 10) + 9;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                textBox1.Text = num2.ToString();
            }
        }

        // Maths buttons

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand = "+";
            textBox1.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand = "-";
            textBox1.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand = "*";
            textBox1.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand = "/";
            textBox1.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        textBox1.Text = (num1 + num2).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Can't divide by zero";
                    }
                    break;
            }
        }

        // Special buttons

        private void buttonPercent_Click(object sender, EventArgs e)
        {

        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {

        }

        // Memory buttons

        private void buttonC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operand = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            string DecimalDot = ".";
            if (num1 != 0)
            {
                string num1String = Convert.ToString(num1);
                bool DecimalPresent = num1String.Contains(DecimalDot);

            }
        }
    }
}
