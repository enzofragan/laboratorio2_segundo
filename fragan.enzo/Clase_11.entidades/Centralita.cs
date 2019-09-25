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

        public float GananciaPorLocal { get; }
        public float GananciaPorProvincial { get; }
        public float GananciaTotal { get; }
        public List<llamada> llamadas { get; }

        private void agregarLlamada(llamada nuevaLlamada)
        {

        }

        private float CalcularGanancia(TipoLlamada tipo)
        {

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

        }

        public static bool operator !=(Centralita central, llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central,llamada nuevaLlamada)
        {

        }

        public void OrdernarLlamadas()
        {

        }

        public override string ToString()
        {
            //se mustra el nombre de la empresa y despues se recorre la lista y por cada elemento se muestra el tostring
        }
    }
}
