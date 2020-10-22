using System;
using System.Collections.Generic;
using System.Text;


public class Credit
{
    public bool CheckClenaNameInSerasa(Client c)
    {
        Console.WriteLine($"Cheking {c.Name} Name in Serasa ...");

        return (new Random().Next(100) < 50 ? true : false);
    }
}

