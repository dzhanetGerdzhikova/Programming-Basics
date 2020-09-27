using System;

namespace RoomHotel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double studioPrice = 0.00;
            double apartmentPrice = 0.00;
            double discountStudio = 0.00;
            double discountApartment = 0.00;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                if (night > 7 && night < 14)
                {
                    discountStudio = 0.05;
                }
                else if (night > 14)
                {
                    discountStudio = 0.3;
                }
                apartmentPrice = 65;
                if (night > 14)
                {
                    discountApartment = 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                if (night > 14)
                {
                    discountStudio = 0.2;
                }
                apartmentPrice = 68.70;
                if (night > 14)
                {
                    discountApartment = 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (night > 14)
                {
                    discountApartment = 0.1;
                }
            }

            double studioSum = (night * studioPrice) * (1 - discountStudio);
            double apartmentSum = (night * apartmentPrice) * (1 - discountApartment);

            Console.WriteLine($"Apartment: {apartmentSum:f2} lv.");
            Console.WriteLine($"Studio: {studioSum:f2} lv.");
        }
    }
}