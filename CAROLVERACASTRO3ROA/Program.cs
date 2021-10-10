using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, num, mayor = 0;
            Console.Write("Dijite la cantidad de numero");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba un numero");
                num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = num;
                }
                else if (i != 0)
                {
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                }
            }
            Console.WriteLine("El numero mayor es" + mayor);
            Console.ReadKey();

        }
    }
}
