using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11.entidades
{
    public class Centralita
    {
        private List<llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<llamada> llamadas { get; }

        private void agregarLlamada(llamada nuevaLlamada)
        {
            this.llamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float costo = 0;
            foreach(llamada l in this.llamadas)
            {
                if (tipo == TipoLlamada.Local)
                {
                    costo += l.CostoLlamada;
                }
                else if (tipo == TipoLlamada.Provincial)
                {
                    costo += l.CostoLlamada;
                }
                else
                {
                    costo += l.CostoLlamada;
                }
            }
            return costo;
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<llamada>();
        }

        public Centralita(string nombreDeLaEmpresa) : this()
        {
            this._razonSocial = nombreDeLaEmpresa;
        }

        public static bool operator ==(Centralita central, llamada nuevaLlamada)
        {
            bool respuesta = false;
            foreach(llamada l in central.llamadas)
            {
                if(l==nuevaLlamada)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        public static bool operator !=(Centralita central, llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central,llamada nuevaLlamada)
        {
            if(central != nuevaLlamada)
            {
                central.agregarLlamada(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("esta llamada ya esta registrada");
            }
            return central;
        }

        public void OrdernarLlamadas()
        {
            this.llamadas.Sort(llamada.OrderPorDuracion);
        }

        public override string ToString()
        {
            string respuesta = "";
            respuesta += this._razonSocial;
            foreach(llamada l in this.llamadas)
            {
                respuesta += "\n"+l.ToString();
            }
            return respuesta;
            //se mustra el nombre de la empresa y despues se recorre la lista y por cada elemento se muestra el tostring
        }
    }
}
