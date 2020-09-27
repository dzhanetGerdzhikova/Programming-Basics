using System;

namespace CinemaTickets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string cinemaName = Console.ReadLine();
            int countStudent = 0;
            int countKids = 0;
            int countNormal = 0;
            int totalTickets = 0;

            while (cinemaName != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                int cinemaTickets = 0;

                while (typeOfTicket.ToUpper() != "END")
                {
                    cinemaTickets++;
                    switch (typeOfTicket)
                    {
                        case "student":
                            countStudent++;
                            break;

                        case "kid":
                            countKids++;
                            break;

                        case "standard":
                            countNormal++;
                            break;

                        default:
                            break;
                    }
                    if (cinemaTickets >= freePlaces)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                Console.WriteLine($"{cinemaName} - {(double)cinemaTickets / freePlaces * 100:f2}% full.");
                totalTickets += cinemaTickets;
                cinemaName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)countStudent / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)countNormal / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)countKids / totalTickets * 100:f2}% kids tickets.");
        }
    }
}