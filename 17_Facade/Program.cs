using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Facade Pattern!");

        Client client = new Client("Ricardo Mendes");

        FacadeCheckuser facade = new FacadeCheckuser();

        bool emprestar = facade.IsEligible(client, 2500);

        if (emprestar)
        {
            Console.WriteLine("Conceder Emprestimo");
        }
        else
        {
            Console.WriteLine("Não Conceder Emprestimo");
        }
    }
}
