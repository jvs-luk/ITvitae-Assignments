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
        string UserInput = string.Empty;
        string History = string.Empty;
        double Result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            UserInput += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInput += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInput += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserInput += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserInput += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserInput += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserInput += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserInput += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserInput += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserInput += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UserInput = string.Empty;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            UserInput += ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
           //UserInput +=
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            UserInput = string.Format("{0:P}", UserInput);
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            UserInput = string.Format("{0:C}", UserInput);
        }

        // Adding to UserInput to show symbols in textbox

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserInput += " + ";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            UserInput += " - ";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            UserInput += " / ";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            UserInput += " x ";
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {

        }

        // Need to add to history as the Equals button hits

        private void History_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
