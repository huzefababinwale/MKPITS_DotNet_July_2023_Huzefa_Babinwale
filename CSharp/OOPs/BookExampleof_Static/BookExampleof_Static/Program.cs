using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExampleof_Static
{
    internal class Program
    {
        class Book
        {
            public static int Id;
            
            public static void diary(string m)
            {
                Console.WriteLine(m);
            }
            public void ndiary()
            {
                Console.WriteLine("These function is not static so we need an instance to call it ");
            }
        }
        public static void c()
        {
            Console.WriteLine("These line is child function of program class directly...");
        }
        static void Main(string[] args)
        {

            Book.Id=12;
            string st = "These is diary function under Book class";
            
            Book.diary(st);
            Program.c();


            Book book = new Book();
            book.ndiary();
            Console.ReadKey();
        }
    }
}
