using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace clase_20.entididades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]

    public class Persona : IXML
    {
        public string nombre;
        public string apellido;
        public List<string> apodos;
        private int edad;

        public int Edad {
            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }
                }

        public Persona()
        {

        }

        public Persona(string nombre,string apellido,int edad) : base()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.apodos = new List<string>();

        }
        public override string ToString()
        {
            string respuesta = "";
            respuesta += this.nombre + "\n" + this.apellido+"\n"+this.Edad.ToString();
            return respuesta;
        }

        public override bool Guardar()
    }
}
