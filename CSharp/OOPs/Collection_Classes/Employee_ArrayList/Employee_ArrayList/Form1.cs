using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arr=new ArrayList();
        Employee emp_i = null;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for(i=1; i<=1; i++)
            {
                int empno = Convert.ToInt32(textBox1.Text);
                string empname = textBox2.Text;
                int salary = Convert.ToInt32(textBox3.Text);
                string designation = textBox4.Text;
                emp_i = new Employee(empno, empname, salary, designation);
                arr.Add(emp_i);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Employee emp in arr)
            {
                sb.Append("Employee Number: "+emp.empno+"\t Employee Name: "+emp.empname+"\tDesignation: "+emp.designation+"\tSalary: "+emp.salary+"\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
