using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Juan", "Mazzu", 1233112);
            Alumno alumno2 = new Alumno("Pepe", "Lopez", 1233112);
            Alumno alumno3 = new Alumno("Nose", "QUE", 1233112);

            alumno1.Estudiar(4,5);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.mostrar());


            Console.ReadKey();
        }
    }
}
