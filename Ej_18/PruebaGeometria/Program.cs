using Ej_18.Geometría;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej_18.PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo forma = new Rectangulo(new Punto(3,10),new Punto(8,2));
            Console.WriteLine("El area es: {0} y el perimetro es: {1}",forma.GetArea,forma.GetPerimetro);

            Console.ReadKey();

        }
    }
}
