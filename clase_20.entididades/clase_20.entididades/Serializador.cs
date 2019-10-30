using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_20.entididades
{
    static class Serializador
    {
        public static bool serializar(IXML archivo)
        {
            bool respuesta = false;
            
            if(archivo.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\persona.xml"))
            {
                respuesta = true;
            }

            return respuesta;
        }
        public static bool deserializar(IXML archivo,out object obj)
        {
            bool respuesta = false;
            
            if (archivo.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\persona.xml",out obj))
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
