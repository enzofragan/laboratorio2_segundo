using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Externa.Sellada;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace clase_23.entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre,string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre()
        {
                return this.nombre;
        }

        public string Apellido()
        {
                return this.apellido;
        }

        public int Dni()
        {
               return this.dni;
        }

        public string ObternerInfo()
        {
            string ret = "";
            ret += this.Nombre() + "\n" + this.Apellido() + "\n" + this.Dni();
            return ret;
        }

        
    }

    public class copia : PersonaExterna
    {
        public string getNombre()
        {
            return base._nombre;
        }

        public string getApellido()
        {
            return base._apellido;
        }

        public int getEdad()
        {
            return base._edad;
        }

        public Entidades.Externa.ESexo getSexo()
        {
            return base._sexo;
        }

        public string ObternerInfo()
        {
            string ret = "";
            ret += this.getNombre() + "\n" + this.getApellido() + "\n" + this.getEdad()+"\n"+this.getSexo();
            return ret;
        }

        public copia(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre,apellido,edad,sexo)
        {

        }
    }

    public static class Extensora
    {
        public static string ObtenerInfo(this PersonaExternaSellada sellada)
        {
            string ret = "";
            ret += sellada.Nombre + "\n" + sellada.Apellido + "\n" + sellada.Edad.ToString() + "\n" + sellada.Sexo.ToString();
            return ret;
        }

        public static bool esNulo(this object o)
        {
            bool res = false;
            if(o == null)
            {
                res = true;
            }

            return res;
        }

        public static List<Persona> ObtenerListadoBd(this Persona p)//asociar
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.Conexion);
            sqlC.Open();

            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;

            command.Connection = sqlC;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM [personas_bd].[dbo].[personas]";
            dataReader = command.ExecuteReader();

            while (dataReader.Read() != false)
            {
                p = new Persona(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), int.Parse(dataReader["edad"].ToString()));
                lista.Add(p);
            }

            dataReader.Close();
            sqlC.Close();

            return lista;
        }
    }
}
