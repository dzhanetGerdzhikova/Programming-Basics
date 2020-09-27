using System;

namespace Coding
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string num = Console.ReadLine();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (int.Parse(num[i].ToString()) == 0)
                {
                    Console.Write("ZERO");
                }

                for (int k = 0; k < int.Parse(num[i].ToString()); k++)
                {
                    Console.Write((char)(int.Parse(num[i].ToString()) + 33));
                }
                Console.WriteLine("");
            }

            //int num = int.Parse(Console.ReadLine());

            //for (int symbol = num.ToString().Length - 1; symbol >= 0; symbol--)
            //{
            //    ////if (int.Parse(num.ToString()[symbol].ToString()) == 0)
            //    if (num.ToString()[symbol].ToString() == "0")
            //    {
            //        Console.Write("ZERO");
            //    }

            //    for (int numberCount = 1; numberCount <= int.Parse(num.ToString()[symbol].ToString()); numberCount++)
            //    {
            //        Console.Write((char)(int.Parse(num.ToString()[symbol].ToString()) + 33));

            //    }

            //    Console.WriteLine("");

            //    ////Console.WriteLine(num.ToString()[symbol]);
            //    ////Console.WriteLine(int.Parse(num.ToString()[symbol].ToString()));
            //}

            string number = Console.ReadLine();

            for (int symbol = number.Length - 1; symbol >= 0; symbol--)
            {
                if (number[symbol] == '0')
                {
                    Console.Write("ZERO");
                }

                for (int i = 0; i < int.Parse(number[symbol].ToString()); i++)
                {
                    Console.Write((char)(int.Parse(number[symbol].ToString()) + 33));
                }
                Console.WriteLine("");
            }
        }
    }
}