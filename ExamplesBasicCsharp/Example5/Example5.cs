using System;

namespace Example5
{
    internal class Example5
    {
        // entry point principal of program
        private static void Main(string[] args)
        {
            // declaracion de variables/constantes

            var consigna = "Equivalencia de Centimetros con Pies y Pulgadas.";
            double _centimetros; // 1 cm es equivalente a 1 centimetro


            //genericos
            var _cms = ",tomando como referencia lo ingresado.";

            #region interaccion con el usuario

            Console.WriteLine(consigna);

            Console.Write("\nIngresa el/los centimetro/s para convertirlos en Pies y Pulgadas :");
            _centimetros = Convert.ToDouble(Console.Read());

            //logica de ejecucion
            var _pies = _centimetros*0.0328084; // 1 cm es equivalente a 0,0328084 pies
            var _pulgadas = _centimetros*0.393701; // 1 cm es equivalente a 0,393701 pulgadas.

            // mostrar el resultado de las conversiones
            Console.Write("\nPulgadas: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_pulgadas);
            Console.ResetColor();
            Console.WriteLine(_cms);

            Console.Write("\nPies: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(_pies);
            Console.ResetColor();
            Console.WriteLine(_cms);

            #endregion interaccion con el usuario

            Console.WriteLine("\n\nPresiona cualquier tecla para salir por favor.");
            Console.ReadKey();


            Environment.Exit(0);
        }
    }
}