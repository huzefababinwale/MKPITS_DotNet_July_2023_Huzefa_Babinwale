using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparison_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2=Convert.ToInt32(textBox2.Text);
            string res;
            if (num1 == num2)
            {
                res = "Both are Equal";
            }
            else if (num1 > num2)
            {
                res = "Number i "+ num1+ " is Greater Than "+ num2;
            }
            else if(num1 < num2)
            {
                res = "Number ii " + num2 + " is Greater Than " + num1;
            }
            else
            {
                res = "Please Enter Valid Number ";
            }
            textBox3.Text = res;
        }
    }
}
