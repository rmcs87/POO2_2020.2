using System;

public class VicePresidente : Handler
{
    public override void Handle(Purchase request)
    {
        if (request.Total < 100000.00)
        {
            Console.WriteLine($"{GetType().Name} aprovou a requisição # {request.Numero}");
        }
        else
        {
            _next.Handle(request);
        }
    }
}

