using System;

public abstract class Estado
{
    protected Contexto _contexto;

    protected Estado(Contexto contexto)
    {
        SetContexto(contexto);
    }

    public void SetContexto(Contexto contexto) {
        _contexto = contexto;
    }

    public abstract void FazAlgo();

    public abstract void FazAlgoDiferente();
}