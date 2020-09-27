using System;

namespace FilmPremiere
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string typePacket = Console.ReadLine();
            int countTicket = int.Parse(Console.ReadLine());

            double price = 0;
            switch (name)
            {
                case "John Wick":
                    switch (typePacket)
                    {
                        case "Drink":
                            price = 12;
                            break;

                        case "Popcorn":
                            price = 15;
                            break;

                        case "Menu":
                            price = 19;
                            break;

                        default:
                            break;
                    }
                    break;

                case "Star Wars":
                    switch (typePacket)
                    {
                        case "Drink":
                            price = 18;
                            break;

                        case "Popcorn":
                            price = 25;
                            break;

                        case "Menu":
                            price = 30;
                            break;

                        default:
                            break;
                    }
                    if (countTicket >= 4)
                    {
                        price *= 0.7;
                    }
                    break;

                case "Jumanji":
                    switch (typePacket)
                    {
                        case "Drink":
                            price = 9;
                            break;

                        case "Popcorn":
                            price = 11;
                            break;

                        case "Menu":
                            price = 14;
                            break;

                        default:
                            break;
                    }
                    if (countTicket == 2)
                    {
                        price *= 0.85;
                    }
                    break;

                default:
                    break;
            }

            double totalPrice = price * countTicket;
            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}