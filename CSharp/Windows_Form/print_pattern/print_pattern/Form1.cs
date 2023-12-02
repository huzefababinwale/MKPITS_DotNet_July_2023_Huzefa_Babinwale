using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace print_pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int n=Convert.ToInt32(textBox1.Text);
            sb.Append("n=");
            int Square = n * n;
            sb.AppendLine(Square+"\t");
            int m;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    m = n * n;
                    break;
                case 1:
                    m = n;
                    break;
                default:
                    m = 0; break;
            }
            label2.Text = m.ToString();
            label2.Text= sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n= Convert.ToInt32(textBox1.Text);
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            


        }
    }
}
