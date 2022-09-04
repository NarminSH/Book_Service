using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;


public class LibraryRepository : IlibraryRepository<Kitab>
{
    List<Kitab> books = new List<Kitab>();


    public void AddBook(Kitab book)
    {
        books.Add(book);
        Console.WriteLine("Added the book successfuly!");
    }


    public List<Kitab> FindAllBooks(Func<Kitab, bool> expression)
    {
        if (expression == null)
        {
            return books.ToList();
        }
        return books.Where(expression).ToList();
    }



    public Kitab GetBook(Func<Kitab, bool> expression)
    {
        return books.FirstOrDefault(expression);
    }

    public int RemoveAllBooks(Predicate<Kitab> expression)
    {
        return books.RemoveAll(expression);
    }
}

