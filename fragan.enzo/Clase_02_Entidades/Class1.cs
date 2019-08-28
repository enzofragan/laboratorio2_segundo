using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_02_Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
             string var = ArmarFormatoMensaje();
             return var;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            string var = ArmarFormatoMensaje();
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(var);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static string ArmarFormatoMensaje()
        {
            int longitud = mensaje.Length;
            string auxiliar= "";
            string var;

            for (int i= 0; i < longitud+2; i++)
            {
                auxiliar += "*";
            }
            var = auxiliar + "\n*" + Sello.mensaje + "*\n" + auxiliar ;
            return var;
        }
     
    }
}
