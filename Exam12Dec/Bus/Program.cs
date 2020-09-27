using System;

namespace Bus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int countBusStation = int.Parse(Console.ReadLine());

            for (int countStationi = 1; countStationi <= countBusStation; countStationi++)
            {
                int downPeople = int.Parse(Console.ReadLine());
                int upPeople = int.Parse(Console.ReadLine());

                if (countStationi % 2 == 1)
                {
                    upPeople += 2;
                }
                else
                {
                    downPeople += 2;
                }

                countPeople -= downPeople;
                countPeople += upPeople;
            }
            Console.WriteLine($"The final number of passengers is : {countPeople}");
        }
    }
}