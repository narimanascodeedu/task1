using System;

namespace ConsoleApp._50_yeQeder3_e5_eBolunenEdedler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 || i % 5 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
