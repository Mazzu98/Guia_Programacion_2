using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta ;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor { get => color; }
        public short GetTinta { get => tinta; }

        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta >= 0 && this.tinta + tinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short tinta = this.tinta;
            int i;
            bool pinto = false;
            dibujo = "";

            SetTinta(gasto);
            if(this.tinta >= 0)
            {
                pinto = true;
                tinta -= this.tinta;
                for(i=0;i<tinta;i++)
                {
                    dibujo += "*";
                }
            }
            return pinto;
        }




    }
}
