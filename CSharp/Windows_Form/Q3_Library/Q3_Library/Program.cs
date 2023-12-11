using Q3_Library;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {

        //Create Author
        Author author1 = new Author("Jaane de");
        Author author2 = new Author("Rehne de");

        //Create Books
        Book Book1 = new Book("1111", "111",author1);
        Book Book2 = new Book("2222", "222", author2);

        //Create Library
        library library = new library();
        library.AddBook(Book1);
        library.AddBook(Book2);

        library.DisplayBooks();

        library.RemoveBook("111");


        library.DisplayBooks();

        Console.ReadLine();

    }
}