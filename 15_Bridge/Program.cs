using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bridge");

        Message message = new UserMessage();
        message._sender = new SenderEmail();

        message.Send();

    }
}
