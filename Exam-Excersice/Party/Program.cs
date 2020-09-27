using System;

namespace Party
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double sumSinger = double.Parse(Console.ReadLine());

            string countPeople = Console.ReadLine();

            double allGuests = 0;
            double priceDinner = 0;
            double totalPrice = 0;

            while (countPeople != "The restaurant is full")
            {
                int countPerson = int.Parse(countPeople);
                allGuests += countPerson;

                if (countPerson < 5)
                {
                    priceDinner = 100;
                }
                else if (countPerson >= 5)
                {
                    priceDinner = 70;
                }
                totalPrice += priceDinner * countPerson;

                countPeople = Console.ReadLine();
            }

            if (totalPrice >= sumSinger)
            {
                Console.WriteLine($"You have {allGuests} guests and {totalPrice - sumSinger} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {allGuests} guests and {totalPrice} leva income, but no singer.");
            }
        }
    }
}
}