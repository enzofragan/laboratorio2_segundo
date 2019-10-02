using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.entidades
{
    public abstract class Provincial : llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo = 0;
            if(this._franjaHoraria==Franja.Franja_1)
            {
                costo = base.Duracion * (float)0.99;
            }
            else if(this._franjaHoraria==Franja.Franja_2)
            {
                costo = base.Duracion * (float)1.25;
            }
            else
            {
                costo = base.Duracion * (float)0.66;
            }
            return costo;
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if (obj is Provincial)
            {
                respuesta = true;
            }
            return respuesta;
        }

        protected override string Mostrar()
        {
            StringBuilder respuesta = new StringBuilder();
            respuesta.Append(base.Mostrar());
            respuesta.Append(this._franjaHoraria);
            respuesta.AppendLine("");
            respuesta.Append(this.CostoLlamada);
            respuesta.AppendLine("");
            return respuesta.ToString();
        }

        public Provincial(Franja franja,llamada UnaLlamada) : this(UnaLlamada.NroOrigen,franja,UnaLlamada.Duracion,UnaLlamada.NroDestino)
        {

        }

        public Provincial(string origen,Franja franja,float duracion,string destino) : base(origen,destino,duracion)
        {
            this._franjaHoraria = franja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
