using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace largest_num_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2= Convert.ToInt32(textBox2.Text);
            int num3= Convert.ToInt32(textBox3.Text);
            string res;
            if(num1>num2 && num2>num3)
            {
                res = num1 + " : num1 is greater than all" ;
            }
            if(num1<num2 && num2>num3)
            {
                res = num2 + " : num2 is greater than all";
            }
            else
            {
                res = num3 + " : num3 is greater than all";
            }
            textBox4.Text = res;

        }
    }
}
