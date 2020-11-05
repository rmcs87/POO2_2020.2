using System;

namespace _20_FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello FlyWeight");

            string document = "AABBB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

        }
    }
}
