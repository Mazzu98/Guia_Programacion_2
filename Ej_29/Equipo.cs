using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            this.cantidadDeJugadores = 0;
            this.nombre = "";
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e,Jugador j)
        {
            bool ret = false;
            if(!e.jugadores.Contains(j))
            {
                if(e.jugadores.Count <= e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                    ret = true;
                }
            }
            return ret;
        }
    }
}
