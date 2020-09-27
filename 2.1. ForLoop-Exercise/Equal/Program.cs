using System;

namespace Equal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    countP1++;
                }
                else if (number <= 399)
                {
                    countP2++;
                }
                else if (number <= 599)
                {
                    countP3++;
                }
                else if (number <= 799)
                {
                    countP4++;
                }
                else
                {
                    countP5++;
                }
            }
            Console.WriteLine($"{(double)countP1 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP2 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP3 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP4 / n * 100:f2}%");
            Console.WriteLine($"{(double)countP5 / n * 100:f2}%");
        }
    }
}