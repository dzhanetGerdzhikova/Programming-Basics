using System;

namespace MinNum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            int numMin = int.MaxValue;

            while (n > 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num < numMin)
                {
                    numMin = num;
                }
                n--;
            }
            Console.WriteLine(numMin);
        }
    }
}