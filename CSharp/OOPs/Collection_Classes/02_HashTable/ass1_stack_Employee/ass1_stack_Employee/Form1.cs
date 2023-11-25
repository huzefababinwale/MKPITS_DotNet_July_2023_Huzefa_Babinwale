using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ass1_stack_Employee
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
        Stack st = new Stack();
        Employee emp = null;
        private void button1_Click(object sender, EventArgs e)
        {
            int empno=Convert.ToInt32(textBox1.Text);
            string empname=textBox2.Text;
            int empsal=Convert.ToInt32(textBox3.Text);
            string desig=textBox4.Text;

            emp=new Employee(empno,empname, empsal,desig);
            st.Push(emp);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StringBuilder sb = new StringBuilder();
            foreach(Employee emp in st)
            {
                sb.Append("employee number= " + emp.empno + "\t Emp Name: " + emp.empname + "\t Emp Salary: " + emp.salary + "\tEmp Designation:  " + emp.designation+"\n");
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.Pop();
        }
    }
}
