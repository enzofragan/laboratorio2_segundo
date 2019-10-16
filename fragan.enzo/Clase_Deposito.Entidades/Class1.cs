using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T a)
        {
            return this + a;
        }

        public Deposito(int capacida)
        {
            this._capacidadMaxima = capacida;
            this._lista = new List<T>(capacida);
        }

        private int GetIndice(T c)
        {
            int indice = -1;
            int contador = 0;
            foreach (T b in this._lista)
            {
                contador++;
                if (b.Equals(c))
                {
                    indice = contador - 1;
                }
            }
            return indice;
        }
        public static bool operator -(Deposito<T> d, T c)
        {
            bool respuesta = false;
            int indice;
            indice = d.GetIndice(c);
            if (indice > -1)
            {
                d._lista.RemoveAt(indice);
                respuesta = true;
            }
            return respuesta;

        }
        public static bool operator +(Deposito<T> d, T c)
        {
            bool respuesta = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                respuesta = true;

            }
            return respuesta;
        }
        public bool Remover(T c)
        {
            return this - c;
        }
        public override string ToString()
        {
            string respuesta = "";
            respuesta += "Capacidad: " + this._capacidadMaxima.ToString() + "\n";
            foreach (T a in this._lista)
            {
                respuesta += "\n" + a.ToString();
            }
            return respuesta;
        }
    }
}
