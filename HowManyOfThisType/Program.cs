using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a collection of objects containing instances of different types
        List<object> items = new List<object>
        {
            1,
            "string",
            2.0,
            3,
            "another string",
            4.5,
            3,
            4,
            'a'
        };

        // Invoke the HowManyOfType method, passing the collection and printing the result
        int numberOfInts = Checker.HowManyOfType<int>(items);
        int numberOfStrings = Checker.HowManyOfType<string>(items);
        int numberOfDoubles = Checker.HowManyOfType<double>(items);
        int numberOfChars = Checker.HowManyOfType<char>(items);

        // Print the counts of each type
        Console.WriteLine($"Number of integers: {numberOfInts}");
        Console.WriteLine($"Number of strings: {numberOfStrings}");
        Console.WriteLine($"Number of doubles: {numberOfDoubles}");
        Console.WriteLine($"Number of chars: {numberOfChars}");

        Console.WriteLine("Obrigado por ter usado este programa!");
    }
}
