using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Example7
    {
        static void Main(string[] args)
        {
            // Variables Auxiliares
            decimal no1, no2, no3, suma, promedio;  // si ponemos de esta manera es mas rapido aunque menos limpio que declarar una por una
            string linea;
            string enunciado = "\n\tIngresar tres notas y calcular el promedio que corresponda";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(enunciado);
            Console.ResetColor();
            
            //Capturando datos
            Console.Write("\nIngrese la primera nota:");
            linea = Console.ReadLine();
            no1 = decimal.Parse(linea);
            Console.Write("\nIngrese la segunda nota:");
            linea = Console.ReadLine();
            no2 = decimal.Parse(linea);
            Console.Write("\nIngrese la tercera nota:");
            linea = Console.ReadLine();
            no3 = decimal.Parse(linea);

            // Realizar operaciones
            suma = no1 + no2 + no3;
            promedio = suma / 3;

            // Imprimiendo el resultado
            if (promedio >= 7)
            {
                
                Console.Write("\nPromocionado con la nota : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(promedio);
                Console.ResetColor();


            }
            if (promedio <= 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nDebe rendir recuperación porque su promedio es menor a 7, actualmente es de : ");
                Console.Write(promedio);
                Console.ResetColor();

            }
            Console.WriteLine("\n\nPresioná <<Enter>> para cerrar la ventana por favor.");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
