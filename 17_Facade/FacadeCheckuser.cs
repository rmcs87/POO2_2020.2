using System;
using System.Collections.Generic;
using System.Text;


public class FacadeCheckuser
{
    private Bank subSystemBank;
    private Credit subSystemCredit;
    private Loan subSystemLoan;
    public FacadeCheckuser()
    {
        subSystemBank = new Bank();
        subSystemCredit = new Credit();       
        subSystemLoan = new Loan();
    }
    public bool IsEligible(Client c, int amount)
    {
        Console.WriteLine($"Solicitação de Emprestimo por: {c.Name}:");
        if (!subSystemBank.CheckSavings(c, amount) 
            || !subSystemCredit.CheckClenaNameInSerasa(c)
            || subSystemLoan.CheckForOtherLoans(c))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

