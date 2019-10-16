using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public bool Agregar (Cocina c)
        {
            return this + c;
        }
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>(capacidad);
        }
        private int GetIndice(Cocina c)
        {
            int indice = -1;
            int contador = 0;
            foreach(Cocina b in this._lista)
            {
                contador++;
                if (b == c)
                {
                    indice = contador - 1;
                }
            }
            return indice;
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
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
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool respuesta = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                respuesta = true;

            }
            return respuesta;
        }
        public bool Remover(Cocina c)
        {
            return this - c;
        }
        public override string ToString()
        {
            string respuesta = "";
            respuesta += "Capacidad: " + this._capacidadMaxima.ToString() + "\n";
            foreach (Cocina a in this._lista)
            {
                respuesta += "\n" + a.ToString();
            }
            return respuesta;
        }
    }
}
