using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int respuesta;
            int ac = 0;

            while(cont<=4)
            {
                for (int i = 6; i >= 6; i++)
                {
                    for (int j = 1; j <= (i / 2); j++)
                    {
                        respuesta = i % j;
                        if (respuesta == 0)
                        {
                            ac = ac + j;
                        }
                    }
                    if (ac == i)
                    {
                        Console.WriteLine("{0} es un numero perfecto", ac);
                        cont = cont + 1;
                    }
                    ac = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
