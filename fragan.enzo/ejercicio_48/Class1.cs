using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_48
{
    public class Contabilidad<T,U>
    {
        private List<T> egreso;
        private List<U> ingreso;

        public Contabilidad()
        {
            this.egreso = new List<T>();
            this.ingreso = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c,T egreso)
        {

        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {

        }
    }
}
