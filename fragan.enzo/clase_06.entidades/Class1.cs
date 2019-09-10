using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_06.entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color01,string marca01, int cantidad01)
        {
            this.color = color01;
            this.marca = marca01;
            this.cantidad = cantidad01;
        }

        private string mostrar()
        {
            string resultado = "";
            resultado = "el color es: " + this.color + "\nla marca es: " + this.marca + "\nla cantidad es: " + this.cantidad;
            return resultado;
        }

        public static implicit operator string(Tempera tempera01)
        {
            return tempera01.mostrar();
        }

        public static bool operator ==(Tempera tempera01,Tempera tempera02)
        {
            bool respuesta=false;
            if(!tempera01.Equals(null) && !tempera02.Equals(null))
            if(tempera01.marca==tempera02.marca && tempera01.color==tempera02.color)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Tempera tempera01, Tempera tempera02)
        {
            return !(tempera01 == tempera02);
        }

        public static Tempera operator +(Tempera tempera01, int cantida01)
        {
            if(!tempera01.Equals(null))
            {
                if (cantida01 > 0)
                {
                    tempera01.cantidad += cantida01;
                }
            }
            return tempera01;
        }

        public static Tempera operator +(Tempera tempera01,Tempera tempera02)
        {
            if(!tempera01.Equals(null) && !tempera02.Equals(null))
            {
                if (tempera01 == tempera02)
                {
                    tempera01 = tempera01 + tempera02.cantidad;
                }
            }
            return tempera01;
        }
    
  }
}
