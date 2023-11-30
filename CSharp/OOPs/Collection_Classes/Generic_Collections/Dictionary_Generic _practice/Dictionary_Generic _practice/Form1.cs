using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Generic__practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
        StringBuilder sb=new StringBuilder();
        Customer c=null;
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1= new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Customer c2 = new Customer(Convert.ToInt32(textBox3.Text), textBox4.Text);
            dict.Add(c1.customerID,c1);
            dict.Add(c2.customerID,c2);
            MessageBox.Show("Inserted Successfully");
            textBox1.Clear();
            textBox1.Focus();

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach(KeyValuePair<int, Customer> p in dict)
            {
                sb.Append("Key: "+p.Key+" \tValue: " + p.Value.name+"\n");
            }
            richTextBox1.Text = sb.ToString();
        }
        StringBuilder st=new StringBuilder();
        private void button3_Click(object sender, EventArgs e)
        {
            int five = Convert.ToInt32(textBox5.Text);
            int KeyFound=0;
            foreach (KeyValuePair<int, Customer> p in dict)
            {
                if (p.Key== five)
                {
                    st.Append("Key: " + p.Key + " \tValue: " + p.Value.name + "\n");
                    richTextBox1.Clear();
                    MessageBox.Show(st.ToString());
                    richTextBox1.Text = st.ToString();
                    KeyFound = 1;
                    break;
                }
            }
            if(KeyFound==0)
            {
                MessageBox.Show("Key not Found!");
            }
            textBox5.Clear();
        }
    }
}
