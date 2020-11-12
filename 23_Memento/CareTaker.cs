using System.Collections;
using System.Collections.Generic;

public class CareTaker
{ 
    Stack<IMemento> _stack;

    public CareTaker()
    {
        _stack = new Stack<IMemento>();
    }

    public void SaveState(SistemaDeVendas sv)
    {
        _stack.Push(sv.SaveMemento());
    }

    public void RestoreLastState(SistemaDeVendas sv)
    {
        if(_stack.Count > 0)
            sv.RestoreMemento(_stack.Pop());
    }
}
