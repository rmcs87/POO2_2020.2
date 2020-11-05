using System;

public class Presidente : Handler
{
    public override void Handle(Purchase request)
    {
        if (request.Total < 1000000.00)
        {
            Console.WriteLine($"{GetType().Name} aprovou a requisição # {request.Numero}");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} enviou e-mail com reunião de emergência.");
        }
    }
}

