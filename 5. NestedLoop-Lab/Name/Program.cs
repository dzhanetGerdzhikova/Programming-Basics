using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            while(name!="stop")
            {
                for(int i=0;i<name.Length;i++)
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
    }
}
