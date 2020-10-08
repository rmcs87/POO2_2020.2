using System;
using System.Collections.Generic;
using System.Text;

public class SenderEmail : ISender
{
    public void SendMessage(string body, string subject)
    {
        Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
    }
}