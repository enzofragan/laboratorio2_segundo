using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public int legajo;
        public string nombre;
        public string apellido;

        public void CalcularFinal()
        {
            Random final = new Random();

            if(this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = final.Next(1,10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte NotaUno,byte NotaDos)
        {
            this.nota1 = NotaUno;
            this.nota2 = NotaDos;
        }

        public string mostrar()
        {
            string mostar = "";

            if(this.notaFinal > 0)
            {
                mostar = "el alumno: " + this.nombre + " " + this.apellido + " " + this.legajo + "\nesta aprobado con un " + this.notaFinal.ToString();
            }
            else
            {
                mostar = "el alumno: " + this.nombre + " " + this.apellido + " " + this.legajo + "\nAlumno desaprobado";
            }

            return mostar;
        }
    }
}
