using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        double weight;
        double height;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weight = double.Parse(textBox1.Text);
            height = (double.Parse(textBox2.Text)/100);

            result = weight / Math.Pow(height, 2);

            label4.Text = "BMI = " + result + "\nYour category is: ";

            if (result < 16.0)
            {
                label4.Text += "Underweight(Severe Thinness)"; 
            }
            else if (result < 16.9)
            {
                label4.Text += "Underweight(Moderate thiness)";
            }
            else if (result < 18.4)
            {
                label4.Text += "Underweight(Mild Thinness)";
            }
            else if (result < 24.9)
            {
                label4.Text += "Normal";
            }
            else if (result < 29.9)
            {
                label4.Text += "Obese(class1)";
            }
            else if (result < 39.9)
            {
                label4.Text += "Obese(class2)";
            }
            else if (result > 40.0)
            {
                label4.Text += "Obese(class3)";
            }
        }
    }
}
