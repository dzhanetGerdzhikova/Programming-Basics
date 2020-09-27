using System;

namespace WhileInvalidNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 0;
            while (number < n)
            {
                number = 2 * number + 1;
                if (number <= n)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
