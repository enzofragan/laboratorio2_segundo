using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_03
{
    public class persona
    {
        public string nombre;
        public string apellido;
        public int dni;

        public persona(string nombre,string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string mostrar()
        {
            string completo="";

            completo = "Su nombre es: " + this.nombre + "\nSu apellido es: " + this.apellido + "\nY su dni es: " + this.dni.ToString();

            return completo;
        }
    }
}
