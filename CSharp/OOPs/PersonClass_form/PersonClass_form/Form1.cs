using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonClass_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.Name = textBox1.Text;
            p.Address= textBox2.Text;
            p.Age = Convert.ToInt32(textBox3.Text);

            
            StringBuilder sb = new StringBuilder();
            sb.Append("\n Name: "+p.Name);
            sb.Append("\n Address "+p.Address);
            sb.Append("\n Age: "+p.Age);
            richTextBox1.Text = sb.ToString();

        }
    }
}
