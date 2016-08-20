using System;

namespace Example3
{
    internal class Example3
    {
        //entry point of program
        private static void Main(string[] args)
        {
            var consigna = "Ingresar un numero e indicar si es Positivo o Negativo";

            int numero;

            Console.WriteLine(consigna);

            #region interacciones

            //intercaccion con el usuario
            Console.WriteLine("\n\nIngresa un numero por favor: ");
            numero = Convert.ToInt16(Console.ReadLine());
            //Console.ReadKey();

            //estructura de control IF, by default si es mayor que 0 es positivo CASO CONTRARIO es negativo.
            if (numero > 0)
            {
                Console.WriteLine("El numero ingresado : {0} , es positivo.", numero);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero ingresado : {0} no es positivo", numero);
                Console.ReadKey();
            }

            #endregion interacciones

            #region salida del programa

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nPresiona cualquier tecla para salir por favor.");
            Console.ReadKey();
            Console.ResetColor();
            // cuando llega a este punto la ejecucion se cierra de manera adecuada
            Environment.Exit(0);

            #endregion salida del programa
        }
    }
}