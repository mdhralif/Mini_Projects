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
        String sign="";
        double num1, num2, result;
        string digit1, digit2;


        public Form1()
        {
            InitializeComponent();
        }

        private void acbutton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = "0";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "1";
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "2";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (resulttextBox.Text == "0") resulttextBox.Clear();
            resulttextBox.Text = resulttextBox.Text + ".";
        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            sign = "/";
            digit1 = resulttextBox.Text;
            resulttextBox.Text= "";

            
            
        }

        private void multibutton_Click(object sender, EventArgs e)
        {
            sign = "*";
            digit1 = resulttextBox.Text;
            resulttextBox.Text = "";


        }

        private void pmbutton_Click(object sender, EventArgs e)
        {
            digit1 = resulttextBox.Text;
            num1 = Convert.ToDouble(digit1);
            num1 = num1 * -1;
            digit1 = Convert.ToString(num1);
            resulttextBox.Text = digit1;

        }

        private void modbutton_Click(object sender, EventArgs e)
        {
            sign = "%";
            digit1 = resulttextBox.Text;
        }

        private void resulttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void minbutton_Click(object sender, EventArgs e)
        {
            sign = "-";
            digit1 = resulttextBox.Text;
            resulttextBox.Text = "";

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            sign = "+";
            digit1 = resulttextBox.Text;
            resulttextBox.Text = "";

        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            digit2 = resulttextBox.Text;
            num1 = Convert.ToDouble(digit1);
            num2 = Convert.ToDouble(digit2);
            switch (sign)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                   
                        result = (num1 / 100);
                    
                    
                    break;
                   
                default: break;                  
            }
            if (result >= 100000000) resulttextBox.Text = "Error";
            else resulttextBox.Text = result.ToString();
            
            




        }
    }
}
