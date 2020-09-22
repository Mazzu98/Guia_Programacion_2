using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            bool success;
            int inputNum;
            int max = int.MinValue;
            int min = int.MaxValue;
            float prom;
            int suma = 0;

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingresar numero:");
                success = Int32.TryParse(Console.ReadLine(),out inputNum);
                if(success == true)
                {
                    if(inputNum > max)
                    {
                        max = inputNum;
                    }
                    else if (inputNum < min)
                    {
                        min = inputNum;
                    }
                    suma += inputNum;
                }
                else
                {
                    i--;
                }
            }

            prom = (float)suma / 5;

            Console.WriteLine("Maximo {0}, Minimo {1}, promedio {2}",max,min,prom);


            Console.ReadKey();
        }
    }
}
