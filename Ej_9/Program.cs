using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";

            int filas;
            int i;
            string cadena = "*";
            if(Int32.TryParse(Console.ReadLine(),out filas))
            {
                for(i=0;i<filas;i++)
                {
                    Console.WriteLine(cadena);
                    cadena += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
