using System;

    namespace Ejercicio3
    {
        class Program
        {
            static void Main(string[] args)
            {
                int cant;
                double precio = 0, total;
                Console.WriteLine("Introduzca la cantidad vendida");
                cant = int.Parse(Console.ReadLine());
                if (cant < 0)
                {
                    Console.WriteLine("EL NUMERO INGRESADO ES INCORRECTO");
                }
                else
                {
                    Console.WriteLine("Intoduzca el precio");
                    precio = double.Parse(Console.ReadLine());
                    total = (precio * cant);
                    Console.WriteLine("el costo total es:" + total);
                }

            }
        }
    }

