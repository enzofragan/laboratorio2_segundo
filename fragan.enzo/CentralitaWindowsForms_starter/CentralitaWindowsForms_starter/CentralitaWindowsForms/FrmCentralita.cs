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
    public partial class FrmCentralita : Form
    {
        Clase_11.entidades.Centralita MiCentralita;

        public FrmCentralita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Llamada frm = new Llamada();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Llamada frm = new Llamada();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
