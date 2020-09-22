using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lista = new Queue<int>();
            Queue<int> listaPositivos = new Queue<int>();
            Queue<int> listaNegativos = new Queue<int>();
            Random rd = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Enqueue(rd.Next(-10000, 10000));
            }
            foreach (int entero in lista)
            {
                Console.WriteLine(entero);
            }
            Console.WriteLine("\n\n");
            listaNegativos = Positivos(lista);
            listaPositivos = Negativos(lista);

            listaPositivos.OrderBy(entero => lista );
            foreach (int entero in listaPositivos)
            {
                Console.WriteLine(entero);
            }
            Console.WriteLine("\n\n");
            listaNegativos.OrderByDescending(entero => lista);
            foreach (int entero in listaNegativos)
            {
                Console.WriteLine(entero);
            }

            Console.ReadKey();
        }

        public static Queue<int> Positivos(Queue<int> lista)
        {
            Queue<int> listaEnteros = new Queue<int>();

            foreach(int entero in lista)
            {
                if(entero >= 0)
                {
                    listaEnteros.Enqueue(entero);
                }
            }
            return listaEnteros;
        }

        public static Queue<int> Negativos(Queue<int> lista)
        {
            Queue<int> listaEnteros = new Queue<int>();

            foreach (int entero in lista)
            {
                if (entero < 0)
                {
                    listaEnteros.Enqueue(entero);
                }
            }
            return listaEnteros;
        }
    }
}
