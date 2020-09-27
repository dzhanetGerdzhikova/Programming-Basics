using System;

namespace Exam12Dec
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyFood = double.Parse(Console.ReadLine());
            double moneySouvenir = double.Parse(Console.ReadLine());
            double moneyHotelForDay = double.Parse(Console.ReadLine());

            double littersBenzin = (420.0 / 100) * 7;

            double moneyForBenzin = littersBenzin * 1.85;
            double moneyTotal = (3 * moneyFood) + (3 * moneySouvenir);
            double moneyHotelTotal = (moneyHotelForDay * 0.9) + (moneyHotelForDay * 0.85) + (moneyHotelForDay * 0.8);
            double total = moneyHotelTotal + moneyTotal + moneyForBenzin;
            Console.WriteLine($"Money needed: {total:f2}");
        }
    }
}
