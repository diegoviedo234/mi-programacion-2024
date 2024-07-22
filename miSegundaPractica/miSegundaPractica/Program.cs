    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace miSegundaPractica
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            // Desarrolle un programa que solicite un número entre 1 y 10 y muestre su respectiva tabla de multiplicar, que continué hasta que el uario ingrese 0 para salir.
            int numero; 

            while (true)
            {

                Console.Write("Introduzca un número entre 1 y 10 (Si desea salir, introduzca 0): ");
                numero =  int.Parse(Console.ReadLine());
                

                if (numero == 0)
                {
                    break;
                }

                if (numero < 1 || numero > 10)
                {

                    Console.WriteLine("El número que pusiste no esta en el rango. El rango esta entre 1 y 10.");
                    continue;

                }

                Console.WriteLine($"Tabla de multiplicar del {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i}  = {numero * i}");
                }

                Console.WriteLine();

            }

            Console.WriteLine("Programación terminando.");


        }
    }
}
