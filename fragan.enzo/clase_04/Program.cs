using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_04.entidades;

namespace clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime f = new DateTime(1995, 4, 6);
            DateTime f2 = new DateTime(1754, 9, 4);
            Cosa elemento = new Cosa("hola",f2,7);
            //elemento.EstablecerValor(9, "hola", f);
            Console.WriteLine(elemento.mostrar());
            Console.ReadLine();
        }
    }
}
