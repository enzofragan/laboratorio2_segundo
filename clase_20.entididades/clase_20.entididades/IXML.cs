using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_20.entididades
{
    interface IXML
    {
        bool Guardar(string res);
        bool Leer(string res, out object obj);
    }
}
