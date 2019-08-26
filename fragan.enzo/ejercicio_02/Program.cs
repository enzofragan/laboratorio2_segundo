using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cubo;
            double cuadrado;

            Console.Write("ingrese un numero: ");

            numero = int.Parse(Console.ReadLine());

            if(numero>0)
            {
                cubo = Math.Pow(numero, 3);
                cuadrado = Math.Pow(numero, 2);
                Console.WriteLine("el numero es {0}\nsu cuadrado es {1}\ny su cubo es {2}",numero,cuadrado,cubo);
                Console.ReadLine();
            }
        }
    }
}
