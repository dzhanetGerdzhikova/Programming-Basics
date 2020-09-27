using System;

namespace FruitShop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.00;

            if (fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            break;

                        case "apple":
                            price = 1.20;
                            break;

                        case "orange":
                            price = 0.85;
                            break;

                        case "grapefruit":
                            price = 1.45;
                            break;

                        case "kiwi":
                            price = 2.70;
                            break;

                        case "pineapple":
                            price = 5.50;
                            break;

                        case "grapes":
                            price = 3.85;
                            break;
                    }
                }
                else if (day == "Saturday" || day == "Sunday")
                {
                    if (fruit == "banana")
                    {
                        price = 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.90;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 4.20;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (price != 0)
            {
                double totalPrice = quantity * price;
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}