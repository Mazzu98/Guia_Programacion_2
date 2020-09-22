using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotiz) : this(cantidad)
        {
            cotizRespectoDolar = cotiz;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotiz)
        {
            Euro.cotizRespectoDolar = cotiz;
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion() * Dolar.GetCotizacion());
        }

        public static explicit operator Dolar(Euro d)
        {
            return new Dolar(d.cantidad * Euro.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static Pesos operator +(Euro p, Dolar d)
        {
            return p.cantidad + ((Euro)d).cantidad;
        }

        public static Pesos operator +(Euro e, Pesos p)
        {
            return e.cantidad + ((Euro)p).cantidad;
        }

        public static Pesos operator -(Euro p, Dolar d)
        {
            return p.cantidad - ((Euro)d).cantidad;
        }

        public static Pesos operator -(Euro e, Pesos p)
        {
            return e.cantidad - ((Euro)p).cantidad;
        }




    }
}
