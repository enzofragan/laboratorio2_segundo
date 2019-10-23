using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public class Avion : Vehiculo, IAFIP
    {
        protected double _valocidadMaxima;

        public double Velocidad {
            get
            {
                return this._valocidadMaxima;
            }
        }

        double IAFIP.CalcularImpuestos()
        {
            double ret = 0;
            ret += this._precio * 0.33;
            return ret;
        }

        public double CalcularImpuesto()
        {
            throw new NotImplementedException();
        }

        public Avion(double precio, double velocidad) : base(precio)
        {
            this._valocidadMaxima = velocidad;
        }
    }
}
