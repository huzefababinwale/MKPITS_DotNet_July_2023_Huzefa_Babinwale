using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class
{
    internal class Program
    {
        class Student
        {
            string name;
            int roll_no;
            int[] marks=new int[3];
            int avg;

            public void average(string name,int roll_no, int[] marks)
            {
                this.name = name;
                this.roll_no = roll_no; 
                this.marks = marks;
                int total = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    total += marks[i];
                }
                int avg=total / marks.Length;
                this.avg = avg;
            }
            public void display()
            {
                Console.WriteLine("Name: "+this.name);
                Console.WriteLine("Roll number: "+this.roll_no);    
                Console.WriteLine("Average Marks: "+this.avg);
                
            }
        }

        static void Main(string[] args)
        {
            int[] M = {55,45,65};/*int[] M= new int[3];*/
            Student std = new Student();
            string n;
            int r;
            n = "Ashish";
            r = 22;

            std.average( n,r,M);
            std.display();
            Console.ReadKey();
        }
    }
}
