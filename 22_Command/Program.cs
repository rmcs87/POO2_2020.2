using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Command!");

        var botaoDePreco = new BotaoDePreco();      //invoker
        var produto = new Produto("Phone", 1200);   //receiver

        var c1 = new ProdutoCommand(produto, PriceAction.Decrease, 100);
        var c2 = new ProdutoCommand(produto, PriceAction.Increase, 200);

        botaoDePreco.SetCommand(c2);

        botaoDePreco.Invoke();

        Console.WriteLine(produto);

    }
}

