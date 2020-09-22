using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int filas;
            int i;
            int j;
            string asteriscos = "*";

            if (Int32.TryParse(Console.ReadLine(), out filas))
            {
                for (i = 0; i < filas; i++)
                { 
                    for(j=filas ;j>i ;j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(asteriscos);
                    for (j = filas; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("");

                    asteriscos += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
