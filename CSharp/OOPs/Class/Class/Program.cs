using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;
            public void get_data(int cc, string cn)
            {
                customer_code=cc;
                customer_name=cn;
            }
            public void display()
            {
                Console.WriteLine("Customer Code "+customer_code);
                Console.WriteLine("Customer Name "+customer_name);
            }
        }

        static void Main(string[] args)
        {
            Customer cust=new Customer();
            cust.get_data(123, "Amit");
            cust.display();

            Console.ReadKey();
        }
    }
}
