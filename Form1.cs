using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Log(result);
            textBox1.Text = result.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.PI;
            textBox1.Text = result.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Exp(result);
            textBox1.Text = result.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Tanh(result);
            textBox1.Text = result.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Cosh(result);
            textBox1.Text = result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Sinh(result);
            textBox1.Text = result.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Ceiling(result);
             textBox1.Text = result.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Floor(result);
            textBox1.Text = result.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 3);
            textBox1.Text = result.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = 1 / result;
            textBox1.Text = result.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MOD";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
{
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
{
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "MOD")
            {
                textBox1.Text = Convert.ToString(valor1 % valor2);
            }
            else
            {
                textBox1.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "1";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "5";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "6";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "8";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "DIV";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {

        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SOMA";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "SUB";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = "MULT";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double result;
            result = double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
