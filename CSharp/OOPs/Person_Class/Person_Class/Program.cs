using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    internal class Program
    {
        class Person
        {
            string name;
            int age;
            string address;
            public void get_data(string name, int age, string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }
            public void display()
            {
                Console.WriteLine(name);
                Console.WriteLine(age);
                Console.WriteLine(address);
            }
        }
        static void Main(string[] args)
        {
            Person per = new Person();
            Console.WriteLine("Enter Name: ");
            string n =Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            string add =Console.ReadLine();
            per.get_data(n,a,add);
            per.display();
            Console.ReadKey(); 
        }
    }
}
