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
            richTextBox1.Clear();
            ICollection key = ht.Keys;
            foreach(int k in key)
            {
                sb.Append("Key: "+k+"\tValue: " + ht[k] +"\n");
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder ss = new StringBuilder();
            int find = Convert.ToInt32(textBox1.Text);
            string nm=textBox2.Text;
            ICollection key = ht.Keys;
            if (ht.ContainsKey(find))
                {
                    ss.Append("Key: " + find + "\tValue: " + ht[find] + "\n");
                    richTextBox1.Text = ss.ToString();
                }
            else if(ht.ContainsValue(nm)) 
            {
                ss.Append("Key: " + nm + "\tValue: " + ht[nm] + "\n");
                richTextBox1.Text = ss.ToString();
            }
            else 
            {
                    MessageBox.Show("Not found Anything ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int find =Convert.ToInt32(textBox1.Text);
            ICollection key = ht.Keys;
            if (ht.ContainsKey(find))
            {
                ht.Remove(find);
                MessageBox.Show("Object Removed Successfully");
            }
        }
    }
}
