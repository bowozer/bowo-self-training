using System;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");

            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
