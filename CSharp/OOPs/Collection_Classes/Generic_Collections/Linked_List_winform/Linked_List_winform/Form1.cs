using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_List_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<int> li= new LinkedList<int>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            li.AddLast(Convert.ToInt32(textBox1.Text));
            int num = Convert.ToInt32(textBox1.Text);
            clear();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            li.AddFirst(Convert.ToInt32(textBox1.Text));
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in li)
            {
                sb.Append(i+"\n");
            }
            richTextBox1.Text=sb.ToString();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int n=Convert.ToInt32(textBox2.Text);
            int num = Convert.ToInt32(textBox1.Text);
            LinkedListNode<int> node=li.Find(num);
            li.AddBefore(node,n);

            bool t = li.Contains(num);
            MessageBox.Show("Inserted succesfully...");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            li.Remove(n);
        }
    }
}
