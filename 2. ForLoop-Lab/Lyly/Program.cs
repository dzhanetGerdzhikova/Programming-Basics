using System;

namespace Lyly
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washmashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int countToys = 0;
            int money = 0;
            int totalMoneyBirthday = 0;
            int moneyBrother = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    totalMoneyBirthday += money;//totalMoneyBirthday+money
                    moneyBrother++;
                }
                else
                {
                    countToys++;
                }
            }
            double moneyToys = toyPrice * countToys;
            double moneyTotal = (totalMoneyBirthday - moneyBrother) + moneyToys;

            if (moneyTotal >= washmashine)
            {
                Console.WriteLine($"Yes! {(moneyTotal - washmashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washmashine - moneyTotal):f2}");
            }
        }
    }
}