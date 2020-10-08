using System;
using System.Collections.Generic;
using System.Text;

public class UserMessage : Message
{
    public override void Send()
    {
        string newBody = string.Format("{0}\nUserComments: {1}", Body, Subject);
        _sender.SendMessage(Subject, newBody);
    }
}
