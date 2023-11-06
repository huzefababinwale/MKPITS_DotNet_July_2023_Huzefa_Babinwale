using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_overloading
{
    internal class Program
    {
        class Student
        {
            int RollNo;
            string Name;
            string Cource;
            int Fees;


            public void GetData(int RollNo)
            {
                this.RollNo = RollNo;
                
            }
            public void GetData(int RollNo, string Name)
            {
                this.RollNo = RollNo;
                this.Name = Name;
                /*Display();*/
            }
            public void GetData(int RollNo, string Name, String Cource)
            {
                this.RollNo = RollNo;
                this.Cource = Cource;
                this.Name = Name;
                /*Display();*/
            }
            public void GetData(int RollNo, string Name, string Cource, int Fees)
            {
                this.RollNo =RollNo;
                this.Name = Name;
                this.Cource = Cource;
                this.Fees = Fees;
                /*Display();*/
            }
            
            
            public void Display()
            {
                Console.WriteLine("RollNo: " + RollNo);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Cource: " + Cource);
                Console.WriteLine("Fees: " + Fees);

            }
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetData(1);
            student.Display();
            student.GetData(1,"Huzefa");
            student.Display();
            student.GetData(1, "Huzefa", "DotNet");
            student.Display();
            student.GetData(1, "Huzefa", "DotNet", 25000);
            student.Display();


            Console.ReadKey();
        }
    }
}
