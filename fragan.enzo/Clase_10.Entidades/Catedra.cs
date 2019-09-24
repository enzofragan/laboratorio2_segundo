using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }

        }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            bool respuesta = false;
            if (!Object.Equals(c, null) && !Object.Equals(a, null))
            {
                foreach (Alumno a1 in c.Alumnos)
                {
                    if (a1 == a)
                    {
                        respuesta = true;
                    }
                }
            }
            return respuesta;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool respuesta = false;
            if (!Object.Equals(c, null) && !Object.Equals(a, null))
            {
                if (c != a)
                {
                    c.Alumnos.Add(a);
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool respuesta = false;
            if (!Object.Equals(c, null) && !Object.Equals(a, null))
            {
                if (c == a)
                {
                    c.Alumnos.RemoveAt(a | c);
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public static int operator |(Alumno a, Catedra c)
        {
            int index = -1;
            if (!Object.Equals(c, null) && !Object.Equals(a, null))
            {
                int i = -1;
                foreach (Alumno a1 in c.Alumnos)
                {
                    i++;
                    if (a1 == a)
                    {
                        break;
                    }
                }
                if (c.Alumnos.Count != i)
                {
                    index = i;
                }
            }
            return index;
        }

        public Alumno this[int indice]
        {
            get
            {
                Alumno retorno = null;
                //if (indice >= 0 && indice <= this.capitulos.Count) {
                if (indice >= 0 && indice <= this.Alumnos.Count)
                {
                    retorno = this.Alumnos[indice];
                }
                return retorno;
            }
        }

        public override string ToString()
        {
            string retorno = "";
            foreach(Alumno a in this.Alumnos)
            {
                retorno += a.ToString();
            }
            return retorno;
        }
    }
}
