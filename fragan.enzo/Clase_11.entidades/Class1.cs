using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.entidades
{
    public abstract class llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion { get; }

        public string NroDestino { get; }

        public string NroOrigen { get; }

        public llamada(string origen,string destino,float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder retorna = new StringBuilder();
            retorna.Append(this.NroOrigen);//escribe texto sin salto de linea
            retorna.AppendLine("");//escribe texto con salto de linea
            retorna.Append(this.NroDestino);//escribe texto sin salto de linea
            retorna.AppendLine("");//escribe texto con salto de linea
            retorna.Append(this.Duracion);//escribe texto sin salto de linea
            retorna.AppendLine("");//escribe texto con salto de linea
            return retorna.ToString();
        }

        public static bool operator ==(llamada uno,llamada dos)
        {
            bool respuesta = false;

            if(uno.Equals(dos) && uno.NroOrigen==dos.NroOrigen && uno.NroDestino==dos.NroDestino)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(llamada uno,llamada dos)
        {
            return !(uno == dos);
        }

        public int OrderPorDuracion(llamada uno,llamada dos)
        {

        }
    }
}
