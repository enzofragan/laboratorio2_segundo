using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 01";
            int numero;
            int max = 0;
            int min = 0;
            float promedio = 0;
            int i;


            for (i=0;i<5;i++)
            {
                Console.Write("ingrese un numero: ");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("el numero es {0}", numero);

                if(max==0 && min==0)
                {
                    max = numero;
                    min = numero;
                }

                if(max<numero)
                {
                    max = numero;
                }
                else if(min>numero)
                {
                    min = numero;
                }

                promedio = promedio + numero;
            }

            promedio = (Single) promedio / i;

            Console.WriteLine("\nel valor maximo es {0}\nel valor minimo es {1}\nel promedio es {2}", max, min, promedio);
            Console.ReadLine();
        }
    }
}
