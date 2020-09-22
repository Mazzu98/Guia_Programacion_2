using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            int resto;
            int cociente = numero;
            string binario = "";
            do
            {
                resto = cociente % 2;
                cociente = cociente / 2;
                binario += resto;

            } while (cociente >= 2);

            binario += cociente;

            binario = Reverse(binario);

            return binario; 
        }



        public static int BinarioDecimal(string binario)
        {
            int numDecimal = 0;
            int exponente = 0;
            int i;
            char[] vecBiario = binario.ToArray();

            for(i = vecBiario.Length -1; i>=0 ;i--)
            {
                if(vecBiario[i]=='1')
                {
                    numDecimal += (int) Math.Pow(2,exponente);
                }
                exponente ++;
            }
            return numDecimal;
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
