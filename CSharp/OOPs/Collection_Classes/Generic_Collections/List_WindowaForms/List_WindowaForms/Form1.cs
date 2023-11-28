using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_WindowaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string s in list)
            {
                sb.Append(s+"\n");
            }
            label2.Text = sb.ToString();
            clear();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        public void dis()
        {
            foreach (string s in list)
            {
                sb.Append(s + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Remove(textBox1.Text);
            clear();
            dis();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int li = list.Count;
            list.Insert(li, textBox1.Text);
            MessageBox.Show("Count returns: "+li);
            clear();
            dis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Sort();
            clear();
            dis();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (list.Contains(textBox1.Text))
            {
                MessageBox.Show("Object Found in List");
            }
            else
            {
                MessageBox.Show("Object not found in List");
            }
        }
    }
}
