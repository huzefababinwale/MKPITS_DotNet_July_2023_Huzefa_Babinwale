using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactive_radio_checkbox_images
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }
        StringBuilder sb= new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            string ename=textBox1.Text;
            int basic=Convert.ToInt32(textBox2.Text);
            float bonus;
            float totalSal;
            bonus = basic * 0.40f;
            string designation=comboBox1.Text;
            switch(designation)
            {
                case "Manager":
                    bonus = basic * 0.55f;
                    break;
                case "Clerk":
                    bonus = basic * 0.45f;
                    break;
                case "Peon":
                    bonus = basic * 0.35f;
                    break;
                default:
                    bonus = basic * 0.0f;  
                    break;
            }

            if (checkBox1.Checked )
            {
                sb.Append( "Bonus: "+bonus+"\n");
            }
            if(checkBox2.Checked )
            {
                totalSal = bonus + basic;
                sb.Append("Total Salary: " + totalSal+"\n");
            }

            richTextBox1.Text=(sb.ToString());
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
             
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
