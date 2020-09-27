using System;

namespace Decoration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string nameDrink = Console.ReadLine();
            string shugar = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            double price = 0;

            switch (nameDrink)
            {
                case "Espresso":
                    switch (shugar)
                    {
                        case "Without":
                            price = 0.9 * 0.65;
                            break;

                        case "Normal":
                            price = 1;
                            break;

                        case "Extra":
                            price = 1.20;
                            break;

                        default:
                            break;
                    }
                    if (countDrinks > 5)
                    {
                        price *= 0.75;
                    }
                    break;

                case "Cappuccino":
                    switch (shugar)
                    {
                        case "Without":
                            price = 0.65;
                            break;

                        case "Normal":
                            price = 1.20;
                            break;

                        case "Extra":
                            price = 1.60;
                            break;

                        default:
                            break;
                    }
                    break;

                case "Tea":
                    switch (shugar)
                    {
                        case "Without":
                            price = 0.50 * 0.65;
                            break;

                        case "Normal":
                            price = 0.60;
                            break;

                        case "Extra":
                            price = 0.70;
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            if (countDrinks * price > 15)
            {
                Console.WriteLine($"You bought {countDrinks} cups of {nameDrink} for {(countDrinks * price) * 0.8:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You bought {countDrinks} cups of {nameDrink} for {(countDrinks * price):f2} lv.");
            }
        }
    }
}