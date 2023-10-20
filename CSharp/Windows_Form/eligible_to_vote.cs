using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eligible_for_vote
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
            if (num >= 60) 
            {
                res = "You are eligible to vote Elder one: ";
            }
            else if (num>=18)
            {
                res = "You are Adult now & Eligible to vote";

            }
            else 
            {
                res = "You need to grow up for now till the age of 18";
            }

            textBox2.Text = res;
        }
    }
}
