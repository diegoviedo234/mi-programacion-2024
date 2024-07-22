using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miTerceraPractica
{
    internal class Program
        
    {
        static void Main(string[] args)
        // Desarrolle un programa que pida número positivos al usuario, y vaya calculando la suma de todo ello (terminará cuando se teclea un número negativo o cero).

        {
            int numero;
            int suma = 0;

            while (true)
            {

                Console.WriteLine("Introduzca un número positivo (Si desea salir, introduzca un número negativo o 0)");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    break;
                }

                suma += numero;
                Console.WriteLine($"Suma actual: {suma}");

            }

            Console.WriteLine($"La suma total de los números positivos que se introducieron es: {suma}");
        }
    }
}
