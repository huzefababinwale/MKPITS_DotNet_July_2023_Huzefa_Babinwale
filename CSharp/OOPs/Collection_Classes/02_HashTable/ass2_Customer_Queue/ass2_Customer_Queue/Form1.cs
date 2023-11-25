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

namespace ass2_Customer_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue C = new Queue();
        StringBuilder sb = new StringBuilder();
        Customer cst = null;
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string mail= textBox3.Text;
            long num=Convert.ToInt64(textBox4.Text);
            cst=new Customer(id, name, mail, num);
            C.Enqueue(cst);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Customer st in C)
            {
                sb.Append("ID: " + st.Id + "\tName: "+st.CustomerName +"\tEmail: "+ st.CustomerEmail +"\tMobile num: "+ st.CustomerMobile+"\n");
            }
            richTextBox1.Text=sb.ToString();

        }
    }
}
