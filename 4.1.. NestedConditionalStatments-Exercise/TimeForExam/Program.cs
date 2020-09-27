using System;

namespace TimeForExam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int hourExam = int.Parse(Console.ReadLine());
            //int minutesExam = int.Parse(Console.ReadLine());
            //int hourArrived = int.Parse(Console.ReadLine());
            //int minutesArrived = int.Parse(Console.ReadLine());

            //int hoursDifference = Math.Abs(hourExam - hourArrived);
            //int minutesDifference = minutesExam - minutesArrived;

            //if (hourArrived > hourExam + 1)
            //{
            //    if (minutesDifference > 0)
            //    {
            //        minutesDifference = minutesExam + minutesArrived;
            //    }

            //    Console.WriteLine("Late");
            //    Console.WriteLine($"{hoursDifference}:{Math.Abs(minutesDifference):d2} hours after the start");
            //}
            //else if (hourArrived == hourExam + 1)
            //{
            //    if (minutesDifference > 0)
            //    {
            //        minutesDifference = minutesExam + minutesArrived;
            //        Console.WriteLine("Late");
            //        Console.WriteLine($"{Math.Abs(minutesDifference)} minutes after the start");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Late");
            //        Console.WriteLine($"{hoursDifference}:{Math.Abs(minutesDifference):d2} hours after the start");
            //    }

            //}
            //else if (hourArrived == hourExam)
            //{
            //    if (minutesDifference >= 0 && minutesDifference <= 30)
            //    {
            //        Console.WriteLine("On time");
            //        if (minutesDifference != 0)
            //        {
            //            Console.WriteLine($"{minutesDifference} minutes before the start");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Late");
            //        Console.WriteLine($"{Math.Abs(minutesDifference)} minutes after the start");
            //    }
            //}
            //else if (hourArrived + 1 == hourExam && minutesDifference < 0)
            //{
            //    minutesDifference += 60;

            //    if (minutesDifference <= 30)
            //    {
            //        Console.WriteLine("On time");
            //        Console.WriteLine($"{minutesDifference} minutes before the start");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Early");
            //        Console.WriteLine($"{Math.Abs(minutesDifference)} minutes before the start");
            //    }
            //}
            //else
            //{
            //    if (minutesDifference < 0)
            //    {
            //        minutesDifference += 60;
            //    }
            //    Console.WriteLine("Early");
            //    Console.WriteLine($"{hoursDifference}:{minutesDifference:d2} hours before the start");
            //}

            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minArrived = int.Parse(Console.ReadLine());

            int totalMinsArrive = hourArrived * 60 + minArrived;
            int totalMinsExam = hourExam * 60 + minExam;

            int totalDifference = Math.Abs(totalMinsArrive - totalMinsExam);

            if (totalMinsArrive > totalMinsExam)
            {
                Console.WriteLine("Late");
                if (totalDifference >= 60)
                {
                    Console.WriteLine($"{totalDifference / 60}:{(totalDifference % 60):d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{totalDifference} minutes after the start");
                }
            }
            else if (totalMinsArrive == totalMinsExam)
            {
                Console.WriteLine("On time");
            }
            else if (totalDifference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{totalDifference} minutes before the start");
            }
            else if (totalDifference > 30 && totalDifference < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{totalDifference} minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{totalDifference / 60}:{totalDifference % 60:d2} hours before the start");
            }
        }
    }
}