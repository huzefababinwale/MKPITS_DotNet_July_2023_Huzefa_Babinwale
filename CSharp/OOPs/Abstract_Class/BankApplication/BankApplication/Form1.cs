using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(textBox1.Text);
            int amt= Convert.ToInt32(textBox2.Text);
            string at = textBox3.Text;
            Account act = null;
            if(at=="saving")
            {
                act = new Saving();
            }
            else if (at=="current")
            {
                act = new Current();
            }

            if (radioButton1.Checked)
            {
                act.deposit(amt);
            }
            else if(radioButton2.Checked)
            {
                act.withdrawl(amt);
            }


            richTextBox1.Text=act.ShowDetails(actno);
            
        }
    }
}
