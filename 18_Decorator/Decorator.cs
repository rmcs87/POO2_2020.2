public abstract class Decorator : LibraryItem
{
    protected LibraryItem _libraryItem;

	public Decorator(LibraryItem item)
	{
		_libraryItem = item;
	}

	public override void Display()
	{
		_libraryItem.Display();
	}
}
