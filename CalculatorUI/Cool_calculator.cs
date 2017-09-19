using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpCalculator.BO;

namespace CalculatorUI
{
    public partial class Cool_calculator : Form
    {
        public Cool_calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           // tbResult.Text = "0";
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "0");
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "*");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "/");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbResult.Text = CalculatorService.ParseInput(tbResult.Text, "=");
        }
    }
}
