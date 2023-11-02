using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_fees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] st=new Student[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            st[0]=new Student();
            st[1]=new Student();
            st[2]=new Student();
            st[3]=new Student();
            st[4]=new Student();
            st[5]=new Student();
            st[6]=new Student();
            st[7]=new Student();
            st[8]=new Student();
            st[9]=new Student();



        }
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cnt<10)
            {
                st[cnt].RollNum = Convert.ToInt32(textBox1.Text);
                st[cnt].Name=textBox2.Text;
                st[cnt].Fees= Convert.ToInt32(textBox3.Text);
                /*st[cnt].dateTime = dateTimePicker1*/
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.Refresh();
                textBox1.Focus();
                if (cnt==10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int high = st[0].Fees;
            int foundat= 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                
                sb.Append("----------------------------------------\n");
                sb.Append("Name: "+st[i].Name+"\n");
                sb.Append("Roll Number: "+st[i].RollNum + "\n");
                sb.Append("Fees: "+st[i].Fees + "\n");
                sb.Append("----------------------------------------\n" + "\n");
            }
            richTextBox1.Text=sb.ToString();
            
            for(int i = 0;i < 10;i++)
            {
                if (high<st[i].Fees)
                {
                    high = st[i].Fees;
                    foundat = i;
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Roll Number: " + st[foundat].RollNum);
            sb1.Append("Name: " + st[foundat].Name);
            sb1.Append("Fees: " + st[foundat].Fees);

            richTextBox2.Text= sb1.ToString();
        }
    }
}
