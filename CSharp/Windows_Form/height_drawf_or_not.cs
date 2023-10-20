using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace height_draft_large
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
            if (num>=190)
            {
                res = "You'r height is Impressive";
            }
            else if (num<190)
            {
                res = "You are Average in Height";
            }
            else if(num<120)
            {
                res = "You are Dwarf";
            }
            else
            {
                res = "Enter Valid Height";
            }
            textBox2.Text= " "+res;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
