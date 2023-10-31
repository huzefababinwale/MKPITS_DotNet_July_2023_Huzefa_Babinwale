using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Books_array
{
    internal class Program
    {
        class Book
        {
            string title;
            string author;
            int publicationYear;

            public void getdata(string title, string author, int publicationyear)
            {
                this.author = author;
                this.title = title;
                this.publicationYear = publicationyear;
            }
            public void displaydata()
            {
                Console.WriteLine("Author :" + author);
                Console.WriteLine("title :" + title);
                Console.WriteLine("publicationyear : " + publicationYear);
            }

        }

        static void Main(string[] args)
        {

            Book[] book = new Book[3];
            book[0] = new Book();
            book[1] = new Book();
            book[2] = new Book();
            string auth = null;
            string tit = null;
            int publication = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Autho Details ");
                auth = Console.ReadLine();

                Console.WriteLine("Enter title ");
                tit = Console.ReadLine();

                Console.WriteLine("Enter publication Year ");
                publication = Convert.ToInt32(Console.ReadLine());
                book[i].getdata(auth, tit, publication);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                book[i].displaydata();

            }
            Console.ReadKey();



        }
    }
}
