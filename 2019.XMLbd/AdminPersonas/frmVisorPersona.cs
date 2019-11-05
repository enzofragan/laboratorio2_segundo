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
        }

        public List<Persona> ListaPersonas
        {
            get { return this.listaPersonas; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPersona frm = new frmPersona(this.listaPersonas[this.lstVisor.SelectedIndex]);
                frm.ShowDialog();
                
                if (frm.DialogResult == DialogResult.OK)
                {
                    Persona aux = frm.Persona;
                    int index = this.lstVisor.SelectedIndex;
                    this.listaPersonas[index] = aux;
                    this.lstVisor.Items.RemoveAt(index);
                    this.lstVisor.Items.Insert(index,frm.Persona.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }
    }
}
