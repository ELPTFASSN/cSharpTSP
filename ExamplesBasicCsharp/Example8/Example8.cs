using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Example8
    {
        static void Main(string[] args)
        {
            //program entry point

            string consigna = "\n\tIngresar tres numeros y determinar cual es el mayor";

            Console.WriteLine(consigna);
            Console.WriteLine("Ingresá un número");
            int A = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresá un número");
            int B = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresá un número");
            int C = Convert.ToInt16(Console.ReadLine());


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
                Console.ReadLine();
            }

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
                Console.ReadLine();
            }
        }
    }
}
