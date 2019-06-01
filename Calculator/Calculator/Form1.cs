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

        string num1 = "";
        string num2 = "";
        string operand = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public string AddNumbers(string oldNum,
                                 string addedNum)
        {
            string newNum = "";

            if (oldNum == "0")
            {
                newNum = addedNum;
            }
            else
            {
                newNum = oldNum + addedNum;
            }

            return newNum;  

        }
        
        // Number buttons

        private void button0_Click(object sender, EventArgs e)
        {
            
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "0");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "0");
                textBox1.Text = num2;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "1");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "1");
                textBox1.Text = num2;
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "2");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "2");
                textBox1.Text = num2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "3");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "3");
                textBox1.Text = num2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "4");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "4");
                textBox1.Text = num2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "5");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "5");
                textBox1.Text = num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "6");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "6");
                textBox1.Text = num2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "7");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "7");
                textBox1.Text = num2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "8");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "8");
                textBox1.Text = num2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = AddNumbers(textBox1.Text, "9");
                textBox1.Text = num1;
            }
            else
            {
                num2 = AddNumbers(textBox1.Text, "9");
                textBox1.Text = num2;
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

            decimal num1Decimal = Convert.ToDecimal(num1);
            decimal num2Decimal = Convert.ToDecimal(num2);

            switch (operand)
            {
                case "+":
                    textBox1.Text = num1 + "+" + num2 + " \r\n" + 
                                    Convert.ToString(num1Decimal + num2Decimal);
                    break;

                case "-":
                    textBox1.Text = num1 + "-" + num2 + " \r\n" + 
                                    Convert.ToString(num1Decimal - num2Decimal);
                    break;

                case "*":
                    textBox1.Text = num1 + "*" + num2 + " \r\n" + 
                                    Convert.ToString(num1Decimal * num2Decimal);
                    break;

                case "/":
                    if (num2 != "0")
                    {
                        textBox1.Text = num1 + "/" + num2 + " \r\n" + 
                                        Convert.ToString(num1Decimal / num2Decimal);
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
            /*
            bool eurCheck = true;
            decimal eurNum1 = Convert.ToDecimal(num1);
            decimal eurNum2 = Convert.ToDecimal(num2);
            string formattedEurNum1 = String.Format("{0:C}", eurNum1);
            string formattedEurNum2 = String.Format("{0:C}", eurNum2);

            if (operand == "")
            {
                textBox1.Text = "€" + formattedEurNum1;
            }
            else
            {
                textBox1.Text = "€" + formattedEurNum2;
            }
            */

        }

        // Memory buttons

        private void buttonC_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            operand = "";
            textBox1.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = "";
                textBox1.Text = "0";
            }
            else
            {
                num2 = "";
                textBox1.Text = "0";
            }
        }

        private void buttonMemory_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = num1.Remove(num1.Length - 1);
                textBox1.Text = num1;
            }
            else
            {
                num2 = num2.Remove(num2.Length - 1);
                textBox1.Text = num2;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                if (!num1.Contains(","))
                {
                    num1 += ",";
                    textBox1.Text = num1;
                }
                
            }

            else
            {
                if (!num2.Contains(","))
                {
                    num2 += ",";
                    textBox1.Text = num2;
                }

            }
        }
    }
}
