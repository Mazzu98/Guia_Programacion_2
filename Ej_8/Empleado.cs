using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_8
{
    class Empleado
    {
        public float valorXhora;
        public string nombre;
        public int antiguedad;
        public int horasTrabajadas;

        public Empleado(float valorXhora, string nombre, int antiguedad, int horasTrabajadas)
        {
            this.valorXhora = valorXhora;
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.horasTrabajadas = horasTrabajadas;
        }

        public float CalcularBruto()
        {
            return (this.horasTrabajadas * this.valorXhora) + (antiguedad * 150);
        }

        public float CalcularDescuento()
        {
            return CalcularBruto() * 0.13f; 
        }

        public float CalcularNeto()
        {
            return CalcularBruto() - CalcularDescuento();
        }

        public void imprimirRecibo()
        {
            Console.WriteLine("Nombre: {0}",nombre);
            Console.WriteLine("Años de antiguedad: {0}",antiguedad );
            Console.WriteLine("valor por hora: {0}", valorXhora);
            Console.WriteLine("Total bruto: {0}", CalcularBruto());
            Console.WriteLine("Total de descuentos: {0}", CalcularDescuento());
            Console.WriteLine("Total Neto: {0}", CalcularNeto());
        }

    }
}
