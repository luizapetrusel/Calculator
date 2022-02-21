using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double first, second;

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textDisplay.Text == "0")
                textDisplay.Text = "";
            if (b.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text = textDisplay.Text + b.Text;
            }
            else
                textDisplay.Text = textDisplay.Text + b.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";

            string f, s;

            f = Convert.ToString(first);
            s = Convert.ToString(second);

            s = "";
            f = "";
        }

        private void Operational_Function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            first = Double.Parse(textDisplay.Text);
            operation = b.Text;
            textDisplay.Text = "";
        }

        private void btBS_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }

            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Contains("-"))
                textDisplay.Text = textDisplay.Text.Remove(0, 1);
            else
                textDisplay.Text = "-" + textDisplay.Text;
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            second = double.Parse(textDisplay.Text);
            switch(operation)
            {
                case "+":
                    textDisplay.Text = Convert.ToString(first + second);
                    break;
                case "-":
                    textDisplay.Text = Convert.ToString(first - second);
                    break;
                case "*":
                    textDisplay.Text = Convert.ToString(first * second);
                    break;
                case "/":
                    textDisplay.Text = Convert.ToString(first / second);
                    break;
                default:
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
