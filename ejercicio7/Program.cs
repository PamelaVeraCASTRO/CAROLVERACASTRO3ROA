using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("COLUMNA DEL 1-100");
            for (i = 1; i <= 100; i++)
            {
                if (i % 1 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("COLUMNA DEL 100-1");
            for (i = 100; i >= 1; i = i - 1)
            {
                if (i % 1 == 0)
                    Console.WriteLine(i);
            }

        }
    }
}





