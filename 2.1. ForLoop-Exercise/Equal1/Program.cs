using System;

namespace Equal1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                sum1 = number1 + number2;

                int number3 = int.Parse(Console.ReadLine());
                int number4 = int.Parse(Console.ReadLine());
                sum2 = number3 + number4;

                if(sum1==sum2)

            }
                
        }
    }
}
