using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Employee
{
    class person
    {
        public string name;
        public string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("Address : "+this.address);
        }
    }
    class employee:person
    {
        protected internal int empno;   
        protected internal int salary;
        public string designation;
        public void getdata(int empno, int salary, string designation)
        {
            this.empno = empno;
            this.salary = salary;
            this.designation = designation;
        }
        public void display()
        {
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("address : "+this.address);
            Console.WriteLine("empno : "+this.empno);
            Console.WriteLine("salary : "+this.salary);
            Console.WriteLine("designation : "+this.designation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee em=new employee();
            em.name = "abhinav";
            em.address = "Civil Lines";/*
            em.salary = 1000;
            em.empno = 121;
            em.designation = "Manager ";
*/

            em.getdata(1,1000,"daifragum");
            em.display();
            Console.WriteLine("----------------------------");
            person p = new person();
            p.getdata("Abhinaa", "Landge Parivar");
            p.display();


            Console.ReadKey();
        }
    }
}
