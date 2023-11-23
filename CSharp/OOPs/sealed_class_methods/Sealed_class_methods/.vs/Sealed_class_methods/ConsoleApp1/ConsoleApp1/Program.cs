using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed public class Book
    {
        string BName;
        string BAuthor;
        int Price;
        public void getBook(string BName, string BAuthor, int Price) 
        {
            BName = this.BName;
            BAuthor= this.BAuthor ;
            Price = this.Price;
        }
        public void display()
        {
            Console.WriteLine(this.BName);
            Console.WriteLine(this.BAuthor);
            Console.WriteLine(this.Price);
        }

    }
    class RefrenceBook : Book
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            string name = "ABCD";
            string author = "XQW";
            int price = 10;
            book.getBook(name, author, price);
            book.display();
            Console.ReadKey();
        }
    }
}
