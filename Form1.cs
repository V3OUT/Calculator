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
        string CalTotal;
        string option;
        double num1;
        double num2;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + b1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (option.Equals("+"))
                result=num1+num2;
            if (option.Equals("-"))
                result=num1-num2;
            if (option.Equals("*"))
                result=num1*num2;
            if (option.Equals("/"))
                result=num1/num2;
            if (option.Equals("%"))
                result = num1 / num2;
            textBox1.Text = Convert.ToString(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b9.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + b6.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            option = "%";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + b0.Text;
        }

        private void bCLR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
            num1 = (0);
            num2 = (0);
            result = (0);

        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+b4.Text;    
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + b7.Text;
        }

        private void bp_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + bp.Text;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bdiv_Click(object sender, EventArgs e)
        {

            option = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void bsub_Click(object sender, EventArgs e)
        {

            option = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void badd_Click(object sender, EventArgs e)
        {

            option = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
