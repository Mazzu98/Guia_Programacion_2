using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            float prom;
            int suma = 0;
            int i;
            int j=0;
            int numero;
            for(i=0;i<10;i++)
            {
                if(Int32.TryParse(Console.ReadLine(),out numero))
                {
                    if(Validacion.Validar(numero,-100,100))
                    {
                        if (i == 0)
                        {
                            min = numero;
                            max = numero;
                        }
                        else if (numero < min)
                        {
                            min = numero;
                        }
                        else if (numero > max)
                        {
                            max = numero;
                        }
                        suma += numero;
                        j++;
                    }
                }
            }
            prom = (float) suma / j;

            Console.WriteLine("Valor minimo: {0}",min);
            Console.WriteLine("Valor maximo: {0}",max);
            Console.WriteLine("Promedio: {0}",prom);
            Console.ReadKey();
        }
    }
}
