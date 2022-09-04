using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;




public interface IlibraryRepository<Kitab> 
{
    void AddBook(Kitab book);
    Kitab GetBook(Func<Kitab, bool> expression);
    List<Kitab>  FindAllBooks(Func<Kitab, bool> expression);
    int RemoveAllBooks(Predicate<Kitab> expression);
}


