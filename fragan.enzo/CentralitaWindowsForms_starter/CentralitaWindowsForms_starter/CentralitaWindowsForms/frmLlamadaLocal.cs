using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralitaWindowsForms
{
    public partial class frmLlamadaLocal : Llamada
    {
        Clase_11.entidades.Local a;
        public frmLlamadaLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            string destino;
            string origen;
            string duracion;
            string costo;

            destino = this.textBox1.Text;
            origen = this.textBox2.Text;
            duracion = this.txtDuracion.Text;
            costo = this.txtCosto.Text;

            base.MiLlamada = new Clase_11.entidades.Local(origen,(,destino,)
        }
    }
}
