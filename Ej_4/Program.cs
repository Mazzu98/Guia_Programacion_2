using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int divisor;
            int suma =0 ;
            int num = 0;
            int i;
            int j = 0;
            while(j < 4)
            {
                num++;
                for(i=1;i<num;i++)
                {
                    if(num%i == 0)
                    {
                        suma += i;
                    }
                }
                if(suma == num)
                {
                    j++;
                    Console.WriteLine(num);
                }
                suma = 0;
            }

            Console.ReadKey();
        }
    }
}
