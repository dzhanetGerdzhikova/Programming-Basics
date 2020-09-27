using System;

namespace NewHouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string typFlowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.00;
            double discount = 0.00;

            if (typFlowers == "Roses")
            {
                price = 5;
                if (flowersCount > 80)
                {
                    discount = 0.1;
                }
            }
            else if (typFlowers == "Dahlias")
            {
                price = 3.80;
                if (flowersCount > 90)
                {
                    discount = 0.15;
                }
            }
            else if (typFlowers == "Tulips")
            {
                price = 2.80;
                if (flowersCount > 80)
                {
                    discount = 0.15;
                }
            }
            else if (typFlowers == "Narcissus")
            {
                price = 3;
                if (flowersCount < 120)
                {
                    price *= 1.15;
                }
            }
            else if (typFlowers == "Gladiolus")
            {
                price = 2.50;
                if (flowersCount < 80)
                {
                    price *= 1.20;
                }
            }
            double totalSum = (flowersCount * price) * (1 - discount);

            if (budget > totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typFlowers} and {(budget - totalSum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):f2} leva more.");
            }
        }
    }
}