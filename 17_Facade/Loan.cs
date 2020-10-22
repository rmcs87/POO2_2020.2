using System;

public class Loan
{
    public bool CheckForOtherLoans(Client c)
    {
        Console.WriteLine($"Cheking {c.Name} Loans ...");

        return (new Random().Next(100) < 50 ? true : false);
    }
}
