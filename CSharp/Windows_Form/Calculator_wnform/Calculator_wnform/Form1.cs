using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_wnform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal pn = 0;//initialization of Previous number that will undergo operation
        char op; //to store Operators
        StringBuilder sb=new StringBuilder();//to display previously calculated results in a string 

        private void button1_Click(object sender, EventArgs e)
        {
            sb.Append(1);
            if(op!=null)
            {
                
                if(richTextBox1.Text=="+" || richTextBox1.Text=="-" || richTextBox1.Text=="*"|| richTextBox1.Text=="/")
                    {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "1";
                    }
                else
                {
                    richTextBox1.Text=richTextBox1.Text+"1";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sb.Append(2);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "2";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "2";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sb.Append(3);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "3";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "3";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sb.Append('+');
            pn =Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Text = "+";
            op = Convert.ToChar(richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sb.Append('-');
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Text = "-";
            op = Convert.ToChar(richTextBox1.Text);
        }
        decimal res;

        private void button6_Click(object sender, EventArgs e)
        {
            
            switch(op)
            {
                case '+':
                    res=pn + Convert.ToInt32(richTextBox1.Text);
                    break;
                case '-':
                    res= pn - Convert.ToInt32(richTextBox1.Text);
                    break;
                case '*':
                    res=pn* Convert.ToInt32(richTextBox1.Text);
                    break;
                case '/':
                    res=pn/Convert.ToInt32(richTextBox1.Text);
                    break;
                default:
                    MessageBox.Show("Please Select Valid Operator");
                    break;
            }
            richTextBox1.Text = res.ToString();
            sb.Append("= "+res+"\t");
            textBox1.Text= sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sb.Append(4);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "4";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "4";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sb.Append(5);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "5";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "5";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sb.Append(6);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "6";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "6";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sb.Append(7);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "7";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "7";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sb.Append(8);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "8";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "8";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sb.Append(9);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "9";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "9";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sb.Append(0);
            if (op != null)
            {
                if (richTextBox1.Text == "+" || richTextBox1.Text == "-" || richTextBox1.Text == "*" || richTextBox1.Text == "/")
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = richTextBox1.Text + "0";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "0";
                }
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sb.Append("/");
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Text = "/";
            op = Convert.ToChar(richTextBox1.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sb.Append("*");
            pn = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Text = "*";
            op = Convert.ToChar(richTextBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
