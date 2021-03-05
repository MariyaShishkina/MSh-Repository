using System;


namespace Lesson1.Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number and press Enter: ");
            string xString = Console.ReadLine();
            double x = Convert.ToDouble(xString);

            Console.WriteLine("Enter second number and press Enter: ");
            string yString = Console.ReadLine();
            double y = Convert.ToDouble(yString);

            Console.WriteLine("Enter third number and press Enter: ");
            string zString = Console.ReadLine();
            double z = Convert.ToDouble(zString);

            double firstExpressionResult = (x + y) * (Math.Pow(z, 2) + 1);
            double secondExpressionResult = ((x % y) - 1) * Math.Sqrt(y);
            double thirdExpressionResult = (x * y + y * z) / Math.Pow(y, 3);

            Console.WriteLine("First expression result: {0}", firstExpressionResult);

            Console.WriteLine("Third expression result: {0}", thirdExpressionResult);


            Console.ReadKey();
        }

    }
}
