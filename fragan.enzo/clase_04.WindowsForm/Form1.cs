using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_04.entidades;

namespace clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string entero;
            string cadena;
            string fecha;
            Cosa elemento;
            entero = this.txtEntero.Text;
            cadena = this.txtCadena.Text;
            fecha = this.txtFecha.Text;
            elemento = new Cosa(cadena, Convert.ToDateTime(fecha), int.Parse(entero));
            this.txtEntero.Clear();
            this.txtCadena.Clear();
            this.txtFecha.Clear();
            MessageBox.Show(elemento.mostrar());
            this.txtAgregar.Items.Add(elemento.mostrar());
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
