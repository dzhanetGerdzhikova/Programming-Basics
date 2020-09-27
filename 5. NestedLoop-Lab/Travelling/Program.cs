using System;

namespace Travelling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double totalMoney = 0;
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (totalMoney < minBudget)
                {
                    double moneySaved = double.Parse(Console.ReadLine());
                    totalMoney += moneySaved;
                }
                Console.WriteLine($"Going to {destination}!");
                totalMoney = 0;
                destination = Console.ReadLine();
            }
        }
    }
}