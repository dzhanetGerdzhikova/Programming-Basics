using System;

namespace Vacation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            int day = 0;
            int daySpend = 0;
            double savedOrSpend = 0;

            while (moneyHave < moneyNeeded)
            {
                string type = Console.ReadLine();
                savedOrSpend = double.Parse(Console.ReadLine());
                day++;
                if (type == "spend")
                {
                    daySpend++;
                    if (savedOrSpend >= moneyHave)
                    {
                        moneyHave = 0;
                    }
                    else
                    {
                        moneyHave -= savedOrSpend;
                    }
                    if (daySpend >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{day}");
                        break;
                    }
                }
                else if (type == "save")
                {
                    daySpend = 0;
                    moneyHave += savedOrSpend;
                }
            }

            if (moneyHave >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {day} days.");
            }
        }
    }
}