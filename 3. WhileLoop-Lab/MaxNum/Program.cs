using System;

namespace MaxNum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int numMax = int.MinValue;
            while (count > 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > numMax)
                {
                    numMax = number;
                }
                count--;
            }
            Console.WriteLine(numMax);
        }
    }
}