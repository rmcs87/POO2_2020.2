using System;
using System.Collections.Generic;
using System.Text;


public class EstadoConcreto1 : Estado
{
    public EstadoConcreto1(Contexto contexto) : base(contexto)
    {
    }

    public override void FazAlgo()
    {
        Console.WriteLine("Estado1 Fazendo Algo");
        Console.WriteLine("Mudando para Estado2");
        _contexto.SetEstado(new EstadoConcreto2(_contexto) );
    }

    public override void FazAlgoDiferente()
    {
        Console.WriteLine("Estado1 Fazendo Algo Diferente.");
    }
}

