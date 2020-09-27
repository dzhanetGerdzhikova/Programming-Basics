using System;

namespace SumPrimeNonPrime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumProsti = 0;
            int sumNeProsti = 0;
            int countNeprosti = 0;

            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    num = 0;
                }

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        countNeprosti++;
                        break;
                    }
                }
                if (countNeprosti > 0)
                {
                    sumNeProsti += num;
                }
                else
                {
                    sumProsti += num;
                }

                countNeprosti = 0;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumProsti}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNeProsti}");

            //string num = Console.ReadLine();

            //int sumPrime = 0;
            //int sumNonPrime = 0;

            //while (num != "stop")
            //{
            //    if (int.Parse(num) < 0)
            //    {
            //        Console.WriteLine("Number is negative.");
            //        num = "0";
            //    }

            //    bool isDivided = false;

            //    for (int i = 2; i < int.Parse(num); i++)
            //    {
            //        if (int.Parse(num) % i == 0)
            //        {
            //            isDivided = true;
            //            break;
            //        }

            //    }
            //    if (isDivided)
            //    {
            //        sumNonPrime += int.Parse(num);
            //    }
            //    else
            //    {
            //        sumPrime += int.Parse(num);
            //    }

            //    num = Console.ReadLine();
            //}
            //Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            //Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}