using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTicket = int.Parse(Console.ReadLine());
            string number = "";

            for (int i = 1; i <= countTicket; i++)
            {
                string ticket = Console.ReadLine();

                if (ticket.Length == 4)
                {
                    if (ticket[0] >= 65 && ticket[0] <= 90)
                    {
                        number = $"Seat decoded: {ticket[0]}{ticket[1]}{ticket[2]}";
                    }
                    else if (ticket[0] < 65 || ticket[0] > 90)
                    {
                        number = $"Seat decoded: {ticket[3]}{ticket[1]}{ticket[2]}";
                    }

                }
                else if (ticket.Length == 5 || ticket.Length == 6)
                {
                    number = $"Seat decoded: {ticket[0]}{(int)ticket[1]}";
                }
                //debug

                Console.WriteLine(number);
            }

//            string name = Console.ReadLine();
//            int countGame = int.Parse(Console.ReadLine());

//            double pointsVolleyball = 0; 
//            double pointsTennis = 0; 
//            double pointsBadminton = 0; 

//            int countVolleyball = 0;
//            int countTennis = 0;
//            int countBadminton = 0;

//            for (int games = 1; games <= countGame; games++)
//            {
//                string nameGame = Console.ReadLine();
//                int points = int.Parse(Console.ReadLine());

//                if(nameGame=="volleyball")
//                {
//                    pointsVolleyball +=points*1.07;
//                    countVolleyball++;
//                }
//                else if(nameGame=="tennis")
//                {
//                    pointsTennis += points * 1.05;
//                    countTennis++;
//                }
//                else if(nameGame=="badminton")
//                {
//                    pointsBadminton +=points * 1.02;
//                    countBadminton++;
//                }
//            }

//            double averageVolleyballPoints =Math.Floor (pointsVolleyball / countVolleyball);
//            double averageTennisPoints =Math.Floor ( pointsTennis/ countTennis);
//            double averageBadmintonPoints =Math.Floor ( pointsBadminton/ countBadminton);

//           if(averageVolleyballPoints>=75 && averageTennisPoints>=75 && averageBadmintonPoints>=75)
//            {
//                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {Math.Floor(pointsVolleyball+pointsTennis+pointsBadminton)} points.");
//            }
//           else
//            {
//                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {Math.Floor(pointsVolleyball+pointsTennis+pointsBadminton)}."
//);
//            }
        }
    }
}
