using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class
{
    internal class Program
    {
        class Employee
        {
            int emp_number;
            string emp_name;
            string designation;
            int salary;
            public void get_data(int num, int sal, string name, string des  )
            {
                emp_name = name;
                emp_number = num;
                designation = des;
                salary = sal;
            }
            public void display_data()
            {
                Console.WriteLine(emp_name + "  emp_name");
                Console.WriteLine(emp_number + " emp_number");
                Console.WriteLine(designation + " Designation");
                Console.WriteLine(salary+ " Salary");    
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.get_data(1234, 25000,"Suresh", "Owner");
            emp.display_data();
            Console.ReadKey();
        }
    }
}
