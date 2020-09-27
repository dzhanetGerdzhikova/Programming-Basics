using System;

namespace Cinema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0.00;
            switch (typeProjection)
            {
                case "Premiere":
                    price = 12.00;
                    break;

                case "Normal":
                    price = 7.50;
                    break;

                case "Discount":
                    price = 5.00;
                    break;
            }
            double totalPrice = (r * c) * price;
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}