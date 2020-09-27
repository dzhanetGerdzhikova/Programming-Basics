using System;

namespace Party
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double moneySinger = double.Parse(Console.ReadLine());
            string guestInGroup = Console.ReadLine();

            double priceGroup = 0;
            double totalPriceGroup = 0;
            double countGuests = 0;
            while (guestInGroup != "The restaurant is full")
            {
                int peopleInGroup = int.Parse(guestInGroup);
                if (peopleInGroup < 5)
                {
                    priceGroup = peopleInGroup * 100;
                }
                else if (peopleInGroup >= 5)
                {
                    priceGroup = peopleInGroup * 70;
                }
                totalPriceGroup += priceGroup;
                countGuests += peopleInGroup;

                guestInGroup = Console.ReadLine();
            }
            if (totalPriceGroup >= moneySinger)
            {
                Console.WriteLine($"You have {countGuests} guests and {totalPriceGroup - moneySinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {countGuests} guests and {totalPriceGroup} leva income, but no singer.");
            }
        }
    }
}