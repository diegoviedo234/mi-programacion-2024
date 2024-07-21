using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desarrolle un programa que muestre si cada número que se teclea es positivo o negativo, y que se detenga cuando al teclear el número 0
            

            int numero;

            while (true)
            {
                Console.Write("Introduzca un número (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;

                }

                if (numero > 0)
                {
                    Console.WriteLine("El numero es positivo. ");
                }
                else
                {
                    Console.WriteLine("El número es negativo. ");
                }
                Console.WriteLine("Programa terminado. ");
            }
        }
    }
}

