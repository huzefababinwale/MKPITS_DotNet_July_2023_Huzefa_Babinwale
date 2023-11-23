using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Studentsinfo_arrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList stud = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            int hr = stud.Count;
            for (int i=1; i<=1; i++)
            {
                Student si = new Student(Convert.ToInt32(textBox2.Text), textBox1.Text);
                /*Student s2 = new Student(Convert.ToInt32(textBox4.Text), textBox3.Text);*/

                stud.Add(si);
                /*stud.Add(s2);*/
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student obj in stud)
            {
                sb.Append("Roll Number: "+obj.rollno+ "\tName: "+ obj.name+"\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
