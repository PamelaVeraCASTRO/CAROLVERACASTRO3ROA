using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Por favor ingrese el tamaño del cuadrado:");
            n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= 50)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("*");
                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}

