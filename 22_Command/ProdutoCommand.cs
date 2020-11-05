using System;
using System.Collections.Generic;
using System.Text;

public class ProdutoCommand : ICommand
{
    private Produto _produto;
    private PriceAction _priceAction;
    private decimal _amount;

    public ProdutoCommand(Produto produto, PriceAction priceAction, decimal amount)
    {
        _produto = produto;
        _priceAction = priceAction;
        _amount = amount;
    }

    public void Execute()
    {
        if (_priceAction == PriceAction.Increase)
            _produto.AumentarPreco(_amount);
        else
            _produto.DiminuirPreco(_amount);
    }
}
