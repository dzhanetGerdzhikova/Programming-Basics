using System;

namespace Жоллеъбалл
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2; // (num1+0.0)/num2
                }
            }
            else if (operation == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                }
            }

            if ((operation == '+' || operation == '-' || operation == '*') && result % 2 == 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
            }
            else if (operation == '+' || operation == '-' || operation == '*' && result % 2 != 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
            }
            else if (operation == '/' && num2 != 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
            }
            else if (operation == '%' && num2 != 0)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
        }
    }
}