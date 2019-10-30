using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_20.entididades
{
    public class Auto
    {
        public string marca;
        public double precio;

        public Auto()
        {

        }

        public Auto(string marca,double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public override string ToString()
        {
            string respuesta = "";
            respuesta += this.marca + "\n" + this.precio.ToString();
            return respuesta;
        }
    }
}
