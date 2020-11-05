using System;
using System.Collections.Generic;
using System.Text;
//Classe Receiver
public class Produto
{
    public Produto(string name, decimal preco)
    {
        Name = name;
        Preco = preco;
    }
    public string Name { get; set; }
    public decimal Preco { get; set; }
    public void AumentarPreco(decimal qtd)
    {
        Preco += qtd;
        Console.WriteLine($"O Preço para {Name} aumentou em {qtd}");
    }
    public void DiminuirPreco(decimal qtd)
    {
        if (Preco > qtd)
        {
            Preco -= qtd;
            Console.WriteLine($"O Preço para {Name} diminuiu em {qtd}");
        }
    }
    public override string ToString()
    {
        return $"Valor atual do{Name} é {Preco} ";
    }
}
