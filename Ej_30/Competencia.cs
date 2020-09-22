using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltass: {this.cantidadVueltas}");
            sb.AppendLine();
            foreach (AutoF1 auto in competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine();
                sb.AppendLine("------------------------------");
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool ret = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool ret = false;
            if (c.competidores.Count <= c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                c.competidores.
                ret = true;
            }
            return ret;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool ret = false;
            int index;
            if (c == a)
            {
                c.competidores.Remove(a);
                index = c.competidores.FindIndex(i => i == a);
                c.competidores[index].EnCompetencia = true;
                c.competidores[index].VueltasRestantes = c.cantidadVueltas;
                Random rnd = new Random();
                c.competidores[index].CantidadCombustible = (short) rnd.Next(15,100);
                ret = true;
            }
            return ret;
        }
    }
}
