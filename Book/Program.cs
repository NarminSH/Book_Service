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
            LibraryRepository library = new LibraryRepository();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);


            var books = library.FindAllBooks(x => x.AuthorName.Contains("j.k.rowling"));
            foreach (var item in books)
            {
                Console.WriteLine(item.Name);
            }
            Order order = new Order(books, 45.80, new DateTime(2022 - 03 - 03));

        }
    }
}
