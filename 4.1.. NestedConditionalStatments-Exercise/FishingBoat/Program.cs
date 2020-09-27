using System;

namespace FishingBoat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double price = 0.00;
            double discount = 0.00;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (people <= 6)
            {
                discount = 0.1;
            }
            else if (people <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            double totalSum = price * (1 - discount);

            if (people % 2 == 0 && season != "Autumn")
            {
                discount = 0.05;
                totalSum = totalSum * (1 - discount);
                //totalSum *= (1 - discount);
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Yes! You have {(budget - totalSum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalSum - budget):f2} leva.");
            }
        }
    }
}