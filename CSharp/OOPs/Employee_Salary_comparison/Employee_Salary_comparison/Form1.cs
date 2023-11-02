using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_comparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp=  new Employee[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0]=new Employee();
            emp[1]=new Employee();
            emp[2]=new Employee();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt<3)
            {
                emp[cnt].EmployeeId=Convert.ToInt32(textBox1.Text);
                emp[cnt].EmployeeName=textBox2.Text;
                emp[cnt].Salary=Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if(cnt==3)
                {
                    button1.Enabled=false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("you have enterd three employee details\n" +
                        "now click the below button to check the highest salary");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("employee   details  of company  ");
           for (int i = 0; i<3;i++)
                {
                sb.Append("------------------------------  \n");
                sb.Append("employee id" + emp[i].EmployeeId);
                sb.Append("employee name " + emp[i].EmployeeName);
                sb.Append("employee salary " + emp[i].Salary);
                sb.Append("---------------------------------\n");
                richTextBox1.Text=sb.ToString();



                //code for higest salary
                double high = emp[0].Salary;
                int foundat = 0;
                for(i = 1; i < 3; i++)
                {
                    if (high < emp[i].Salary)
                        {
                high = emp[i].Salary;
                foundat = i;
            }
                }
                StringBuilder sb1= new StringBuilder();
                sb1.Append("Employee  with highest Salary");
                sb1.Append("Employee number " + emp[foundat].EmployeeId + "\n");
                sb1.Append("Employee  name " + emp[foundat].EmployeeName+ "/n");
                sb1.Append("Employee  Salay " + emp[foundat].Salary+ "/n");


            }
        }
    }
}
