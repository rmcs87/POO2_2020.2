using System;
using System.Collections.Generic;
using System.Text;


public class SistemaDeVendas
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public decimal Budget { get; set; }

    public IMemento SaveMemento()
    {
        Console.WriteLine("Salvando");
        return new Memento(Name, Budget);
    }

    public void RestoreMemento(IMemento imemento)
    {
        var memento = imemento as Memento;
        Console.WriteLine("Restaurando");
        Name = memento.Name;
        Budget = memento.Budget;
    }

    public class Memento : IMemento
    {
        public string Name{ get; private set; }
        public decimal Budget { get; private set; }        

        public Memento(string name, decimal budget)
        {
            this.Name = name;
            this.Budget = budget;
        }
    }
}

