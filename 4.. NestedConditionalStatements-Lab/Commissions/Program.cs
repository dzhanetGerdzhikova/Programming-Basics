using System;

namespace Commissions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volumeSale = double.Parse(Console.ReadLine());
            double commissions = 0.00;

            if (town == "Sofia")
            {
                if (volumeSale >= 0 && volumeSale <= 500)
                {
                    commissions = 0.05;
                }
                else if (volumeSale > 500 && volumeSale <= 1000)
                {
                    commissions = 0.07;
                }
                else if (volumeSale > 1000 && volumeSale <= 10000)
                {
                    commissions = 0.08;
                }
                else if (volumeSale > 10000)
                {
                    commissions = 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (volumeSale >= 0 && volumeSale <= 500)
                {
                    commissions = 0.045;
                }
                else if (volumeSale > 500 && volumeSale <= 1000)
                {
                    commissions = 0.075;
                }
                else if (volumeSale > 1000 && volumeSale <= 10000)
                {
                    commissions = 0.1;
                }
                else if (volumeSale > 10000)
                {
                    commissions = 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (volumeSale >= 0 && volumeSale <= 500)
                {
                    commissions = 0.055;
                }
                else if (volumeSale > 500 && volumeSale <= 1000)
                {
                    commissions = 0.08;
                }
                else if (volumeSale > 1000 && volumeSale <= 10000)
                {
                    commissions = 0.12;
                }
                else if (volumeSale > 10000)
                {
                    commissions = 0.145;
                }
            }

            if ((town != "Sofia" && town != "Varna" && town != "Plovdiv") || volumeSale < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{(volumeSale * commissions):f2}");
            }
        }
    }
}