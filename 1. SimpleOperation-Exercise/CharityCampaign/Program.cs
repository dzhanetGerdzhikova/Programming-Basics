using System;

namespace Charity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());//20
            int sweets = int.Parse(Console.ReadLine());//8
            int cake = int.Parse(Console.ReadLine());//14
            int gofreta = int.Parse(Console.ReadLine());//30
            int puncake = int.Parse(Console.ReadLine());//16

            double cakePrice = 45;
            double gofretaPrice = 5.80;
            double pukcakePrice = 3.20;

            double cakePriceOfDay = cake * cakePrice;
            double gofretaPriceOfDay = gofreta * gofretaPrice;
            double puncakePriceOfDay = puncake * pukcakePrice;

            double totalPriceOfDay = (cakePriceOfDay + gofretaPriceOfDay + puncakePriceOfDay) * sweets;
            double totalSum = totalPriceOfDay * days;
            double num = 1d / 8d;
            double totalSumEnd = totalSum - num * totalSum;

            Console.WriteLine($"{totalSumEnd:F2}");
        }
    }
}