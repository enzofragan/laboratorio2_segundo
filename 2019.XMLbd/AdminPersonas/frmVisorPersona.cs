using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> listaPersonas;

        public frmVisorPersona()
        {
            InitializeComponent();

            
        }

        public frmVisorPersona(List<Persona> list) : this()
        {
            this.listaPersonas = list;

            try
            {
                Persona p1;
                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;

                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [personas_bd].[dbo].[personas]";
                dataReader = command.ExecuteReader();

                while (dataReader.Read() != false)
                {
                    p1 = new Persona(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), int.Parse(dataReader["edad"].ToString()));
                    this.listaPersonas.Add(p1);
                    this.lstVisor.Items.Add(dataReader["nombre"].ToString() + " - " + dataReader["apellido"].ToString() + " - " + dataReader["edad"].ToString());
                }

                dataReader.Close();
                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public List<Persona> ListaPersonas
        {
            get { return this.listaPersonas; }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersona frm = new frmPersona();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                //implementar

                if (frm.DialogResult == DialogResult.OK)
                {
                    this.listaPersonas.Add(frm.Persona);
                    this.lstVisor.Items.Add(frm.Persona.ToString());
                }

                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [personas_bd].[dbo].[personas] ([nombre],[apellido],[edad]) VALUES (@param1,@param2,@param3)";
                command.Parameters.AddWithValue("@param1", frm.Persona.nombre);
                command.Parameters.AddWithValue("@param2", frm.Persona.apellido);
                command.Parameters.AddWithValue("@param3", frm.Persona.edad);
                command.ExecuteNonQuery();

                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersona frm = new frmPersona(this.listaPersonas[this.lstVisor.SelectedIndex]);
                frm.ShowDialog();
                Persona aux;
                aux = frm.Persona;
                int index = this.lstVisor.SelectedIndex;

                if (frm.DialogResult == DialogResult.OK)
                {
                    
                    this.listaPersonas[index] = aux;
                    this.lstVisor.Items.RemoveAt(index);
                    this.lstVisor.Items.Insert(index,frm.Persona.ToString());
                }

                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();
                index++;
                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE [personas_bd].[dbo].[personas] SET nombre=@param1,apellido=@param2,edad=@param3 WHERE id =@param4";
                command.Parameters.AddWithValue("@param1", aux.nombre);
                command.Parameters.AddWithValue("@param2", aux.apellido);
                command.Parameters.AddWithValue("@param3", aux.edad);
                command.Parameters.AddWithValue("@param4", index);
                command.ExecuteNonQuery();

                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            //implementar
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = this.lstVisor.SelectedIndex;

                this.listaPersonas.RemoveAt(index);
                this.lstVisor.Items.RemoveAt(index);

                SqlConnection sqlC = new SqlConnection(Properties.Settings.Default.conexion);
                sqlC.Open();

                SqlCommand command = new SqlCommand();
                index++;
                command.Connection = sqlC;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM [personas_bd].[dbo].[personas] WHERE id =@param4";
                command.Parameters.AddWithValue("@param4", index);
                command.ExecuteNonQuery();

                sqlC.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            //implementar
        }
    }
}
