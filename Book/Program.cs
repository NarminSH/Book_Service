using Book.Models;
using System;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitab book1 = new Kitab("hqrry potter", "j.k.rowling", 100);
            Kitab book2 = new Kitab("hzrry potter2", "j.k.rowling2", 200);
            Kitab book3 = new Kitab("hsrry potter3", "j.k.rowling3", 300);
            Library library = new Library();

            
            library.books.Add(book1);
            library.books.Add(book2);
            library.books.Add(book3);
            library.FindAllBooksByName("harry potter");
            //library.RemoveAllBooksByName("potter");
            Kitab book4 = new Kitab("harry potter4", "j.k.rowling2", 200);
            library.books.Add(book4);
            library.SearchBooks("hqrry potter");
            library.SearchBooks("200");

        }
    }
}
