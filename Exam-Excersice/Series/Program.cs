using System;

namespace Series
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSerials = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= countSerials; i++)
            {
                //Това ли ?
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (name == "Thrones")
                {
                    price *= 0.5;
                }
                else if (name == "Lucifer")
                {
                    price *= 0.6;
                }
                else if (name == "Protector")
                {
                    price *= 0.7;
                }
                else if (name == "TotalDrama")
                {
                    price *= 0.8;
                }
                else if (name == "Area")
                {
                    price *= 0.9;
                }

                totalPrice += price;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {budget - totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalPrice - budget:f2} lv. more to buy the series!");
            }
        }
    }
}