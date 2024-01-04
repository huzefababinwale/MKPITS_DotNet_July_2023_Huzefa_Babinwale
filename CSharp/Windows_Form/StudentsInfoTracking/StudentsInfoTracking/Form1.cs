using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInfoTracking
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

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass s= new StudentClass();
            string gender=null;
            if(radioButton1.Checked) { gender = "male"; }
            if(radioButton2.Checked) { gender = "female"; }
            string hobby=null;
            if (checkBox1.Checked) { hobby = "Music"; }
            if (checkBox2.Checked) 
            { 
                if (hobby != null) 
                { hobby = hobby + ", " + "Cricket";}
                else { hobby = "Cricket"; }
            }
            s.insertstudent(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, hobby, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = "Data Inserted Succesfully";
            cleartext();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string h=null;
            string g = null;
            if (radioButton1.Checked) { g = "male"; }if (radioButton2.Checked) { g = "female"; }
            if (checkBox1.Checked) { h = "Music"; }
            if(checkBox2.Checked) { if (h != null) { h = h + "," + "Cricket"; } else { h = "Cricket"; } }

           s.updatestudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = "Record Updated Successfully";
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentClass s=new StudentClass();
            string result= s.deletestudent(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text= result;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<StudentClass> li= new List<StudentClass>();
            StudentClass s=new StudentClass();
            li = s.Searchstudent(Convert.ToInt32(textBox1.Text));
            textBox2.Text = li[0].stdname;
            string g = li[0].gender;
            if(g=="male")
            {
                radioButton1.Checked=true;
            }else if(g=="female" ){ radioButton2.Checked = true; }
            
        }
    }
}
