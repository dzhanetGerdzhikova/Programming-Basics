using System;

namespace CharityCampaign
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());//50
            double beerLiters = double.Parse(Console.ReadLine());//10
            double wineLiters = double.Parse(Console.ReadLine());//3.5
            double rakiaLiters = double.Parse(Console.ReadLine());//6.5
            double wiskeyLiters = double.Parse(Console.ReadLine());//1

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double totalRakiaPrice = rakiaLiters * rakiaPrice;
            double totalWinePrice = wineLiters * winePrice;
            double totalBeerPrice = beerLiters * beerPrice;
            double totalWiskeyPrice = wiskeyLiters * wiskeyPrice;

            double totalSum = totalRakiaPrice + totalWinePrice + totalBeerPrice + totalWiskeyPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}