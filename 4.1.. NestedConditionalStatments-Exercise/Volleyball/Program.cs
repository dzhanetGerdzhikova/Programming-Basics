using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());//praznici
            int h = int.Parse(Console.ReadLine());//weekends roden grad

            int weekendInSofia = 48 - h;
            double gameSatyrdaySofia = (double)weekendInSofia * 3 / 4;
            int gameInBornTown = h;
            double gameInSofia = (double)p * 2 / 3;
            double totalGame = gameSatyrdaySofia + gameInBornTown + gameInSofia;

            if (typeYear == "leap")
            {
                totalGame *= (1 + 0.15);
            }
            Console.WriteLine(Math.Floor(totalGame));
        }

    }
}
