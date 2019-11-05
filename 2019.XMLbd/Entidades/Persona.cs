using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Persona() { }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.nombre  + " - " +  this.apellido + " - " + this.edad;
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            bool respuesta = false;
            if(p1.nombre==p2.nombre && p1.apellido==p2.apellido && p1.edad==p2.edad)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1==p2);
        }
    }
}
