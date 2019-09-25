using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;


namespace FormPrincipal
{
    public partial class frmAlumno : Form
    {
        Clase_10.Entidades.Alumno a;

        public Alumno ElAlumno
        {
            get { return a; }
        }
        public frmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen e in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbExamen.Items.Add(e);
            }
            this.cmbExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string legajo;
            ETipoExamen exemen;

            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            legajo = this.txtLegajo.Text;
            exemen = (ETipoExamen)this.cmbExamen.SelectedItem;

            this.a = new Alumno(nombre, apellido, int.Parse(legajo), exemen);

            MessageBox.Show(this.a.ToString());

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
