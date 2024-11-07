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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="-Select-")
            {
                errorProvider1.SetError(comboBox1,"Choose a Country!");
                return;
            }
            errorProvider1.Clear();

            /*for(int i=0;i<listBox1.Items.Count;i++)
                if(comboBox1.Text==listBox1.Items[i].ToString())
                {
                    MessageBox.Show("Already Exists","Warning");
                    return;
                }*/

            foreach (string country in listBox1.Items)
                if (country == comboBox1.Text)
                {
                    MessageBox.Show("Already Exists", "Warning");
                    return;
                }
            listBox1.Items.Add(comboBox1.Text);
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Choose a country first");
            else
            {
                if(MessageBox.Show("Are you sure?","Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)==DialogResult.Yes)
                listBox1.Items.Remove(listBox1.SelectedItem);
                update();
                //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void update()
        {
            label3.Text = "Visited Countries: ";
            foreach (string x in listBox1.Items)
                label3.Text += x+", ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "-Select-";
            listBox1.Items.Clear();
            label3.Text = "Visited Countries: ";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i,false);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue==CheckState.Checked)
            {
                foreach(string s in listBox1.Items)
                    if(s == checkedListBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show("Already Exists!");
                        return;
                    }
                listBox1.Items.Add(checkedListBox1.SelectedItem);
                update();
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listBox1.Items.Remove(checkedListBox1.SelectedItem);
                    update();
                }
            }
        }
    }
}
