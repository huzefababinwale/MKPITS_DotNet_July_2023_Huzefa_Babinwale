using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            if (radioButton2.Checked)
            {
                count++;
            }
            if(radioButton9.Checked) { count++; }
            if(radioButton5.Checked) { count++; }

            while(count>2)
            {
                MessageBox.Show("great Attempt You Won!");
            }
            label5.Text=count.ToString();
        }
    }
}
