using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adapter!");

        var hrSystem = new HRSystem();       
        var adapter = new Adapatador(hrSystem);        
        var third = new ThirdPartySystem();

        third.ShowEmpoyeeList(adapter);
    }
}
