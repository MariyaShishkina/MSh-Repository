using System;


namespace Lesson1.Task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write the first string and press Enter: ");
            string firstString = Console.ReadLine();

            Console.WriteLine("Write the second string and press Enter: ");
            string secondString = Console.ReadLine();

            Console.WriteLine("Write the symbol and press Enter: ");
            char symbol = (char)Console.Read();

            string finalString = firstString + secondString + symbol;
            int index = finalString.LastIndexOf(symbol);

            Console.WriteLine("Index of {0} in {1} : {2}", symbol, finalString, index);

            Console.ReadKey();
        }
    }
}

