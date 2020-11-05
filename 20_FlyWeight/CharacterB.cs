using System;

public class CharacterB : Character
{
    public CharacterB()
    {
        this.symbol = 'B';
        this.height = 100;
        this.width = 140;
    }

    public override void Display(int pointSize)
    {
        this.pointSize = pointSize;
        Console.WriteLine(this.symbol +
          " (pointsize " + this.pointSize + ")");
    }
}
