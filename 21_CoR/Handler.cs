public abstract class Handler
{
    protected Handler _next;

    public void SetNext(Handler handler)
    {
        _next = handler;
    }

    public abstract void Handle(Purchase request);
}

