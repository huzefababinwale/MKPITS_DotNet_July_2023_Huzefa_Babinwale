using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword_function
{
    internal class Program
    {
        class Book
        {
            static string title;
            static string author;
            static Book()
            {
                
                Console.WriteLine("Static Book Called: ");
                title = "HTML";
                author = "HZF";

            }
            public void display()
            {
                Console.WriteLine("Title: " + title+ "\nAuthor: "+author);
            }
        }
        static void Main(string[] args)
        {

            Book b1 = new Book();
            b1.display();
            Book b2 = new Book();
            b2.display();
            Console.ReadKey();
        }
    }
}
