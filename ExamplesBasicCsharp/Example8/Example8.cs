using System;

namespace Example8
{
    internal class Example8
    {
        private static void Main(string[] args)
        {
            //program entry point

            var consigna = "\n\tIngresar tres numeros y determinar cual es el mayor y menor.";

            Console.WriteLine(consigna);

            #region interaccion con el usuario

            Console.WriteLine("\nIngresá un número");
            int A = Convert.ToInt16(Console.ReadLine()); // aqui vemos como declarar directamente y almacenar

            Console.WriteLine("\nIngresá un número");
            int B = Convert.ToInt16(Console.ReadLine()); // aqui vemos como declarar directamente y almacenar

            Console.WriteLine("\nIngresá un número");
            int C = Convert.ToInt16(Console.ReadLine()); // aqui vemos como declarar directamente y almacenar

            #endregion interaccion con el usuario

            #region logica de comparaciones para numero mayor 

            {
                if (A > B && A > C)
                {
                    Console.WriteLine("El número mayor es " + A);
                }

                else
                {
                    if (B > A && B > C)
                    {
                        Console.WriteLine("El número mayor es " + B);
                    }

                    else
                    {
                        Console.WriteLine("El número mayor es " + C);
                    }
                }
            }

            #endregion logica de comparaciones para numero mayor

            #region logica de comparaciones para numero menor

            {
                if (A < B && A < C)
                {
                    Console.WriteLine("El número menor es " + A);
                }

                else
                {
                    if (B < A && B < C)
                    {
                        Console.WriteLine("El número menor es " + B);
                    }
                    else
                    {
                        Console.WriteLine("El número menos es " + C);
                    }
                }


                Console.ReadKey();
            }

            #endregion logica de comparaciones para numero menor
        }
    }
}