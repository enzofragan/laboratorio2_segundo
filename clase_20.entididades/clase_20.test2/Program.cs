using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_20.entididades;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace clase_20.test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("jose", "rosario",15);
            Persona persona2 = new Persona("Ricardo ", "Mora",20);
            Persona persona3 = new Persona("Monica", "Ruiz",6);
            List<Persona> lista = new List<Persona>();

            lista.Add(persona1);
            lista.Add(persona2);
            lista.Add(persona3);

            foreach (Persona p in lista)
            {
                Console.WriteLine(p.ToString());
                Console.ReadLine();
            }
            //Console.WriteLine(persona1.ToString());
            //Console.ReadLine();

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamWriter text = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\persona.xml");
                TextWriter text2 = text;

                xml.Serialize(text2, lista);
                //xml.Serialize(text, persona1);
                //xml.Serialize(text, persona2);
                //xml.Serialize(text, persona3);

                text2.Close();
                text.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamReader lector = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\persona.xml");
                TextReader lector2 = lector;

                List<Persona> p2 = (List<Persona>)xml.Deserialize(lector2);
           

                foreach(Persona p in p2)
                {
                   Console.WriteLine(p.ToString());
                   Console.ReadLine();
                }
                lector2.Close();
                lector.Close();

                //Console.WriteLine(p2.ToString());
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }
    }
}
