using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            XmlDocument Doc=new XmlDocument();
            Doc.LoadXml("<studentList>"+"</studentList>");
            using (XmlTextWriter writer=
                   new XmlTextWriter("C:\\students.xml",null))
            {
                writer.Formatting = Formatting.Indented;
                Doc.Save(writer);
                MessageBox.Show("The XML File is created");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var doc=XDocument.Load("C:\\students.xml");
            XElement newStudent = new XElement("student",
                                      new XElement("stID",textBox1.Text),
                                      new XElement("stName",textBox2.Text),
                                      new XElement("stSurname",textBox3.Text)
                                     );
            doc.Element("studentList").Add(newStudent);
            doc.Save("C:\\students.xml");
            MessageBox.Show("The new student was added");
            textBox1.Clear();textBox2.Clear();textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "List:";
            XElement list = XElement.Load("C:\\students.xml");
            //MessageBox.Show(list.ToString());
            foreach (var x in list.Elements("student"))
            {
                //MessageBox.Show(x.Value);
                label4.Text += "( " + x.Element("stID").Value +
                                " " + x.Element("stName").Value +
                                " " + x.Element("stSurname").Value +
                                " ), ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load("C:\\students.xml");
            doc.Descendants("student")
                .Where(x => (string)x.Element("stID") == textBox4.Text)
                .Remove();
            doc.Save("C:\\students.xml");
            MessageBox.Show("The student was deleted");
            textBox4.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var doc = XDocument.Load("C:\\students.xml");
            var items=from item in doc.Descendants("student")
                      where item.Element("stID").Value == textBox7.Text
                      select item;
            foreach (XElement x in items)
            {
                x.SetElementValue("stName", textBox6.Text);
                x.SetElementValue("stSurname", textBox5.Text);
            }
            doc.Save("C:\\students.xml");
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
        }
    }
}
