using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    public class Alumno
    {
    protected string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            
        }
        protected string apellido;

        public string Apellido
        {
            get { return this.apellido; }
            
        }
        protected int legajo;

        public int Legajo
        {
            get { return this.legajo; }
          
        }
        protected  ETipoExamen examen;

        public  ETipoExamen Examen
        {
            get { return this.examen; }
           
        }

        public Alumno(string name, string apellido, int legajo, ETipoExamen Exa1)
        {
            this.nombre = name;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = Exa1;
        }

        public static string Mostrar(Alumno a1)
        {
            string name = "";
            if(!Object.Equals(a1,null))
            {
                name += a1.Nombre + a1.Apellido + a1.Legajo.ToString() + a1.Examen;
            }
            return name;
        }

        public static bool operator ==( Alumno a1, Alumno a2)
        {
            bool sonIguales= false;
            if (!Object.Equals(a1, null)&& !Object.Equals(a2,null))
            {
                if (a1.Legajo == a2.Legajo)
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static int OrdenarPorLegajoAsc (Alumno a1, Alumno a2)
        {
            return string.Compare(a1.legajo.ToString(), a2.Legajo.ToString());
        }
        public static int OrdenarPorLegajoDesc(Alumno a1, Alumno a2)
        {
            return -1 * Alumno.OrdenarPorLegajoAsc(a1, a2);
        }
        public static int OrdenarPorApellidoAsc(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.apellido, a2.apellido);
        }
        public static int OrdenarPorApellidoDesc(Alumno a1, Alumno a2)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a1, a2);
        }


        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }


        //internal static string Mostrar(Alumno_Calificado alumno_Calificado)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
