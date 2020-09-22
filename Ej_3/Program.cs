using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            int inputNum;
            bool success;

            Console.WriteLine("Ingresar numero:");
            success = Int32.TryParse(Console.ReadLine(), out inputNum);

            if(success)
            {
                for(int i = 1; i<inputNum; i++)
                { 
                    if(IsPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }

            }

            Console.ReadKey();
        }

        public static bool IsPrimo(int inputNum)
        {
            bool isPrimo = true;
            for (int i = 2; i < inputNum; i++)
            {
                if (inputNum % i == 0)
                {
                    isPrimo = false;
                    break;
                }
            }
            return isPrimo;
        }
    }
}
