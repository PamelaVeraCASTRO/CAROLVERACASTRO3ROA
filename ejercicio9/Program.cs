using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("INGRESE UN NUMERO");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("el numero es incorrecto");
            }
            else
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine(num + "x" + i + "=" + num * i);
                }
        }
    }
}
