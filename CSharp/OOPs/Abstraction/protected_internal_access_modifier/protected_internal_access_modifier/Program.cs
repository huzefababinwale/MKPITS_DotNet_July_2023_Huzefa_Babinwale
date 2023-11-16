using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal_access_modifier
{
    public class person
    {
        string name;
        string address;
        protected internal void getdata(string name, string address)
        {
            this.name=name;
            this.address= address;
        }
        protected internal void display()
        {
            Console.WriteLine("name : "+name);
            Console.WriteLine("Address : "+address);
        }
    }
    class student : person
    {
        int rollno;
        int marks;
        public void getstudentdata(int rollno, int marks)
        {
            this.rollno = rollno;
            this.marks= marks;
        }
        public void displaystudentdata()
        {
/*            Console.WriteLine("Name: " +name);
            Console.WriteLine("address : " + address);*/
            Console.WriteLine("roll number: " + rollno);
            Console.WriteLine("marks: "+marks);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            student s = new student();
            s.getdata("rohan ","JOJO");
            s.display();
            Console.WriteLine("------------------------------------");
            s.getstudentdata(121,555);
            s.displaystudentdata();

            Console.ReadKey();
        }
    }
}
