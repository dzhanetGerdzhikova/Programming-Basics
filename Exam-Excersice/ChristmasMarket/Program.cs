using System;

namespace ChristmasMarket
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int countFantasy = int.Parse(Console.ReadLine());
            int countHorror = int.Parse(Console.ReadLine());
            int countRomans = int.Parse(Console.ReadLine());

            double priceFantasy = 14.90;
            double priceHorror = 9.80;
            double priceRomans = 4.30;

            double sumAfterSale = countFantasy * priceFantasy + countHorror * priceHorror + countRomans * priceRomans;
            double sumAfterTax = sumAfterSale * 0.8;

            if (sumAfterTax > neededMoney)
            {
                double sellersMoney = Math.Floor((sumAfterTax - neededMoney) * 0.1);
                double moneyGift = (sumAfterTax - neededMoney) - sellersMoney;
                double totalMoney = moneyGift + neededMoney;
                Console.WriteLine($"{totalMoney:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {sellersMoney} leva.");
            }
            else
            {
                Console.WriteLine($"{neededMoney - sumAfterTax:f2} money needed.");
            }
        }
    }
}