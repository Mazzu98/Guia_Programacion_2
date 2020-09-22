using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";

            int inputNum;
            bool success;

            Console.WriteLine("Ingresar numero:");
            success = Int32.TryParse(Console.ReadLine(), out inputNum);

            if(success)
            {
                if (inputNum > 0)
                {
                    Console.WriteLine("El cuadrado es: {0} y el cubo es: {1}", Math.Pow(inputNum, 2), Math.Pow(inputNum, 3));
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
            else
            {
                Console.WriteLine("Ingresaste cualquier cosa crack, chau");
            }
        
            Console.ReadKey();
        }


    }
}
