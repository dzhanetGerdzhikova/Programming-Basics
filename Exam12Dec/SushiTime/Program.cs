using System;

namespace SushiTime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string typeSushi = Console.ReadLine();
            string nameRestaurant = Console.ReadLine();
            int countPorcii = int.Parse(Console.ReadLine());
            char dellivery = char.Parse(Console.ReadLine());

            double price = 0;

            switch (typeSushi)
            {
                case "sashimi":
                    switch (nameRestaurant)
                    {
                        case "Sushi Zone":
                            price = 4.99;
                            break;

                        case "Sushi Time":
                            price = 5.49;
                            break;

                        case "Sushi Bar":
                            price = 5.25;
                            break;

                        case "Asian Pub":
                            price = 4.50;
                            break;

                        default:
                            Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
                            break;
                    }
                    break;

                case "maki":
                    switch (nameRestaurant)
                    {
                        case "Sushi Zone":
                            price = 5.29;
                            break;

                        case "Sushi Time":
                            price = 4.69;
                            break;

                        case "Sushi Bar":
                            price = 5.55;
                            break;

                        case "Asian Pub":
                            price = 4.80;
                            break;

                        default:
                            Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
                            break;
                    }
                    break;

                case "uramaki":
                    switch (nameRestaurant)
                    {
                        case "Sushi Zone":
                            price = 5.99;
                            break;

                        case "Sushi Time":
                            price = 4.49;
                            break;

                        case "Sushi Bar":
                            price = 6.25;
                            break;

                        case "Asian Pub":
                            price = 5.50;
                            break;

                        default:
                            Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
                            break;
                    }
                    break;

                case "temaki":
                    switch (nameRestaurant)
                    {
                        case "Sushi Zone":
                            price = 4.29;
                            break;

                        case "Sushi Time":
                            price = 5.19;
                            break;

                        case "Sushi Bar":
                            price = 4.75;
                            break;

                        case "Asian Pub":
                            price = 5.50;
                            break;

                        default:
                            Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
                            break;
                    }
                    break;

                default:
                    break;
            }
            if (dellivery == 'Y')
            {
                price *= 1.20;
            }

            if (price > 0)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(countPorcii * price)} lv.");
            }
        }
    }
}