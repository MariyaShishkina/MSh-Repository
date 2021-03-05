using System;

namespace Lesson1.Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of rectangular parallelepiped and press Enter: ");
            string widthString = Console.ReadLine();
            double width = Convert.ToDouble(widthString);

            Console.WriteLine("Enter the height of rectangular parallelepiped and press Enter: ");
            string heightString = Console.ReadLine();
            double height = Convert.ToDouble(heightString);

            Console.WriteLine("Enter the length of rectangular parallelepiped and press Enter:");
            string lengthString = Console.ReadLine();
            double length = Convert.ToDouble(lengthString);

           
            string diagonal = $"Parallelepiped diagonal length:{Math.Round(Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2)), 1)}";
           
            Console.WriteLine(diagonal);

            Console.ReadKey();
        }
    }
}
