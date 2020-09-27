using System;

namespace AccountBalance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int vnoski = int.Parse(Console.ReadLine());

            int napraveniVnoski = 0;
            double sum = 0;

            while (napraveniVnoski < vnoski)
            {
                double wnoska = double.Parse(Console.ReadLine());
                if (wnoska < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {wnoska:f2}");
                    sum += wnoska;
                }
                napraveniVnoski++;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}