using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, lado;
            Console.WriteLine("Ingresar el lado del rombo");
            lado = int.Parse(Console.ReadLine());
            for (x = 0; x <= lado; x++)
            {

                for (y = lado - x; y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (y = 0; y < x; y++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            for (x = 0; x <= lado; x++)
            {
                for (y = 0; y <= x; y++)
                {
                    Console.Write(" ");
                }
                for (y = lado - x - 1; y > 0; y--)
                {
                    Console.Write(" *");

                }
                Console.WriteLine(" ");
            }
        }
    }
}


