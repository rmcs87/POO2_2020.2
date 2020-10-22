using System;

public class Book : LibraryItem
{
    public Book(string title, string author, int copies)
    {
        Title = title;
        Author = author;
        NumCopies = copies;
    }

    public string Title { get; set; }
    public string Author { get; set; }

    public override void Display()
    {
        Console.WriteLine($"Book");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"#Copies : {NumCopies}");
    }
}
