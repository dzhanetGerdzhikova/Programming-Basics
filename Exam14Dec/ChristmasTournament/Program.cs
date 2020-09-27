using System;

namespace ChristmasTournament
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            double winMoneyOnDay = 0;
            double totalWin = 0;
            int countWinDay = 0;
            int countLoseDay = 0;
            int allWin = 0;
            int allLose = 0;

            for (int i = 1; i <= totalDays; i++)
            {
                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string winOrlose = Console.ReadLine();

                    if (winOrlose == "win")
                    {
                        winMoneyOnDay += 20;
                        countWinDay++;
                    }
                    else if (winOrlose == "lose")
                    {
                        countLoseDay++;
                    }

                    sport = Console.ReadLine();
                }

                if (countWinDay > countLoseDay)
                {
                    winMoneyOnDay *= 1.1;
                }
                allWin += countWinDay;
                allLose += countLoseDay;
                totalWin += winMoneyOnDay;
                winMoneyOnDay = 0;
                countWinDay = 0;
                countLoseDay = 0;
            }

            if (allWin > allLose)
            {
                totalWin *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalWin:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalWin:f2}");
            }
        }
    }
}