using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_09.entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random GeneradorDeNumeros;

        private static Random GeneradorDePaginas;

        static Capitulo()
        {
            GeneradorDeNumeros = new Random();
            GeneradorDePaginas = new Random();
        }

        private Capitulo(int numero,string titulo,int paginas)
        {
            this.numero = numero;
            this.paginas = paginas;
            this.titulo = titulo;
        }


        public int Numero {
            get
            {
                return this.numero;
            }
        }
        public string Titulo {
            get
            {
                return this.titulo;
            }
        }
        public int Paginas {
            get
            {
                return this.paginas;
            }
        }

        public static implicit operator Capitulo(string titulo)
        {
            Capitulo ret = new Capitulo(GeneradorDeNumeros.Next(1, 100), titulo, GeneradorDePaginas.Next(1, 300));
            return ret;
        }

        public static bool operator ==(Capitulo cp1,Capitulo cp2)
        {
            bool respuesta = false;
            if(!Object.Equals(cp1,null) && !Object.Equals(cp2, null))
            {
                if(cp1.Numero==cp2.Numero && cp1.Titulo==cp1.Titulo)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Capitulo cp1, Capitulo cp2)
        {
            return !(cp1 == cp2);
        }
    }
}
