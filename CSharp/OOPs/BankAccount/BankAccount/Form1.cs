using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount b1 = new BankAccount();

            b1.BankHolderName = "Noman";
            b1.BankAccountNumber = 1234;
            b1.Balance = 1000;

            BankAccount b2 = new BankAccount();
            b2.BankHolderName = textBox1.Text;
            b2.BankAccountNumber = Convert.ToInt32(textBox2.Text);
            b2.Balance = Convert.ToInt32(textBox3.Text);


            StringBuilder sb = new StringBuilder();

            sb.Append(b2.BankHolderName+"/n");
            sb.Append(b2.BankAccountNumber + "/n");
            sb.Append(b2.Balance + "/n");
            richTextBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }
    }
}
