using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;


public class LibraryService : IlibraryService
{
    public void FindAllBooksByName(string value)
    {
        List<Kitab> result = books.FindAll(x => x.Name.ToUpper() == value.ToUpper());
        foreach (var book in result)
        {
            Console.WriteLine($"matched books : {book.Name}");
        }

    }
    public void RemoveAllBooksByName(string value)
    {
        Console.WriteLine("before all removing books by code, books count " + books.Count());

        books.RemoveAll(x => x.Name.ToUpper().Contains(value.ToUpper()));
        Console.WriteLine("before all removing books by code, books count " + books.Count());
    }

    public void SearchBooks(string value)
    {
        int.TryParse(value, out int number);
        if (books.Exists(x => x.Name == value || x.AuthorName == value || x.PageCount == number))
        {
            List<Kitab> allbooks = books.FindAll(x => x.Name == value || x.AuthorName == value || x.PageCount == number);
            foreach (var book in allbooks)
            {
                Console.WriteLine($"Search book result: {book.Name}");
            }
        }

    }

    public void FindAllBooksByPageCountRange(int min, int max)
    {
        List<Kitab> result = books.FindAll(x => min < x.PageCount && x.PageCount < max);
        Console.WriteLine("all books" + result);
    }
    public void RemoveBookByCode(string code)
    {
        Console.WriteLine("before removing books by code, books count " + books.Count());
        if (books.Exists(x => x.Code == code))
        {
            Kitab book = books.Find(x => x.Code == code);
            books.Remove(book);
            Console.WriteLine("after removing books by code, books count " + books.Count());
        }

    }
}

