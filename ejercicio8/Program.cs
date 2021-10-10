using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduzca un numero entero");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("el numero dijitado es incorrecto");
            }
            else
                Console.WriteLine("numeros del 1");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("numeros de 2 en 2");
            for (int i = 2; i <= num; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("numeros de 3 en 3");
            for (int i = 3; i <= num; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

