using System;
using System.Collections.Generic;
using System.Text;

public interface ISender
{
    void SendMessage(string body, string subject);
}
