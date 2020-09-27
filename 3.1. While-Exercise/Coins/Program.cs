using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countMoney = 0;
            double coin = 2.0;

            while (money > 0)
            {
                countMoney += (int)(money / coin);
                money = Math.Round(money % coin, 2);
                if (coin == 0.5)
                {
                    coin = 0.2;
                }
                else if (coin == 0.05)
                {
                    coin = 0.02;
                }
                else
                {
                    coin /= 2.0;
                }
            }

            Console.WriteLine(countMoney);
        }

    }
}
