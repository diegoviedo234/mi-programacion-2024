using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miCuartaPractica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Introduzca un número (escribe 'salir' para terminar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "salir")
                {
                    break;
                }

                if (int.TryParse(input, out int numero))
                {
                    if (EsPrimo(numero))
                    {
                        Console.WriteLine($"El número {numero} es primo.");
                    }
                    else
                    {
                        Console.WriteLine($"El número {numero} no es primo.");
                    }
                }
                else
                {
                    Console.WriteLine("Solo funciona si introduces números.");
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}    
    
    
    
    
    
    
    
    
  