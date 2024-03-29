using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_06.entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta(): this(5)
        {
            
        }

        private Paleta(int maxima)
        {
            this.cantidadMaximaColores = maxima;
            this.colores = new Tempera[cantidadMaximaColores];
        }

        public static implicit operator Paleta(int numero)
        {
            Paleta aux = new Paleta(numero);
            return aux;
        }
        private string mostrar()
        {
            string resultado = "";
            resultado = "cantidad maxima de colores: " + this.cantidadMaximaColores.ToString();

            for(int i=0;i<this.colores.Length;i++)
            {
                resultado += "\n";

                if(!Object.Equals(this.colores[i], null))
                {
                    resultado += this.colores[i];
                }
            }

            return resultado;
        }
        
        public static explicit operator string(Paleta paleta01)
        {
            return paleta01.mostrar();
        }

        public static bool operator ==(Paleta paleta01,Tempera tempera01)
        {
            bool respuesta = false;

            if(!paleta01.Equals(null))
            {
                for (int i = 0; i < paleta01.colores.Length; i++)
                {
                    if(paleta01.colores[i] == tempera01)
                    {
                        respuesta = true;
                        break;
                    }
                }
            }

            return respuesta;
        }

        public static bool operator !=(Paleta paleta01, Tempera tempera01)
        {
            return !(paleta01 == tempera01);
        }

        public static Paleta operator +(Paleta paleta01, Tempera tempera01)
        {
            int indice;
            if(!Object.Equals(paleta01, null) && !Object.Equals(tempera01, null))
            {

                    if (paleta01 == tempera01)
                    {
                        paleta01.colores[paleta01.buscarLugarLibre()] += tempera01;
                    }
                    else
                    {
                        indice = paleta01.buscarLugarLibre();
                        paleta01.colores[indice] = tempera01;
                    }

            }

            return paleta01;
        }

        private int buscarLugarLibre()
        {
            int indice = -1;
            for(int i=0;i<this.colores.Length;i++)
            {
                if(Object.Equals(this.colores[i], null))
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static int operator |(Paleta paleta01,Tempera tempera02)
        {
            int respuesta = -1;

            for(int i=0;i<paleta01.colores.Length;i++)
            {
                if(paleta01.colores[i]==tempera02)
                {
                    respuesta = i;
                }
            }

            return respuesta;
        }

        public static Paleta operator -(Paleta paleta01, Tempera tempera01)
        {
            int indice = paleta01 | tempera01;
            if (!Object.Equals(paleta01, null) && !Object.Equals(tempera01, null))
            {
                if(indice>=0)
                {
                    paleta01.colores[indice] = null;
                }
            }

            return paleta01;
        }

        public Tempera this[int index]
        {
            get { return this.colores[index]; }
            set { this.colores[index] = value; }
        }

        public int maxima
        {
            get { return this.colores.Length; }
        }
    }
}
