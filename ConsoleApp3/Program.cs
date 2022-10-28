using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int a = Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                int b = a % 10;
                a = a / 10;
                if (b == 3)
                {
                    Console.WriteLine("Broj sadrzi broj 3.");
                    break;
                }
                else if (a == 0)
                {
                    Console.WriteLine("Broj ne sadrzi broj 3.");
                }
            }
        }
    }
}
