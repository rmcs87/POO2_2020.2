using System;
using System.Collections.Generic;
using System.Text;
public class BotaoDePreco
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
    
    public void Invoke()
    {
        _command.Execute();
    }
}

