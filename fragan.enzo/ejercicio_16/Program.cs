using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno estudiante1 = new Alumno();
            Alumno estudiante2 = new Alumno();
            Alumno estudiante3 = new Alumno();

            estudiante1.nombre = "enzo";
            estudiante1.apellido = "fragan";
            estudiante1.legajo = 3352580;

            estudiante2.nombre = "mindan";
            estudiante2.apellido = "fermin";
            estudiante2.legajo = 4652782;

            estudiante3.nombre = "raidz";
            estudiante3.apellido = "yuda";
            estudiante3.legajo = 1475878;

            estudiante1.Estudiar(4, 5);
            estudiante2.Estudiar(3, 6);
            estudiante3.Estudiar(10, 10);

            estudiante1.CalcularFinal();
            estudiante2.CalcularFinal();
            estudiante3.CalcularFinal();

            Console.WriteLine(estudiante1.mostrar());
            Console.WriteLine(estudiante2.mostrar());
            Console.WriteLine(estudiante3.mostrar());
            Console.ReadLine();
        }
    }
}
