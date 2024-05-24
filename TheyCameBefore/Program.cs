using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a collection of integers
        List<int> intItems = new List<int> { 1, 3, 5, 7, 9, 11 };

        // Specify an item to compare against
        int compareInt = 6;

        // Get the items that are before the specified item
        IEnumerable<int> intResult = BeforeUtils.GetTheOnesBefore(intItems, compareInt);

        // Print the results
        Console.WriteLine("Integers before 6:");
        foreach (int i in intResult)
        {
            Console.WriteLine(i);
        }

        // Create a collection of doubles
        List<double> doubleItems = new List<double> { 1.1, 3.3, 5.5, 7.7, 9.9, 11.1 };

        // Specify an item to compare against
        double compareDouble = 6.6;

        // Get the items that are before the specified item
        IEnumerable<double> doubleResult = BeforeUtils.GetTheOnesBefore(doubleItems, compareDouble);

        // Print the results
        Console.WriteLine("Doubles before 6.6:");
        foreach (double d in doubleResult)
        {
            Console.WriteLine(d);
        }
    }
}
