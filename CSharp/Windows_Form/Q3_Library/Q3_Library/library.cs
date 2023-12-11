using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Library
{
    internal class library
    {
        List<Book> books=new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = null;
            

            foreach(var book in books)
            {
                if(book.ISBN==isbn)
                {
                    bookToRemove = book;
                    break;
                }
            }
            if(bookToRemove!=null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book removed from the library: {bookToRemove}");
            }
            else
            {
                Console.WriteLine("Books Not Found in Library");
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine();
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
