using System;

namespace Ej_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public int legajo;
        public string apellido;

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if(this.nota1 > 3 && this.nota2 > 3)
            {
                Random rand = new Random();
                this.notaFinal = rand.Next(10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string mostrar()
        {
            string ret = "nombre: " + nombre + "\napellido: " + apellido + "\nlegajo: " + legajo + "\nnota 1: " + nota1 + "\nnota 2: " + nota2; 
            if(this.notaFinal == -1)
            {
                ret += "\nAlumno desaprobado";
            }
            else
            {
                ret += "\nnota final: " + notaFinal;
            }
            return ret;
        }
    }
}
