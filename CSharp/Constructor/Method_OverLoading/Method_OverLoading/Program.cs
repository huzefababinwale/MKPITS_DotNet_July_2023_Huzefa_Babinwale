using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Method_OverLoading
{
    internal class Program
    {
        class Book
        {
            int BookId;
            string Title;
            string Author;
            int Price;

            public void GetData()
            {
                Console.WriteLine("Get Data with No Parameter Called Successfully");
            }
            public void GetData(string Title, string Author, int BookId, int Price)
            {
                Console.WriteLine("Parameterized GetData Called: ");
                Console.WriteLine("{0}\n {1} \nBookID- {2} \nWorth of Rs.{3}",Title, Author, Price, BookId);
            }

        }
        static void Main(string[] args)
        {
            Book b1= new Book();
            b1.GetData();
            b1.GetData("Title: Console ","By: Khan Sir",1234,10000);
            Console.ReadKey();
        }
    }
}
