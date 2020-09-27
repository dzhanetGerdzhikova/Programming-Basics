using System;

namespace New
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int limitFirstNum = int.Parse(Console.ReadLine());
            int limitSecondtNum = int.Parse(Console.ReadLine());
            int limitThirdNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limitFirstNum; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j <= limitSecondtNum; j++)
                    {
                        int divisionCounter = 0;
                        for (int num = 2; num < j; num++)
                        {
                            if (j % num == 0)
                            {
                                divisionCounter++;
                                break;
                            }
                        }

                        if (divisionCounter == 0)
                        {
                            for (int k = 1; k <= limitThirdNum; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i}{j}{k}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}