using System;

namespace ejercico10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0, f, c = 0, factorial = 1, k;
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1)salir,2)sumatorio,3)factorial");
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("FIN DEL PROGRAMA");
            }
            else
                if (n == 2)
            {
                Console.WriteLine("ingrese el numero que desee sacar el sumatorio");
                f = int.Parse(Console.ReadLine());
                for (int i = 1; i <= f; i++)
                {
                    suma = suma + (2 * i + 1);
                    Console.WriteLine(suma);
                }
            }
            else
                if (n == 3)
            {
                Console.WriteLine("ingrese un numero");
                k = int.Parse(Console.ReadLine());
                for (int i = 1; i <= k; i++)
                {
                    c = c + 1;
                    factorial = factorial * c;
                    Console.WriteLine("EL FACTORIAL DE " + k + "es" + factorial);

                }
            }
        }
    }
}

