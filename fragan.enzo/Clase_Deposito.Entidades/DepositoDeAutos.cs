using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            return this + a;
        }
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>(capacidad);
        }
        private int GetIndice(Auto a)
        {
            int indice = -1;
            int contador = 0;
            foreach(Auto b in this._lista)
            {
                contador++;
                if (b==a)
                {
                    indice = contador - 1;
                }
            }

            return indice;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool respuesta = false;
            int indice;

            indice = d.GetIndice(a);
            if(indice > -1)
            {
                d._lista.RemoveAt(indice);
                respuesta = true;
            }

            return respuesta;
        }
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool respuesta = false;
            if(d._lista.Count < d._capacidadMaxima)// count devuelve la cantidad total de los objetos en la lista
            {
                d._lista.Add(a);
                respuesta = true;
            }
            return respuesta;
        }
        public bool Remover(Auto a)
        {
            return this - a;
        }
        public override string ToString()
        {
            string respues = "";
            respues += "Capacidad: " + this._capacidadMaxima.ToString() + "\n";
            foreach(Auto a in this._lista)
            {
                respues +="\n"+ a.ToString();
            }
            return respues;
        }

    }
}
