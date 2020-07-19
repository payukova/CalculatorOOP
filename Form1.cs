using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace calculator_practica
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(this.textBox1.Text);
                double secondValue = Convert.ToDouble(this.textBox2.Text);
                double result;
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.calculate(firstValue, secondValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CalculateOne(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(this.textBox1.Text);
                double result;
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.calculate(firstValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
