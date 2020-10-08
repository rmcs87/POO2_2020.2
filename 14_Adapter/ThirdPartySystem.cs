using System;
using System.Collections.Generic;
using System.Text;


public class ThirdPartySystem
{
    public void ShowEmpoyeeList(IHRSystem hr)
    {
        List<string> lista = hr.GetEmployees();
        foreach (var item in lista)
        {
            Console.Write(item);
        }
    }
}
