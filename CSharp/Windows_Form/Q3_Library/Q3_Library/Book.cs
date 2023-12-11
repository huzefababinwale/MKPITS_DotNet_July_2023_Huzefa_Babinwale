using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Library
{
    internal class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        Author Author { get; set; }

        public Book(string Title, string ISBN, Author author) 
        {
            this.Title = Title;
            this.ISBN = ISBN;
            this.Author = author;
        }

        public override string ToString()
        {
            return "Title: "+this.Title +"\tISBN"+ this.ISBN +"\tAuthor"+ this.Author;
        }
    }
}
