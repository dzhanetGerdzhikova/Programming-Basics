using System;

namespace LeftRightSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            int countNumber = 0;

            for (int i = 0; i < 2 * num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                countNumber++;

                if (countNumber <= num)
                {
                    sumLeft += number;
                }
                if (countNumber > num)
                {
                    sumRight += number;
                }
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}