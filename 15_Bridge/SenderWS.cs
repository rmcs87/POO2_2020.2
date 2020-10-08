using System;
using System.Collections.Generic;
using System.Text;

public class SenderWS : ISender
{
    public void SendMessage(string body, string subject)
    {
        Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        Console.WriteLine($"Web Service\n{subject}\n{body}\n");
    }
}

