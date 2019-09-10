using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase_06.entidades;

namespace clase_07
{
  public partial class Form1 : Form
  {
    clase_06.entidades.Paleta mipaleta;
    public Form1()
    {
      InitializeComponent();

      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;
      this.grpPaleta.Visible = false;
    }

    private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmTempera frm = new FrmTempera();
      //frm.MdiParent = this;
      
      frm.ShowDialog();
      grpPaleta.Visible = true;
      string aux = frm.MiTempera;
      this.lstPaleta.Items.Add(aux);
    }

    private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.mipaleta = 5;
      this.crearPaletaToolStripMenuItem.Enabled = false;
    }
  }
}
