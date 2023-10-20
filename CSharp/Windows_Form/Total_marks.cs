using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Marks_per
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mar1 = Convert.ToInt32(textBox1.Text);
            int mar2= Convert.ToInt32(textBox2.Text);
            int mar3= Convert.ToInt32(textBox3.Text);

            int total=mar1 + mar2+mar3;
            textBox4.Text = " " + total;
            int per = total / 3;
            textBox5.Text = " " + per;
            if (per>=85)
            {
                textBox6.Text = "Grade A";
            }
            else if (per>=70)
            {
                textBox6.Text = "Grade B";
            }
            else if(per>=55)
            {
                textBox6.Text = "Grade C";
            }
            else
            {
                textBox6.Text = "Tumse na Ho Paega..";
            }
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
