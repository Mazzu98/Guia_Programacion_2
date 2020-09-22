using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";

            DateTime nacimiento;
            DateTime hoy = DateTime.Now;
            TimeSpan tSpan;
            int dias;

            bool success;
            Console.WriteLine("Ingrese fecha dd/mm/aaaa");
            success = DateTime.TryParse(Console.ReadLine(), out nacimiento);

            if(success)
            {
                tSpan = hoy - nacimiento;
                dias = tSpan.Days;
                Console.WriteLine("Has vivido {0} dias",dias);
            }
            

            Console.ReadKey();
        }
    }
}
