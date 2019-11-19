using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_23.entidades;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Clases_23.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("juan", "perez", 123456);
            PersonaExternaSellada p2 = new PersonaExternaSellada("juan", "perez", 12,Entidades.Externa.Sellada.ESexo.Masculino);
            copia p3 = new copia("lionel", "perez", 20, Entidades.Externa.ESexo.Masculino);

            Console.WriteLine(p1.ObternerInfo());
            Console.ReadLine();

            Console.WriteLine(p3.ObternerInfo());
            Console.ReadLine();

            Console.WriteLine(Extensora.ObtenerInfo(p2));
            Console.ReadLine();
        }
    }
}
