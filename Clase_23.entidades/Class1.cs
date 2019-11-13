using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_23.entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        public event LimiteSueldoDelegado LimiteSueldo;
        public event LimiteSueldoManejadoDel LimiteSueldoMejorado;


        public Empleado(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string MiNombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string MiApellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int MiLegajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        public double MiSueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (value > 30000)
                {
                    try
                    {
                        EmpleadoEventArgs emp2 = new EmpleadoEventArgs();
                        emp2.SueldoAsignar = value;
                        this.LimiteSueldoMejorado(this, emp2);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
                else if(value >18000)
                {
                    try
                    {
                        this.LimiteSueldo(value, this);
                    }
                    catch (Exception)
                    {

                        //throw;
                    }

                }
                else
                {
                    this.sueldo = value;
                }
                
            }
        }

        public override string ToString()
        {
            string res = "";
            res += this.nombre + "\n" + this.apellido + "\n" + this.legajo.ToString() + "\n";
            return res;
        }
    }
}
