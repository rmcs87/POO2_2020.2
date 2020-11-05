public class Purchase
{
    public Purchase(int numero, double total, string motivo)
    {
        Numero = numero;
        Total = total;
        Motivo = motivo;
    }

    public int Numero { get; private set; }
    public double Total { get; private set; }
    public string Motivo { get; private set; }
}