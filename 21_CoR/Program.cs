using System;


class Program
{
    static void Main(string[] args)
    {
        //Handler h0 = new ViceDiretor();
        Handler h1 = new Diretor();
        Handler h2 = new VicePresidente();
        Handler h3 = new Presidente();
       
        h1.SetNext(h2);
        h2.SetNext(h3);

        Purchase p1 = new Purchase(2034, 350.00, "Assets");
        Purchase p2 = new Purchase(1000, 50050.000, "Mesas");
        Purchase p3 = new Purchase(12, 2000000.00, "cadeiras");

        h1.Handle(p1);
        h1.Handle(p2);
        h1.Handle(p3);
    }
}

