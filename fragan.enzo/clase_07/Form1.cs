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
      this.mipaleta += frm.laTempera;
        //string aux = frm.MiTempera;
        for (int i = 0; i < this.mipaleta.maxima; i++)
        {
            if(!Object.Equals(this.mipaleta[i], null))
            {
                this.lstPaleta.Items.Add((string)this.mipaleta[i]);
            }
        }
        this.crearPaletaToolStripMenuItem.Enabled = false;
     }

     private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
     {
         this.mipaleta = 5;
         grpPaleta.Visible = true;
     }

    private void btnmas_Click(object sender, EventArgs e)
    {
        FrmTempera nueva = new FrmTempera();
        nueva.ShowDialog();
        this.mipaleta += nueva.laTempera;
        for(int i=0;i<this.mipaleta.maxima;i++)
        {
            if (!Object.Equals(this.mipaleta[i], null))
            {
                this.lstPaleta.Items.Add((string)this.mipaleta[i]);
            }
        } 
    }

    private void btnmenos_Click(object sender, EventArgs e)
    {
            /*if(lstPaleta.SelectedIndex>=0)
            {
                this.lstPaleta.Items.RemoveAt(lstPaleta.SelectedIndex);
            }*/
            FrmTempera nueva = new FrmTempera();
            nueva.ShowDialog();
            Tempera tem = nueva.laTempera;
            if(this.mipaleta == tem)
            {
                this.lstPaleta.Items.RemoveAt(this.mipaleta | tem);
                this.mipaleta -= tem;
            }
    }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!Object.Equals(this.lstPaleta.SelectedItem,null))
            {
                FrmTempera nueva = new FrmTempera((Tempera)this.lstPaleta.SelectedItem);
                nueva.ShowDialog();
                Tempera tem = nueva.laTempera;
                int index = this.mipaleta | (Tempera)this.lstPaleta.SelectedItem;
                if ((Tempera)this.lstPaleta.SelectedItem!=tem)
                {
                    this.mipaleta[index] = tem;
                    for (int i = 0; i < this.mipaleta.maxima; i++)
                    {
                        if (!Object.Equals(this.mipaleta[i], null))
                        {
                            this.lstPaleta.Items.Add((string)this.mipaleta[i]);
                        }
                    }
                }
            }

        }
    }
}
