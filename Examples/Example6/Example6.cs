using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Example6
    {   //entry point of the current program
        static void Main(string[] args)
        {
            //cambiar el nombre de la consola
            Console.Title = "Dias de la semana";

            #region Inicio de variables

            string consigna = "\n\tIngresar un numero y mostrar a que dia de la semana corresponde.";

            int _numero;
            bool ok; // la vamos a usar para asegurar el ingreso correcto de numeros solamente para la ejecucion con un ciclo do-while.


            #endregion

            #region Interaccion con el usuario


            do // iniciamos el ciclo dp-while para la validacion general.La logica del do es si se cumple la condicion almecenar el valor obtenido en una variable y seguir.
                {
                Console.WriteLine(consigna);
                Console.Write("\nIngresa un numero entre 1 y 7 por favor: ");
                ok = int.TryParse(Console.ReadLine(), out _numero); // almacenamos TRUE  si la conversin se pudo hacer
                if (!ok) // aca decimos, si es DISTINTO de ok,osea que no se pudo almecenar, mostramos un mensaje de error
                    Console.WriteLine("Ingresa solo numeros por favor");
                }

            while (!ok);
            #endregion interaccion con el usuario

            { 
                

                #region Switch area

                switch (_numero)
                {
                    case 1:
                        Console.WriteLine("\nEl numero 1 corresponde al dia Domingo.");
                        break;
                    case 2:
                        Console.WriteLine("\nEl numero 2 corresponde al dia Lunes.");
                        break;
                    case 3:
                        Console.WriteLine("\nEl numero 3 corresponde al dia Martes.");
                        break;
                    case 4:
                        Console.WriteLine("\nEl numero 4 corresponde al dia Miercoles.");
                        break;
                    case 5:
                        Console.WriteLine("\nEl numero 5 corresponde al dia Jueves.");
                        break;
                    case 6:
                        Console.WriteLine("\nEl numero 6 corresponde al dia Viernes.");
                        break;
                    case 7:
                        Console.WriteLine("\nEl numero 7 corresponde al dia Sabado.");
                        break;

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ingresa numeros entre 1 y 7 por favor.");
                            Console.ResetColor();
                            break;
                        }
                }
            #endregion switch

                #region Final de comprobaciones & cierre de app
                Console.WriteLine("\n\nPresional cualquier tecla para salir por favor");
                Console.ReadKey();

                Environment.Exit(0);
                #endregion
            }
            




        }
    }
}
