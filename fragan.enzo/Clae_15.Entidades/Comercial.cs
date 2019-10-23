using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public class Comercial :Avion
    {
        protected int _capacidadDePasajeros;

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio,velocidad)
        {
            this._capacidadDePasajeros = pasajeros;
        }
    }
}
