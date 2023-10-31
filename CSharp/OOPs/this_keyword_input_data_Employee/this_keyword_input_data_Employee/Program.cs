using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword_input_data_Employee
{
    internal class Program
    {
        class Employee 
        {
            int emp_id;
            string emp_name;
            string emp_designation;
            int salary;

            public void get_data(int emp_id, string emp_name, string emp_designation, int salary )
            {
                this.emp_id = emp_id;
                this.emp_name = emp_name;
                this.emp_designation = emp_designation;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine("Enter Employee ID: "+ emp_id);
                
                Console.WriteLine("Enter Employee Name: "+ emp_name);
               
                Console.WriteLine("Enter Employee Designation: "+ emp_designation);
                
                Console.WriteLine("Enter Employee Salary: "+ salary);
                


                

            }
        }
        static void Main(string[] args)
        {
            Employee xyz = new Employee();
            Console.WriteLine("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation: ");
            string designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            xyz.get_data(id,name,designation,salary);
            xyz.display();

            Console.ReadLine();
        }
    }
}
