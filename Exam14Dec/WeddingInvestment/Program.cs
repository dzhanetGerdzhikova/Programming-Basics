using System;

namespace WeddingInvestment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string timeContract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string desssert = Console.ReadLine();
            int countMonthForPay = int.Parse(Console.ReadLine());

            double price = 0;

            switch (timeContract)
            {
                case "one":
                    switch (typeContract)
                    {
                        case "Small":
                            price = 9.98;
                            break;

                        case "Middle":
                            price = 18.99;
                            break;

                        case "Large":
                            price = 25.98;
                            break;

                        case "ExtraLarge":
                            price = 35.99;
                            break;

                        default:
                            break;
                    }
                    break;

                case "two":
                    switch (typeContract)
                    {
                        case "Small":
                            price = 8.58;
                            break;

                        case "Middle":
                            price = 17.09;
                            break;

                        case "Large":
                            price = 23.59;
                            break;

                        case "ExtraLarge":
                            price = 31.79;
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            switch (desssert)
            {
                case "yes":
                    if (price <= 10)
                    {
                        price += 5.50;
                    }
                    else if (price <= 30)
                    {
                        price += 4.35;
                    }
                    else
                    {
                        price += 3.85;
                    }
                    break;

                default:
                    break;
            }

            double totalPrice = countMonthForPay * price;

            if (timeContract == "two")
            {
                totalPrice = totalPrice - (totalPrice * 0.0375);
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}