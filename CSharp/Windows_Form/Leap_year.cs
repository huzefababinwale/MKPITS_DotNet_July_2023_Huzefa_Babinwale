using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q4Leap_year
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year=Convert.ToInt32(textBox1.Text);
            string res;
            if (year %4 == 0)
            {
                res = " is Leap Year";
            }
            else
            {
                res = " is not Leap Year";
            }
            textBox2.Text = year +res;
        }
    }
}
