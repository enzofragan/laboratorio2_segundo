using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    class Deportivo : Auto, IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo (double precio, string patente, int hp) : base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuestos()
        {
            throw new NotImplementedException();
        }

        double IAFIP.CalcularImpuesto()
        {
            double ret = 0;
            ret += this._precio * 0.28;
            return ret;
        }
    }
}
