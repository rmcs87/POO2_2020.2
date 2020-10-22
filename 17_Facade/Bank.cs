using System;

public class Bank
{
    public bool CheckSavings(Client c, int amount)
    {
        Console.WriteLine($"Cheking {c.Name} Savings ...");

        return (new Random().Next(100) < 50 ? true : false);
    }
}

