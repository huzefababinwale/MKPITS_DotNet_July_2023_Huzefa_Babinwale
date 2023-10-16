using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp_no;
            string emp_name;
            int designation;
            int basic_salary, total, per;
            
            Console.WriteLine("Enter  Employee Number: ");
            emp_no =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter  Employee Name: ");
            emp_name = Console.ReadLine();
            Console.WriteLine("Enter  Basic Salary: ");
            basic_salary =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter  Employee Designation: 1 -Manager, 2 -clerk, 3 -peon ");
            designation =Convert.ToInt32(Console.ReadLine());

            if (designation == 3 )
            {
                per = 10 * basic_salary/100;
                total = basic_salary + per;
                Console.WriteLine("total salary will be: "+total);
            }
            else if (designation == 2)
            {
                per = 25 * basic_salary / 100;
                total = basic_salary + per;
                Console.WriteLine("total salary will be: " + total);
            }
            else if (designation == 3)
            {
                per = 55 * basic_salary / 100;
                total = basic_salary + per;
                Console.WriteLine("total salary will be: " + total);
            }
            else 
            {
                Console.WriteLine("Please Enter Valid Character: 1 - 2 or 3");
                /*Environment.Exit(0);*/
            }
            Console.ReadKey();

        }
    }
}
