using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clae_15.Entidades
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public virtual string Patente
        {
            get { return this._patente; }
        }


        public void MostrarPatente()
        {

        }

        public Auto(double precio,string patente) : base(precio)
        {
            this._patente = patente;
        }
    }
}
