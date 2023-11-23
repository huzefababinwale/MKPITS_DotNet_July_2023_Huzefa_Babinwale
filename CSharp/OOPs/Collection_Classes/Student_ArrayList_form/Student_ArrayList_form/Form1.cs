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

namespace Student_ArrayList_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList name=new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            name.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Sort();
            StringBuilder sb = new StringBuilder();
            foreach(object obj in name)
            {
                sb.Append(obj+"\n");
            }
            richTextBox1.Text= sb.ToString();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity: " + name.Capacity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Count: " + name.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ind = Convert.ToInt32(textBox2.Text);
            while(ind<=name.Count)
            {
                name.RemoveAt(ind-1);
            }
            
        }
    }
}
