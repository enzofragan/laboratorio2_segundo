using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
using Clase_02_Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase.edad = 15;
            MiClase.nombre = "Jose";

            // MiClase.MostrarEdad();

            //string name = MiClase.RetornarNombre();
            //Console.WriteLine(name);

            //string nombre2 = "Jose"; 
            //if (MiClase.CompararNombres(nombre2))
            //{
            //    Console.WriteLine("Son los mismos");
            //}

            //MiLibreria.MiClase.nombre = "Maria"; //SE INGRESA POR MEDIO DEL NAMESPACE

            Sello.mensaje = "Hola Mundo !";
            string msj = Sello.Imprimir();
            Console.WriteLine(msj);

            Sello.Borrar();
            msj = Sello.Imprimir();
            Console.WriteLine(msj);

            Sello.mensaje = "Estefanialalalalala";
            Sello.color = ConsoleColor.DarkMagenta;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.Magenta;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            msj = Sello.Imprimir();
            Console.WriteLine(msj);

            Sello.mensaje = "Estealala";
            Sello.color = ConsoleColor.DarkYellow;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.DarkGreen;
            Sello.ImprimirEnColor();
            Sello.color = ConsoleColor.Blue;
            Sello.ImprimirEnColor();

            Console.ReadLine();
        }
    }
}
