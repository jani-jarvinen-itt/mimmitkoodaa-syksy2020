using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku 1:");
            string luku1 = Console.ReadLine();

            Console.WriteLine("Anna luku 2:");
            string luku2 = Console.ReadLine();

            int summa = int.Parse(luku1) + int.Parse(luku2);
            Console.WriteLine("Summa on: " + summa); 
        }
    }
}
