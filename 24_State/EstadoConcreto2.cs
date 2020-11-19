using System;
using System.Collections.Generic;
using System.Text;


public class EstadoConcreto2 : Estado
{
    public EstadoConcreto2(Contexto contexto) : base(contexto)
    {
    }

    public override void FazAlgo()
    {
        Console.WriteLine("Estado2 Fazendo Algo");
    }

    public override void FazAlgoDiferente()
    {
        Console.WriteLine("Estado2 Fazendo Algo Diferente");
        _contexto.SetEstado(new EstadoConcreto1(_contexto));
    }
}

