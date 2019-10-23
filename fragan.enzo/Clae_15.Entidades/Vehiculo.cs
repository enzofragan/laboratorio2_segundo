using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public void MostrarPrecio()
        {

        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
    }
}
