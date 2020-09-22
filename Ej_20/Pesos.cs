using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotiz) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / cotizRespectoDolar);
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad / Pesos.cotizRespectoDolar / Euro.GetCotizacion());
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Euro)e;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.cantidad + ((Pesos)d).cantidad;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.cantidad + ((Pesos)e).cantidad;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.cantidad - ((Pesos)d).cantidad;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.cantidad - ((Pesos)e).cantidad;
        }


    }
}
