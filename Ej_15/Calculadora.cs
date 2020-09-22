using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, char operacion)
        {
            double result = 0;

            switch(operacion)
            {
                case '+': result = Sumar(num1,num2);
                    break;
                case '-': result = Restar(num1, num2);
                    break;
                case '*': result = Multiplicar(num1, num2);
                    break;
                case '/': result = Dividir(num1, num2);
                    break;
                default: result = 0;
                    break;
            }
            return result;
        }

        public static bool Validar(double num2)
        {
            bool ret = false;
            if(num2 != 0)
            {
                ret = true;
            }
            return ret;
        }

        private static double Sumar(double num1,double num2)
        {
            return num1 + num2;
        }

        private static double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double Dividir(double num1, double num2)
        {
            double ret = 0;
            if(Validar(num2))
            {
                ret = num1 / num2;
            }

            return ret;
        }
    }
}
