using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Book
    {
        int BookId;
        string title;
        string author;
        int price;
        public Book()
        {
            BookId = 0;
            title = "No_Rules";
            author = "JRK";
            price = 1000;
        }
        public void display()
        {
            Console.WriteLine("Book Id = " + BookId);
            Console.WriteLine("Book Title = "+ title);
            Console.WriteLine("Author = " + author);
            Console.WriteLine("price = " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b=new Book();
            b.display();
            Console.ReadLine();
        }
    }
}
