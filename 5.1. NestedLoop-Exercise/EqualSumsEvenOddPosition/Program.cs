using System;

namespace EqualSumsEvenOddPosition
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int num = startNum; num <= lastNum; num++)
            {
                string text = num.ToString();

                for (int j = 0; j < text.Length; j++)//num.ToString().Lеngth
                {
                    int text1 = int.Parse(text[j].ToString());

                    if (j % 2 == 0)
                    {
                        sumEven += text1;
                    }
                    else
                    {
                        sumOdd += text1;
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(num + " ");
                }
                sumEven = 0;
                sumOdd = 0;
            }

            //int startNum = int.Parse(Console.ReadLine());
            //int endNum = int.Parse(Console.ReadLine());
            //int sumEven = 0;
            //int sumOdd = 0;

            //for (int num = startNum; num <= endNum; num++)
            //{
            //    for (int symbol = 0; symbol < num.ToString().Length; symbol++)
            //    {
            //        if (symbol % 2 == 0)
            //        {
            //            sumEven += int.Parse(num.ToString()[symbol].ToString());
            //        }
            //        else
            //        {
            //            sumOdd += int.Parse(num.ToString()[symbol].ToString());
            //        }
            //    }
            //    if (sumOdd == sumEven)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    sumEven = 0;
            //    sumOdd = 0;
            //}
        }
    }
}