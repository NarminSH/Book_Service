using System;
using System.Collections.Generic;
using System.Text;

public class Kitab
{
    public Kitab(string name, string author, int page)
    {
        Counter++;
        Id = Counter;
        Name = name;
        AuthorName = author;
        PageCount = page;
        Code = name[0].ToString().ToUpper() + "-" + Counter;
    }
    private static int Counter = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public double Price { get; set; }
    public string Code { get; }
}

