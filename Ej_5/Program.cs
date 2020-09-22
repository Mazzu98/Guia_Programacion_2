using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            int inputNumber;
            bool success;
            int sumaGrupo1 = 0;
            int sumaGrupo2;
            int i ;
            int j ;

            Console.WriteLine("Ingrese un numero");
            success = Int32.TryParse(Console.ReadLine(),out inputNumber);
            if(success)
            {
               for(i=1;i<inputNumber+1;i++)
                {
                    sumaGrupo1 += i-1;
                    sumaGrupo2 = 0;
                    for(j=i+1;j<inputNumber+1;j++)
                    {
                        sumaGrupo2 += j;
                    }
                    if(sumaGrupo1 == sumaGrupo2)
                    {
                        Console.WriteLine("El Centro numerico es {0}",i);
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
