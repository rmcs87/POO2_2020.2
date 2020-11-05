using System;

public class Diretor : Handler
{
    public override void Handle(Purchase request)
    {
        if(request.Total < 10000.00)
        {
            Console.WriteLine($"{GetType().Name} aprovou a requisição # {request.Numero}");
        }
        else
        {
            _next.Handle(request);
        }
    }
}
