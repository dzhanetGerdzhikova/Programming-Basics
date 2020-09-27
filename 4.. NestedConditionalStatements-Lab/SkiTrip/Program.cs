using System;

namespace SkiTrip
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double discount = 0.00;
            double priceForNight = 0.00;

            if (roomType == "room for one person")
            {
                priceForNight = 18.00;
            }
            else if (roomType == "apartment")
            {
                priceForNight = 25.00;
                if (days < 10)
                {
                    discount = 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                }
                else
                {
                    discount = 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                priceForNight = 35.00;
                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.20;
                }
            }
            int nights = days - 1;
            double totalPrice = (nights * priceForNight) * (1 - discount);

            if (feedback == "positive")
            {
                Console.WriteLine($"{(totalPrice * (1 + 0.25)):f2}");
            }
            else
            {
                Console.WriteLine($"{(totalPrice * (1 - 0.1)):f2}");
            }
        }
    }
}