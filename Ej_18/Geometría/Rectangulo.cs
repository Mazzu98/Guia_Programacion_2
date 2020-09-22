using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_18.Geometría
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1,Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(),vertice3.GetY());
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.area = Area();
            this.perimetro = Perimetro();
        }

        public float GetArea { get => this.area; }
        public float GetPerimetro { get => this.perimetro; }

        public float Area()
        {
            return (Math.Abs(vertice2.GetX() - vertice1.GetX())) * (Math.Abs(vertice1.GetY()-vertice4.GetY()));
        }

        public float Perimetro()
        {
            return ((Math.Abs(vertice2.GetX() - vertice1.GetX())) + (Math.Abs(vertice1.GetY() - vertice4.GetY())))*2;
        }

        public static void Mostrar()
        {
            Console.WriteLine("Vertice 1: {0}{1}\nVertice 2: {2}{3}\nVertice 3: {4}{5}\nVertice 4: {6}{7}");
        }
    }
}
