using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inh_abstraction
{
    class person
    {
        public string name;
        public int age;
    }
    class student : person
    {
        public int RollNo;
        /*public void getdata(int RollNo)
        {
            this.RollNo = RollNo;
        }*/
        public void display()
        {
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("Age : "+this.age);
            Console.WriteLine("Roll number : "+this.RollNo);
        }
    }

    class teacher : person
    {
        public int ID;
        public int salary;
        public void display()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Age : " + this.age);
            Console.WriteLine("Employee ID : " + this.ID);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s= new student();
            s.name = "sonu";
            s.age = 1;
            s.RollNo = 121;

            s.display();
            Console.WriteLine("------------------------------------");
            teacher t=new teacher();
            t.name = "Master ji";
            t.age = 10;
            t.ID = 420;
            t.display();

            Console.ReadKey();
        }
    }
}
