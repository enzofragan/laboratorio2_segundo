using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            persona humano = new persona("enzo", "fragan", 41914842);

            /*humano.nombre = "enzo";
            humano.apellido = "fragan";
            humano.dni = 41914842;*/

            Console.WriteLine(humano.mostrar());
            Console.ReadLine();

            persona humano2 = new persona("mindan", "furmin", 37986452);

            /*humano.nombre = "mindan";
            humano.apellido = "furmin";
            humano.dni = 37986452;*/

            Console.WriteLine(humano.mostrar());
            Console.ReadLine();
        }
    }
}
