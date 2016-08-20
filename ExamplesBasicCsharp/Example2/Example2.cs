using System;

namespace example2
{
    internal class Example2
    {
        private static void Main(string[] args)
        {
            //declaro todo lo estatico, lo que no cambia en el la ejecucion del programa.

            var consigna = "Calcular la longitud de la circunferencia y el area del circulo.";

            double _radio;
            double _area;
            double _longitud;
            // el valor de pi lo dejamos como una constante, primero decimos que pi tiene formato DOUBLE y luego asignamos a PI el valor manualmente de la constante.
            double _pi;
            _pi = 3.14;


            // interaccion con el usuario

            #region

            Console.WriteLine("Ingresa el Radio de la Circunferencia: ");
            //lo que hacemos debajo es asignar a _radio el numero que el usuario ingrese indicando que tiene que tomar ese valor que es "solo un dato" y convertirlo a formato numerico.
            _radio = Convert.ToDouble(Console.ReadLine());

            // logicas de ejecucion

            _longitud = 2*_pi*_radio;
            _area = _pi*(_radio*_radio);


            Console.WriteLine("\nCon los datos que ingresaste se determina que :");
            Console.Write("La longitud de la circunferencia es :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_longitud);
            Console.ResetColor();

            Console.Write("El area de la circunferencia es :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_area);
            Console.ResetColor();

            #endregion

            Console.WriteLine("\nPresiona cualquier tecla para salir por favor.");

            Console.ReadKey();
        }
    }
}