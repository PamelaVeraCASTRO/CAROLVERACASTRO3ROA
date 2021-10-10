using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("INGRESE UN NUMERO:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                for (int d = n; d < i; d++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

