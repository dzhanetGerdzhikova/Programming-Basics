using System;

namespace ChristmasMarket
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string typeProduct = Console.ReadLine();

            double price = 0;
            int totalProduct = 0;
            //double spentMoney = 0;
            double totalSpent = 0;

            while (typeProduct != "Finish")
            {
                switch (typeProduct)
                {
                    case "Star":
                        price = 5.69;
                        break;

                    case "Angel":
                        price = 8.49;
                        break;

                    case "Lights":
                        price = 11.20;
                        break;

                    case "Wreath":
                        price = 15.50;
                        break;

                    case "Candle":
                        price = 3.59;
                        break;

                    default:
                        break;
                }

                if (totalProduct % 3 == 0)
                {
                    price *= 0.7;
                }
                //spentMoney += price;
                //totalSpent += spentMoney;
                totalSpent += price;

                //if (spentMoney>budget)
                if (price > budget)
                {
                    break;
                }

                budget -= price;
                totalProduct++;
                //spentMoney = 0;
                price = 0;
                typeProduct = Console.ReadLine();
            }

            //if (spentMoney > budget)
            if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2}lv more.");
                Console.WriteLine($"{totalProduct} items -> {totalSpent - price:f2}lv spent.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You bought everything!");
                Console.WriteLine($"{totalProduct} items -> {totalSpent:f2}lv spent.");
            }
        }
    }
}