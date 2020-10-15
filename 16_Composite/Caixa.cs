using System;
using System.Collections.Generic;
using System.Text;

public class Caixa : IItem
{
    private List<IItem> _items;

    public Caixa()
    {
        _items = new List<IItem>();
    }

    public List<IItem> ItemList { get { return _items; } }

    public float GetPrice()
    {
        float value = 0;
        foreach (var item in _items)
        {
            value += item.GetPrice();
        }
        return value + 0.5f;
    }
    public float GetVolume()
    {
        float value = 0;
        foreach (var item in _items)
        {
            value += item.GetVolume();
        }
        if(value < 5)
        {
            return 5;//caixa pequena
        }else if (value < 10)
        {
            return 10;//caixa media
        }
        else
        {
            return 100;//caxa grande
        }
    }
}
