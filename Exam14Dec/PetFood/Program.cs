using System;

namespace PetFood
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double volumeFood = double.Parse(Console.ReadLine());

            int countDay = 0;

            double totalBiscuits = 0;
            double totalCatFood = 0;
            double totalDogFood = 0;

            double totalFood = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogEatFood = double.Parse(Console.ReadLine());
                double catEatFood = double.Parse(Console.ReadLine());
                countDay++;
                if (countDay % 3 == 0)
                {
                    double biscuits = 0.1 * (catEatFood + dogEatFood);
                    totalBiscuits += biscuits;
                }
                totalDogFood += dogEatFood;
                totalCatFood += catEatFood;
            }
            totalFood = totalCatFood + totalDogFood;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");
            Console.WriteLine($"{(totalFood / volumeFood) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(totalDogFood / totalFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(totalCatFood / totalFood) * 100:f2}% eaten from the cat.");
        }
    }
}