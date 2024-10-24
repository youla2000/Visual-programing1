using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            label7.Text ="Student Number:";
            label8.Text = "Name and Surname:";
            label9.Text = "Gender:";
            label10.Text = "Age:";
            label11.Text = "Department:";
            label12.Text = "Programming Languages you Know:";

            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1,"Enter ST Number!");
            else
                label7.Text += " " + textBox1.Text;
            if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Enter your Name!");
            else
                label8.Text += " " + textBox2.Text;

            if (radioButton1.Checked == false && radioButton2.Checked == false)
                errorProvider1.SetError(label3, "Choose your Gender!");
            else if (radioButton1.Checked==true)
                label9.Text += radioButton1.Text;
            else label9.Text += radioButton2.Text;

            if (comboBox1.Text == "-Select-")
                errorProvider1.SetError(comboBox1,"Select your Age!");
            else
                label10.Text+=comboBox1.Text;

            if (comboBox2.Text == "-Select-")
                errorProvider1.SetError(comboBox2, "Select your Department!");
            else
                label11.Text += comboBox2.Text;

            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
                label12.Text += "\nNo Languages was selected";
            if (checkBox1.Checked == true)
                label12.Text += "\n" + checkBox1.Text;
            if (checkBox2.Checked == true)
                label12.Text += "\n" + checkBox2.Text;
            if (checkBox3.Checked == true)
                label12.Text += "\n" + checkBox3.Text;
            if (checkBox4.Checked == true)
                label12.Text += "\n" + checkBox4.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = 0;
            e.Handled = !int.TryParse(e.KeyChar.ToString(),out x);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar)&&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }
    }
}
