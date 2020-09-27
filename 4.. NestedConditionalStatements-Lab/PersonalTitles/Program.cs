using System;

namespace PersonalTitles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            /*
            if(age >= 16 && gender == 'm')
            {
                Console.WriteLine("Mr.");
            }
            else if (age >= 16 && gender == 'f')
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && gender == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (age < 16 && gender == 'f')
            {
                Console.WriteLine("Miss");
            }
            */

            if (age >= 16)
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender == 'f')
                {
                    Console.WriteLine("Ms.");
                }
            }
            else /* if (age < 16) */
            {
                if (gender == 'm')
                {
                    Console.WriteLine("Master");
                }
                else if (gender == 'f')
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}