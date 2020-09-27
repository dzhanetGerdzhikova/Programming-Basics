using System;

namespace NestedConditionalStatmentsExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool condition1 = (x >= x1 && x <= x2) && (y == y1 || y == y2);
            bool condition2 = (y >= y1 && y <= y2) && (x == x1 || x == x2);
            if (condition1 || condition2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}