using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello States!");

        var contexto = new Contexto();
        contexto.SetEstado(new EstadoConcreto1(contexto) );

        contexto.FazAlgo();
        contexto.FazAlgo();
    }
}

