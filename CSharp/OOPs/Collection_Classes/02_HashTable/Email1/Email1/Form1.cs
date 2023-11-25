using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Email1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        StringBuilder sb= new StringBuilder();
        Student st = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int id=Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            ht.Add(id, name);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key = ht.Keys;
            foreach(int k in key)
            {
                sb.Append("Key: "+k+"\tValue: " + ht[k] +"\n");
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int find = Convert.ToInt32(textBox1.Text);
            foreach(int find in ht)
            {
                if (find==ht.Keys)
                {
                    sb.Append("Key: " + k + "\tValue: " + ht[k] + "\n");
                }
            }
            richTextBox1.Text=sb.ToString();
        }
    }
}
