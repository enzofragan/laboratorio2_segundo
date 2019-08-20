using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido;
            Console.Title = "ejercicio de bienvenida";
            // Console.WriteLine("hola mundo");
            System.Console.WriteLine("ingrese su nombre: ");
            apellido = Console.ReadLine();
            Console.Write("mi apellido es {0}",apellido);
            Console.ReadLine();
        }
    }
}
