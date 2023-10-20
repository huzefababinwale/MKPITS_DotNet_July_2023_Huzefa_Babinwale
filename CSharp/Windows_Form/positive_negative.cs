using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace positive_or_neg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            string res;
            if (num>0)
            {
                res = "It is Positive Number";
            }
            else
            {
                res = "It is Negative Number";
            }
            textBox2.Text = res;
        }
    }
}
