using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool successI;
            bool successF;
            int inputNumInicio;
            int inputNumFinal;

            Console.WriteLine("Ingresar año inicial:");
            successI = Int32.TryParse(Console.ReadLine(), out inputNumInicio);
            Console.WriteLine("Ingresar año final:");
            successF = Int32.TryParse(Console.ReadLine(), out inputNumFinal);
            if (successI == true && successF == true)
            {
                for(int i = inputNumInicio; i < inputNumFinal;i++){
                    if(i%4 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }1
            Console.ReadKey();
        }
    }
}
