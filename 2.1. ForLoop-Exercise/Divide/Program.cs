using System;

namespace Divide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countP1++;
                }
                if (number % 3 == 0)
                {
                    countP2++;
                }
                if (number % 4 == 0)
                {
                    countP3++;
                }
            }

            Console.WriteLine($"{(double)countP1 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP2 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP3 / n * 100:f2}%");
        }
    }
}