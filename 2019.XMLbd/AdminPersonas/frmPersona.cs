using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }

        public frmPersona()
        {
            InitializeComponent();
        }

        public frmPersona(Persona p)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtNombre.Text = p.nombre;
            this.txtApellido.Text = p.apellido;
            this.txtEdad.Text = p.edad.ToString();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //implementar
            string nombre, apellido, edad;

            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            edad = this.txtEdad.Text;

            this.miPersona = new Persona(nombre, apellido, int.Parse(edad));

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
