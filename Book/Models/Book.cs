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
        Code = SetCode(Name, Counter);
    }
    private static int Counter = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public string Code { get; }
    public static string SetCode(string name, int id)
    {
        string characters = name.Substring(0, 1);
        string code = $"{characters.ToUpper()}-{id}";
        Console.WriteLine(code + " code ");
        return code;
    }


}

