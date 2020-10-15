using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Composite");

        Caixa cmenor = new Caixa();
        cmenor.ItemList.Add(new Martelo()); 
        cmenor.ItemList.Add(new Martelo()); 
        cmenor.ItemList.Add(new Martelo()); 
        cmenor.ItemList.Add(new Martelo());

        Caixa cmaior = new Caixa();
        cmaior.ItemList.Add(cmenor);
        cmaior.ItemList.Add(new Celular());
        cmaior.ItemList.Add(new Celular());
        cmaior.ItemList.Add(new Celular());
        cmaior.ItemList.Add(new Martelo());

        Console.WriteLine($"Custo = > {cmaior.GetPrice()}");
        Console.WriteLine($"Volume = > {cmaior.GetVolume()}");

    }
}
