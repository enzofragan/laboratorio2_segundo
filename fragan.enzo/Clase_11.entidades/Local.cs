using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.entidades
{
    public class Local : llamada
    {
        protected float costo;

        public override float CostoLlamada { get; }

        public float CalcularCosto()
        {

        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Local)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public Local(llamada unaLlamada,float costo) :this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {

        }

        public Local(string origen,float duracion,string destino,float costo) : base(origen,destino,duracion)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder respuesta = new StringBuilder();
            respuesta.Append(base.Mostrar());
            respuesta.Append(this.CostoLlamada);
            respuesta.AppendLine("");
            return respuesta.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
