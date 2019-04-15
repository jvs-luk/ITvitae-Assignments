﻿using System;
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

        string num1 = 0;
        string num2 = 0;
        string operand = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Number buttons

        private void button0_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
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
                    textBox1.Text = num1 + num2;
                    break;
                case "-":
                    textBox1.Text = num1 - num2;
                    break;
                case "*":
                    textBox1.Text = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        textBox1.Text = num1 + num2;
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
            textBox1.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (operand == "")
            {
                num1 = 0;
                textBox1.Text = "0";
            }
            else
            {
                num2 = 0;
                textBox1.Text = "0";
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
            if (operand == "")
            {
                if (!num1.Contains("."))
                {
                    num1 += ".";
                    textBox1.Text = num1;
                }
                num1 = Convert.ToDecimal(num1);
            }

            else
            {
                if (!num2.Contains("."))
                {
                    num2 += ".";
                    textBox1.Text = num2;
                }
                num2 = Convert.ToDecimal(num2);

            }
        }
    }
}
