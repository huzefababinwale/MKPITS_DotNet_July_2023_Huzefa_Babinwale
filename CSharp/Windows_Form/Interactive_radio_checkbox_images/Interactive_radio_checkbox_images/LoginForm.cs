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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        StringBuilder sb= new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            sb.Append(username+"\t:\t"+password+"\n");
            string gender;
            if (radioButton1.Checked)
            {
                gender = "Male";
                sb.Append("Gender: \t" + gender+"\n");
            }else if (radioButton2.Checked)
            {
                gender = "Female";
                sb.Append("Gender: \t" + gender + "\n");
            }
            else
            {
                MessageBox.Show("please Select Valid Gender");
            }
            string cources;
            if(checkBox1.Checked)
            {
                cources = "DotNet";
                sb.Append("cources: \t"+cources + "\n");
            }
            if(checkBox2.Checked)
            {
                cources = "JAVA";
                sb.Append("cources: \t"+cources + "\n");
            }
            if(checkBox3.Checked)
            {
                cources = "Python";
                sb.Append("cources: \t" + cources + "\n");
            }


            string dob = dateTimePicker1.Text;
            MessageBox.Show("D.O.B." + dob);
            sb.Append("D.O.B." +dob+"\t");
            string age = numericUpDown1.Value.ToString();
            sb.Append("Age: " + age + "\n");

            sb.Append("Country: " + comboBox1.Text+"\tCity: "+comboBox2.Text+"\n");
            label6.Text=sb.ToString();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Gondia");
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Banglore");
                    comboBox2.Items.Add("Hyderabad");
                    comboBox2.Items.Add("Delhi");
                    break;
                case "USA":
                    comboBox2.Items.Add("California");
                    comboBox2.Items.Add("Butagorila");
                    break;
            }
        }
    }
}
