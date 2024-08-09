using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double result;
        string mathOperator = "";
        bool isMathPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            
            if (isMathPerformed)
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            isMathPerformed = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void Delbtn(object sender, EventArgs e)
        {
            string currentDisplay = textBox1.Text;

            if (currentDisplay.Length > 0)
            {
                string delDisplay = currentDisplay.Remove(currentDisplay.Length - 1);
                textBox1.Text = delDisplay;

            }
        }

        private void operatorBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathOperator = button.Text;
            result = Double.Parse(textBox1.Text);
            isMathPerformed = true;
        }

        private void equal(object sender, EventArgs e)
        {
            switch(mathOperator)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
