using System;
namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario, horas, total, sumatotal, horasextr, sumaex, normal, pago, n, CUENTA;
            do
            {

                Console.WriteLine("Ingrese la cantidad de horas trabajadas a la semana");
                horas = int.Parse(Console.ReadLine());
                if (horas < 35)
                {
                    total = horas * 15;
                    Console.WriteLine("El valor a pagar es de:" + total);
                }
                else
                {

                    horasextr = horas - 35;
                    sumaex = horasextr * 22;
                    normal = (horas * 15) - (sumaex);
                    pago = sumaex + normal;
                    Console.WriteLine("El valor a pagar es de:" + pago);
                }
                Console.WriteLine("desea ingresar otro salario");
                Console.WriteLine("n=1 -si      n=2 -no");
                n = int.Parse(Console.ReadLine());
            } while (n == 1);

        }

    }
}



