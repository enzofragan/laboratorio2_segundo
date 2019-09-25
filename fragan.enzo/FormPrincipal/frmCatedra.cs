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
    public partial class frmCatedra : Form
    {
        Clase_10.Entidades.Catedra MiCatedra;
        public frmCatedra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(this.MiCatedra+frm.ElAlumno)
            {
                for(int i=0;i<this.MiCatedra.Alumnos.Count;i++)
                {
                    //this.lstAlumnos.Items.Add((string)this.MiCatedra[1])
                }
            }
        }
    }
}
