using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum1 = new Sumador();

            Sumador sum2 = new Sumador(4);

            Console.WriteLine((int)sum2);

            Console.ReadKey();

        }
    }
}
