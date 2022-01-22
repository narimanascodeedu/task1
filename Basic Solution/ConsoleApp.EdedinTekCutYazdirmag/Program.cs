using System;

namespace ConsoleApp.EdedinTekCutYazdirmag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 73;
            
            int b = a % 2;

            if (b == 0)
            {
                Console.WriteLine($"{a} Ededi Cutdur");
            }
            else
            {
                Console.WriteLine($"{a} Ededi Tekdir");
            }

        }
    }
}
