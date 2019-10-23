using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public class Privado: Avion
    {
        protected int _ValoracionServicioDeAbordo;

        public Privado(double precio, double privacidad, int valoracion) : base(precio,privacidad)
        {
            this._ValoracionServicioDeAbordo = valoracion;
        }
    }
}
