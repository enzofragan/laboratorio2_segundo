using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_09.entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        public string Titulo {
            get
            {
                return this.titulo;
            }
        }
        public string Autor {
            get
            {
                return this.autor;
            }
        }

        public int CantidadDePaginas
        {
            get
            {
                int aux = 0;
                foreach(Capitulo c in this.capitulos)
                {
                    aux += c.Paginas;
                }
                return aux;
            }
        }

        public Libro(string autor,string titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.capitulos = new List<Capitulo>();
        }

        public int CantidadDeCapitulos {
            get
            {
                return this.capitulos.Count;
            }
        }

        public Capitulo this[int index]
        {
            get
            {
                int count = this.capitulos.Count;
                if(index <0 || index>count)
                {
                    return null;
                }
                else
                {
                    return this.capitulos[index];
                }
            }

            set
            {
                int count = this.capitulos.Count;
                if (index>=count)
                {
                    this.capitulos.Add(value);
                }
                else if(index<0)
                {

                }
                else
                {
                    this.capitulos[index] = value;
                }
            }
        }
    }
}
