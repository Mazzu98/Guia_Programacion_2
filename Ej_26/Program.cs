using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();
            Random rd = new Random();
            for(int i = 0;i<20;i++)
            {
                lista.Add(rd.Next(-10000,10000));
            }
            foreach(int entero in lista)
            {
                Console.WriteLine(entero);
            }
            Console.WriteLine("\n\n");
            listaNegativos = lista.FindAll(e => e<0);
            listaPositivos = lista.FindAll(e => e>=0);

            listaPositivos.Sort();
            foreach(int entero in listaPositivos)
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
    }
}
