using System;

namespace Examples
{
    internal class Example1
    {
        // entry point of the program
        private static void Main(string[] args)
        {
            int _base;
            int _altura;
            int _superficie;

            var consigna =
                "Calcula la superficie de un triangulo rectangulo a partir del ingreso de su base y altura, luego muestre el resultado.";

            //llamamos directamente a consigna para que salga por pantalla en color verde
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(consigna);
            // volvemos al color original en pantalla
            Console.ResetColor();

            //Ingreso de datos por parte del usuario
            Console.WriteLine("Ingresa la medida de la base: ");
            _base = Convert.ToInt16(Console.ReadLine());

            //Ingreso de datos por parte del usuario
            Console.WriteLine("Ingresa la medida de la altura: ");
            _altura = Convert.ToInt16(Console.ReadLine());

            // logica de operaciones
            _superficie = _base * _altura / 2;

            Console.Write("La superficie del triangulo rectangulo es : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_superficie);
            Console.ResetColor();

            Console.WriteLine("Presiona cualquier tecla para salir por favor.");
            Console.ReadKey();
        }
    }
}