using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color {
            get
            {
                return this._color;
            }
        }
        public string Marca {
            get
            {
                return this._marca;
            }
        }

        public Auto(string color,string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Auto)
            {
                if((Auto)obj==this)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public static bool operator == (Auto a, Auto b)
        {
            bool respuesta = false;
            if (a.Color == b.Color && a.Marca == b.Marca)
            {
                respuesta = true;
            }
            return respuesta;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            string respuesta = "";
            respuesta += "Marca: " + this.Marca + "- Color: " + this.Color;

            return respuesta;
        }

    }
}
