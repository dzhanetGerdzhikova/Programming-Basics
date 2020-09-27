using System;

namespace WeddingParty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double moneyFromGuests = countGuests * 20;

            if (budget < moneyFromGuests)
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(moneyFromGuests - budget)} lv more.");
            }
            else if (budget >= moneyFromGuests)
            {
                double moneyFireworks = 0.4 * (budget - moneyFromGuests);
                double moneyDonation = (budget - moneyFromGuests) - moneyFireworks;
                Console.WriteLine($"Yes! {Math.Round(moneyFireworks)} lv are for fireworks and {Math.Round(moneyDonation)} lv are for donation.");
            }
        }
    }
}