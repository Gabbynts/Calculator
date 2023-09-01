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
        decimal bil1;
        decimal bil2;
        string opr;
        Boolean finish_opr = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bil1 = 0;
            bil2 = 0;
            textBox1.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else textBox1.Text += "4";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (finish_opr == true)
                bil2 = Convert.ToDecimal(textBox1.Text);
            {
                switch (opr)
                {
                    case "x": textBox1.Text = Convert.ToString(bil1*bil2); 
                        break;
                    case "-":textBox1.Text = Convert.ToString(bil1-bil2);
                        break;
                    case "+": textBox1.Text = Convert.ToString(bil1+bil2);
                        break;
                    case "/": textBox1.Text = Convert.ToString(bil1/bil2);
                        break;
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Text = "2";
            else textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else textBox1.Text += "3";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else textBox1.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else textBox1.Text += "6";
        }

        private void buttonMutiple_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = "x";
            textBox1.Clear();
            finish_opr = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else textBox1.Text += "9";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = "+";
            textBox1.Clear();
            finish_opr = true;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = "-";
            textBox1.Clear();
            finish_opr = true;
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            opr = "/";
            textBox1.Clear();
            finish_opr = true;
        }
    }
}
