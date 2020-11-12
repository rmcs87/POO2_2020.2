using System;

namespace _23_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Memento!");

            CareTaker ct = new CareTaker();

            SistemaDeVendas system = new SistemaDeVendas();
            system.Budget = 10000;
            system.Name = "estado 1";
            ct.SaveState(system);

            system.Budget = 20000;
            system.Name = "estado 2";
            ct.SaveState(system);

            system.Budget = 30000;
            system.Name = "estado 3";
            ct.SaveState(system);

            ct.RestoreLastState(system);
            Console.WriteLine($"CurrentState = {system.Name} , {system.Budget}");
            ct.RestoreLastState(system);
            Console.WriteLine($"CurrentState = {system.Name} , {system.Budget}");
            ct.RestoreLastState(system);
            Console.WriteLine($"CurrentState = {system.Name} , {system.Budget}");
            ct.RestoreLastState(system);
        }
    }
}
