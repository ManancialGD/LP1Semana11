using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing Guarda3 with string type
        Guarda3<string> guardaStrings = new Guarda3<string>();
        guardaStrings.SetItem(0, "First");
        guardaStrings.SetItem(1, "Second");
        guardaStrings.SetItem(2, "Third");

        Console.WriteLine("Strings in Guarda3:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Item {i + 1}: {guardaStrings.GetItem(i)}");
        }

        // Testing Guarda3 with float type
        Guarda3<float> guardaFloats = new Guarda3<float>();
        guardaFloats.SetItem(0, 1.1f);
        guardaFloats.SetItem(1, 2.2f);
        guardaFloats.SetItem(2, 3.3f);

        Console.WriteLine("\nFloats in Guarda3:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Item {i + 1}: {guardaFloats.GetItem(i)}");
        }
    }
}
