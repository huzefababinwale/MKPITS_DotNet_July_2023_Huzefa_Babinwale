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

namespace All_Array_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList myList=new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            int hr = Convert.ToInt32(textBox1.Text);
            myList.Add(hr);
            textBox1.Clear();
            textBox1.Focus();
        }
        StringBuilder sb = new StringBuilder();
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (object obj in myList)
            {
                sb.Append(obj.ToString()+"\n");
            }
            sb.AppendLine();
            richTextBox1.Text=sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            myList.Remove(num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            myList.RemoveAt(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach(Object obj in myList)
            {
                if(i==1)
                {
                    
                    richTextBox1.Text = obj.ToString();
                    i++;
                }       
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string hr = textBox1.Text;
            myList.Add(hr);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity: "+sb.Capacity.ToString());
            
            MessageBox.Show("Count: " +myList.Count);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myList.Sort();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //we can spot index of string only but not able to access int
            string hr = textBox1.Text;
            int myIndex= myList.IndexOf(hr);
            MessageBox.Show("Spotted on Index of: " + myIndex);
            
        }
    }
}
