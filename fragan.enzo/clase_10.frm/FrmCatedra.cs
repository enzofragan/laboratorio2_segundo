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


namespace FrmPrincipal
{
    public partial class FrmCatedra : Form
    {
        public FrmCatedra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmA = new FrmAlumno();
            frmA.StartPosition = FormStartPosition.CenterScreen;
            
            frmA.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmA = new FrmAlumno();
            frmA.StartPosition = FormStartPosition.CenterScreen;
            frmA.ShowDialog();
        }
    }
}
