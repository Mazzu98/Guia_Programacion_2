using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            char siNo;

            do
            {
                Console.WriteLine("Ingresar un valor:");
                if(Int32.TryParse(Console.ReadLine(),out numero))
                {
                    suma += numero;
                }
                Console.WriteLine("¿Continuar? (s/n)");
                siNo = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(siNo));

            Console.WriteLine("La summa total es: {0}",suma);

            Console.ReadKey();
        }
    }
}
