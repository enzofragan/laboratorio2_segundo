using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Entidades
{
    class Alumno_Calificado : Alumno
    {
        protected double nota;

        public double Nota
        {
            get { return this.nota; }

        }

        public Alumno_Calificado(Alumno a1, double nota1)
            : this(a1.Nombre, a1.Apellido, a1.Legajo, a1.Examen, nota1)
        {

        }

        public Alumno_Calificado(string name, string apellido, int legajo, ETipoExamen examen, double nota1): base(name, apellido, legajo, examen)
        {
            this.nota = nota1;
        }
        public string Mostrar()
        {
            return Alumno.Mostrar(this) + "Nota: " + this.Nota.ToString();
        }
    }
}
