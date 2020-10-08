public abstract class Message
{
    public ISender _sender { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public abstract void Send();
}

