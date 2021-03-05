using System;


namespace Lesson1.Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write the first string and press Enter: ");
            string firstString = Console.ReadLine();
            firstString = firstString.ToUpper();

            Console.WriteLine("Write the second string and press Enter: ");
            string secondString = Console.ReadLine();
            secondString = secondString.ToUpper();

            Console.WriteLine("Write the third string and press Enter: ");
            string thirdString = Console.ReadLine();
            thirdString = thirdString.ToUpper();

            bool comparison1 = firstString.StartsWith(secondString);
            bool comparison2 = firstString.EndsWith(thirdString);

            Console.WriteLine("String {0} starts from {1} : {2}", firstString, secondString, comparison1);
            Console.WriteLine("String {0} ends with {1} : {2}", firstString, thirdString, comparison2);

            Console.ReadKey();

        }
    }
}
