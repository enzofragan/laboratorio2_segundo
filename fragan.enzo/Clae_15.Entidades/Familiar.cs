using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAcientos;

        public Familiar(double precio, string patente, int cantidad) : base(precio,patente)
        {
            this._cantAcientos = cantidad;
        }
    }
}
