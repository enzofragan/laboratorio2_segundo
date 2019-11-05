using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        private DataTable tabla;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.ShowDialog();
                StreamReader lector = new StreamReader(openFileDialog1.FileName);

                this.lista = (List<Persona>)xml.Deserialize(lector);

                lector.Close();

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();

                StreamWriter txt = new StreamWriter(openFileDialog1.FileName);

                xml.Serialize(txt, this.lista);
                txt.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();

            this.lista = frm.ListaPersonas;

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
            this.Close();
        }

       

        private void conectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;

                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1000 [id], [nombre], [apellido], [edad] FROM [personas_bd].[dbo].[personas]";
                dataReader = command.ExecuteReader();

                MessageBox.Show("Conexion exitosa");

                dataReader.Close();
                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;
                string res = "";

                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1000 [id], [nombre], [apellido], [edad] FROM [personas_bd].[dbo].[personas]";
                dataReader = command.ExecuteReader();

                while (dataReader.Read() != false)
                {
                    res += dataReader["nombre"].ToString() + " " + dataReader["apellido"].ToString() + " " + dataReader["edad"].ToString();
                    res += "\n";
                    //MessageBox.Show(dataReader["nombre"].ToString()+" "+dataReader["apellido"].ToString()+" "+dataReader["edad"].ToString());

                }
                MessageBox.Show(res);
                dataReader.Close();
                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
