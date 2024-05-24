using System;

namespace JustLikeACollection
{
    public class Program
    {
        private static void Main()
        {
            // Creating instances of Guarda3<T> using collection initializer syntax
            Guarda3<string> g3s = new Guarda3<string> { "Hello", "World" };
            Guarda3<float> g3f = new Guarda3<float> { 1.1f, 2.2f, 3.3f };

            // Adding more items using the Add method
            g3s.Add("!");
            g3f.Add(4.4f);

            // Displaying the items in the Guarda3 instances
            Console.WriteLine("Strings:");
            foreach (string item in g3s)
            {
                Console.WriteLine($"    {item}");
            }

            Console.WriteLine("Floats:");
            foreach (float item in g3f)
            {
                Console.WriteLine($"    {item}");
            }

            // Expected output:

            // Strings:
            //     Hello
            //     World
            //     !
            // Floats:
            //     1.1
            //     2.2
            //     3.3
            //     4.4
        }
    }
}
