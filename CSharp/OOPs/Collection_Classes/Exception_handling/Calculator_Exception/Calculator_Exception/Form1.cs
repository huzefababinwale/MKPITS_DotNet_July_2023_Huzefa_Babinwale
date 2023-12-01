using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Exception
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator cl = new Calculator();
        float rel = 0;
        public void clear()
        {
            richTextBox1.Clear();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);
                rel=cl.Addition(n1, n2);
                richTextBox1.Text = rel.ToString();
            }
            catch(FormatException fe)
            {
                /*richTextBox1.Text = ("Warning!!\t Entered"+fe.ToString());*/
                richTextBox1.Text = ("Warning!!\t Entered Value is not in proper formate please check them Once");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);
                rel = cl.Substraction(n1, n2);
                richTextBox1.Text = rel.ToString();
            }
            catch (FormatException fe)
            {
                /*richTextBox1.Text = ("Warning!!\t Entered"+fe.ToString());*/
                richTextBox1.Text = ("Warning!!\t Entered Value is not in proper formate please check them Once");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);
                rel = cl.Multiplication(n1, n2);
                richTextBox1.Text = rel.ToString();
            }
            catch (FormatException fe)
            {
                /*richTextBox1.Text = ("Warning!!\t Entered"+fe.ToString());*/
                richTextBox1.Text = ("Warning!!\t Entered Value is not in proper formate please check them Once");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);
                
                rel = cl.Division(n1, n2);
                richTextBox1.Text = rel.ToString();
            }
            catch (FormatException fe)
            {
                /*richTextBox1.Text = ("Warning!!\t Entered"+fe.ToString());*/
                richTextBox1.Text = ("Warning!!\t Entered Value is not in proper formate please check them Once");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                char c1 = Convert.ToChar(textBox3.Text);
                float n1 = Convert.ToSingle(textBox1.Text);
                float n2 = Convert.ToSingle(textBox2.Text);
                
                switch (c1)
                {
                    case '+':
                        rel=cl.Addition(n1, n2);
                        break;
                    case '-':
                        rel=cl.Substraction(n1, n2);
                        break;
                    case '*':
                        rel=cl.Multiplication(n1, n2);
                        break;
                    case '/':
                        rel=cl.Division(n1, n2);
                        break;
                }
                /*rel = cl.Division(n1, n2);*/
                richTextBox1.Text = rel.ToString();
            }
            catch (FormatException fe)
            {
                /*richTextBox1.Text = ("Warning!!\t Entered"+fe.ToString());*/
                richTextBox1.Text = ("Warning!!\t Entered Value is not in proper formate please check them Once");
            }
        }
    }
}
