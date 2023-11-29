using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace Calculator_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculator c = new calculator();
        private void button1_Click(object sender, EventArgs e)
        {
            int res=c.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            richTextBox1.Text = "Substraction of given numbers is : "+res;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = c.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            richTextBox1.Text = "Addition of given numbers is : " + res;
        }
    }
}
