using System;

namespace WorldSnooker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string typeFinal = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int countTicket = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double photoPrice = 40;

            double price = 0;
            double totalSum = 0;
            double finalSum = 0;

            if (typeFinal == "Quarter final")
            {
                if (typeTicket == "Standard")
                {
                    price = 55.50;
                }
                else if (typeTicket == "Premium")
                {
                    price = 105.20;
                }
                else if (typeTicket == "VIP")
                {
                    price = 118.90;
                }
                totalSum = price * countTicket;
            }
            else if (typeFinal == "Semi final")
            {
                if (typeTicket == "Standard")
                {
                    price = 75.88;
                }
                else if (typeTicket == "Premium")
                {
                    price = 125.22;
                }
                else if (typeTicket == "VIP")
                {
                    price = 300.40;
                }
                totalSum = price * countTicket;
            }
            else if (typeFinal == "Final")
            {
                if (typeTicket == "Standard")
                {
                    price = 110.10;
                }
                else if (typeTicket == "Premium")
                {
                    price = 160.66;
                }
                else if (typeTicket == "VIP")
                {
                    price = 400;
                }
                totalSum = price * countTicket;
            }

            if (totalSum > 4000)
            {
                totalSum *= 0.75;
                photoPrice = 0;
                finalSum = totalSum + photoPrice;
                Console.WriteLine($"{finalSum:f2}");
            }
            else if (totalSum > 2500)
            {
                totalSum *= 0.90;
                if (photo == 'Y')
                {
                    finalSum = totalSum + (countTicket * 40);
                    Console.WriteLine($"{finalSum:f2}");
                }
                else
                {
                    finalSum = totalSum;
                    Console.WriteLine($"{finalSum:f2}");
                }
            }
            else
            {
                if (photo == 'Y')
                {
                    finalSum = totalSum + (countTicket * photoPrice);
                    Console.WriteLine($"{finalSum:f2}");
                }
                else
                {
                    Console.WriteLine($"{totalSum:f2}");
                }
            }
        }
    }
}