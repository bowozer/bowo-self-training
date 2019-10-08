using StringLibrary;
using System;

namespace ShowCaseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress enter a string and press <Enter>: \n");

            string input = Console.ReadLine();
            Console.WriteLine(value: $"Input: {input} {"Begins with uppercase?",30}: {(input.StartsWithUpper() ? "Yes" : "No")}\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
