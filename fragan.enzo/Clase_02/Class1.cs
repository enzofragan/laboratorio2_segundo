using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class MiClase
    {
        public static string nombre; //Se les puede agregar modificadores, por defecto es privado 
        public static int edad; //static, modificador de comportamiento
        
        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
        }

        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            bool retorno = false;
            if (nombre == MiClase.nombre)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
