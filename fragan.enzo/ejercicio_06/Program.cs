using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;

            Console.Write("ingrese un año de inicio: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("ingrese un año de fin: ");
            fin = int.Parse(Console.ReadLine());

            for(int i=inicio;i<=fin;i++)
            {
                if(i%4==0 && i%400==0)
                {
                    Console.WriteLine("{0} es un año bisiesto", i);
                    Console.ReadLine();
                }
            }
        }
    }
}
