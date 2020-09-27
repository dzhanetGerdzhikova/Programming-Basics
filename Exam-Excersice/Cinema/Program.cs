using System;

namespace Cinema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalPlaces = int.Parse(Console.ReadLine());

            string peopleGroup = Console.ReadLine();

            //int group = 0;
            int sumPeople = 0;

            double totalPriceGroup = 0;
            double totalSum = 0;

            while (peopleGroup != "Movie time!")
            {
                int personGroup = int.Parse(peopleGroup);
                //group += personGroup;
                sumPeople += personGroup;
                totalPriceGroup = personGroup * 5;
                if (personGroup % 3 == 0)
                {
                    totalPriceGroup -= 5;
                }

                if (sumPeople > totalPlaces)
                {
                    break;
                }
                totalSum += totalPriceGroup;
                //group = 0;
                peopleGroup = Console.ReadLine();
            }

            if (sumPeople > totalPlaces)
            {
                Console.WriteLine("The cinema is full.");
            }
            else /*if (sumPeple <= totalPlaces) не ти трябва*/
            {
                Console.WriteLine($"There are {totalPlaces - sumPeople} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {totalSum} lv."); // <--- Тук ще изкараш цена без тази сметната от А) вкъщи ще я дискутираме :*
        }
    }
}