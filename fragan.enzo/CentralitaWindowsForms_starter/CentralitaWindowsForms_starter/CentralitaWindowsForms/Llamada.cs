using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_11.entidades;

namespace CentralitaWindowsForms
{
    public partial class Llamada : Form
    {
        protected Clase_11.entidades.llamada a;

        public Clase_11.entidades.llamada MiLlamada
        {
            get { return a; }
        }


        public Llamada()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //this.a=new llamada(destino, )
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
