using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_11
{
    class Validacion
    {
        public static bool Validar(int valor,int min,int max)
        {
            bool ret;
            if(valor < max && valor > min)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }
    }
}
