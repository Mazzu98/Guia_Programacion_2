using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char operacion;


            do
            {
                Console.WriteLine("Ingrese el primer numero");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Ingrese el segundo numero");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ingrese el operador");
                        if (char.TryParse(Console.ReadLine(), out operacion))
                        {
                            Console.WriteLine("\nResulatado: {0}", Calculadora.Calcular(num1, num2, operacion));
                        }
                    }
                }
              
                Console.WriteLine("Desea continuar? S/N");
            } while (Console.ReadKey().Key != ConsoleKey.N );



            Console.ReadKey();
        }
    }
}
