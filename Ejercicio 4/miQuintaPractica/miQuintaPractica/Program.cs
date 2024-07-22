using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miQuintaPractica
{
    internal class Program
    {
        static void Main()
        {
            // Desarrolle un programa que pida una serie de números y al finalizar que calcule el promedio de dichos números (0 para finalizar)
            double suma = 0;
            int cantidad = 0;
            int limite;

            
            Console.Write("Ingrese el límite de números: ");
            while (!int.TryParse(Console.ReadLine(), out limite) || limite <= 0)
            {
                Console.Write("Entrada no válida. Por favor, ingrese un número entero positivo para el límite: ");
            }

            
            while (cantidad < limite)
            {
                Console.Write("Ingrese un número (0 para finalizar): ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out double numero))
                {
                    
                    if (numero == 0)
                        break;

                    
                    suma += numero;
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }

            
            if (cantidad > 0)
            {
                double promedio = suma / cantidad;
                Console.WriteLine("El promedio de los números ingresados es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
            }

            
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }









}










