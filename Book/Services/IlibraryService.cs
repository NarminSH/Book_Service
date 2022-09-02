using System;
using System.Collections.Generic;
using System.Text;



public interface IlibraryService
{
    public void FindAllBooksByName(string name);
    public void RemoveAllBooksByName(string value);
    public void SearchBooks(string value);
    public void FindAllBooksByPageCountRange(int min, int max);
    public void SearchBooksByPageCountRange(int min, int max, int pageCount);

}


