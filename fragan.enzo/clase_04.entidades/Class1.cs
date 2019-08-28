using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_04.entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            entero = -1;
            cadena = "sin valor";
            fecha = DateTime.Now;
        }

        public Cosa(string cadena2) : this()
        {
            cadena = cadena2;
        }

        public Cosa(string cadena2,DateTime fecha2) : this(cadena2)
        {
            fecha = fecha2;
        }

        public Cosa(string cadena2,DateTime fecha2,int entero2) : this(cadena2,fecha2)
        {
            entero = entero2;
        }

        public string mostrar()
        {
            string mostrar2 = "";

            mostrar2 = "" + entero.ToString() + "\n" + cadena + "\n" + fecha.ToString();

            return mostrar2;
        }

        public void EstablecerValor(int entero2)
        {
            entero = entero2;
        }

        public void EstablecerValor(int entero2,string cadena2)
        {
            EstablecerValor(entero2);
            cadena = cadena2;
        }

        public void EstablecerValor(int entero2, string cadena2,DateTime fecha2)
        {
            EstablecerValor(entero2, cadena2);
            fecha = fecha2;
        }
    }
}
