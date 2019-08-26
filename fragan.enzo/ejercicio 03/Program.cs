using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 0; //un contador, el cual si es menor o igual a dos indica que el numero es primo

            Console.Write("ingrese un numero: ");

            numero = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numero; i++)
            {  //apertura del for1
                for (int j = 1; j <= i; j++)
                {   //apertura for2

                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }


                if (cont <= 2)
                { //si variable cont es menor p igual a dos, el numero es divisible en dos numero osea es primo
                    Console.WriteLine("{0} es primo",i);
                }      //cierre for2
                cont = 0;               //igualamos a cero para hacer otra evaluacion con otro numero


            }//cierre del for1

            Console.ReadKey();

        }
    }
}
