using System;

namespace Salary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countTab = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int sumWeb = 1; sumWeb <= countTab; sumWeb++)
            {
                string nameWebSite = Console.ReadLine();
                if (nameWebSite == "Facebook")
                {
                    salary -= 150;
                }
                else if (nameWebSite == "Instagram")
                {
                    salary -= 100;
                }
                else if (nameWebSite == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                else if (sumWeb == countTab)
                {
                    Console.WriteLine(salary);
                }
            }
        }
    }
}