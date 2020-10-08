using System;
using System.Collections.Generic;
using System.Text;

public class SystemMessage : Message
{
    public override void Send()
    {
        _sender.SendMessage(Subject, Body);
    }
}
