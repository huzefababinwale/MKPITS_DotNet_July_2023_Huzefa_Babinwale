using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_machineTest
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Now;
        
        public Form1()
        {
            InitializeComponent();
            dt.ToShortDateString();
            label3.Text = dt.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=null;
            int age;
            StringBuilder sb=new StringBuilder();
            age=Convert.ToInt32(numericUpDown1.Text);
            name = textBox1.Text;
            if (name!=null && age!=null)
            {
                if(age>17 &&age<99)
                {
                    sb.Append("Name of Student: "+name+"\nAge of Student: "+age);
                    richTextBox1.Text = (sb.ToString());
                }
                else
                {
                    MessageBox.Show("Student Age is not valid please Reconfirm Addmission.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid Name to execute the command.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value=18;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
