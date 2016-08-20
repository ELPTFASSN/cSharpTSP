using System;

namespace Example4
{
    internal class Example4
    {
        private static void Main(string[] args)
        {
            #region declaraciones iniciales

            var consigna = "\nIndicar la equivalencia de Grados Celsius con Fahrenheit / Fahrenheit con Celsius.";
            var fah = " grados Fahrenheit.";
            var cent = " grados Centigrados.";

            double _F;
            double _C;

            #endregion declaraciones iniciales

            #region core example4

            Console.WriteLine(consigna);

            Console.Write("\nIngresa Los Grados en Celsius : ");
            // en este caso usamos solamente WRITE para que ingresemos el numero en el mismo renglon,caso contrario usamos WRITELINE.
            _C = Convert.ToDouble(Console.ReadLine());

            //logica de analisis
            _F = _C*1.8000 + 32.00; //<-- pasar de Celsius a Fahrenheit
            //_C = _F - 32 / 1.8000; //<-- pasar de Fahrenheit a Celsius


            Console.Write("\nEl resultado de la conversion es: ");
            //formato de color para el resultado de la conversion de C a F
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_F);
            Console.ResetColor();
            //ingreso de frase por default de string fah
            Console.WriteLine(fah);

            Console.WriteLine("\nPresiona cualquier tecla para salir por Favor.");
            Console.ReadKey();

            #endregion core example4

            // cierre y fin de la ejecucion de la aplicacion
            Environment.Exit(0);
        }
    }
}