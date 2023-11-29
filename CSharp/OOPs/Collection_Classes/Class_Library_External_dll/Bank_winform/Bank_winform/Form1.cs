using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace Bank_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bank ac = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ac.accountnum = Convert.ToInt32(textBox1.Text);
            string res = ac.deposit(Convert.ToInt32(textBox2.Text));
            richTextBox1.Text = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ac.accountnum= Convert.ToInt32(textBox1.Text);
            string res=ac.withdrawl(Convert.ToInt32(textBox2.Text));
            richTextBox1.Text= res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "saving")
            {
                ac= new saving();
            }
            else if(comboBox1.Text=="current")
            {
                ac=new current();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ac.accountnum=Convert.ToInt32(textBox1.Text);
            string res = ac.showbalance();
            richTextBox1.Text=res;
        }
    }
}
