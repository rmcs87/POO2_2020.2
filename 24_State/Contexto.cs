using System;
using System.Collections.Generic;
using System.Text;


public class Contexto
{
    private Estado _estado;

    public void SetEstado(Estado estado)
    {
        _estado = estado;
    }
    public void FazAlgo()
    {
        _estado.FazAlgo();
    }
    public void FazAlgoDiferente()
    {
        _estado.FazAlgoDiferente();
    }
}

