using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DECORATOR !!!!");

        Book book = new Book("C#", "Desconhecido", 5);
        book.Display();

        Console.WriteLine("Mudando o comportamento.......");

        Borrowable borrowableBook = new Borrowable(book);

        borrowableBook.BorrowItem("Fulano");
        borrowableBook.BorrowItem("Sicrano");

        borrowableBook.Display();

    }
}
