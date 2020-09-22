using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";

            Empleado empleado1;
            empleado1 = new Empleado(300, "Jorge", 14, 8);
            empleado1.imprimirRecibo();


            Console.ReadKey();
        }
    }
}
