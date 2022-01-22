using System;

namespace ConsoleApp.Ededin4eBolunmesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 22;

            int b = a % 4;

            if (b == 0)
            {
                Console.WriteLine($"{a} Ededi 4-e bolunur");
            }
            else
            {
                Console.WriteLine($"{a} Ededi 4-e bolunmur");
            }
        }
    }
}
