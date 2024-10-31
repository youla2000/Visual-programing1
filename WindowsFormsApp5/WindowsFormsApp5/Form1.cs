using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            pictureBox1.Image = WindowsFormsApp5.Properties.Resources.male;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Image = WindowsFormsApp5.Properties.Resources.male;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Image = WindowsFormsApp5.Properties.Resources.female;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(radioButton1.Checked == true)
            {
                MessageBox.Show("You are a " + textBox1.Text + " years old " + radioButton1.Text);
            }
            else
            {
                MessageBox.Show("You are a " + textBox1.Text + " years old " + radioButton2.Text);
            }*/
            Form2 F = new Form2();
            F.Text = "Result";
            if(radioButton1.Checked == true)
                 F.label1.Text = "You are a " + textBox1.Text + " Years old " + radioButton1.Text;
            else
                F.label1.Text = "You are a " + textBox1.Text + " Years old " + radioButton1.Text;
            F.Show();
        }
    }
}
