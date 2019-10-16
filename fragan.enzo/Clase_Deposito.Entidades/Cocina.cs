using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;

        public int Codigo
        {
            get { return this._codigo; }
            
        }
        private bool _esIndustrial;

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
       
        }
        private double _precio;

        public double Precio
        {
            get { return this._precio; }
           
        }
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Cocina)
            {
                if ((Cocina)obj == this)
                {
                    respuesta = true;
                }
            }
            return base.Equals(obj);
        }
        public static bool operator ==(Cocina a, Cocina b)
        {
            bool respuesa = false;
            if(a.Codigo == b.Codigo)
            {
                respuesa = true;
            }
            return respuesa;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            string respuesta = " ";
            respuesta += "Codigo: " + this.Codigo + "\n Precio: " + this.Precio;
            if (this.EsIndustrial == true)
            {
                respuesta += "\n es industrial";
            }
            else
            {
                respuesta += "\n No es industrial";
            }
            return respuesta;
        }



    }
}
