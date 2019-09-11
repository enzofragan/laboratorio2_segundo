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
  public partial class FrmTempera : Form
  {
    clase_06.entidades.Tempera t;

    public Tempera laTempera
    {
            get { return t; }
    }

    public FrmTempera()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
      foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.cmbColores.Items.Add(c);
      }
      this.cmbColores.SelectedItem = ConsoleColor.Magenta;
      this.cmbColores.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public FrmTempera(Tempera t)
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
        {
            this.cmbColores.Items.Add(c);
        }
        this.txtMarca.Text = t.MiMarca;
        this.txtCantidad.Text = t.MiCantidad;
        this.cmbColores.SelectedItem = t.MiColor;
        this.cmbColores.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string marca;
      string cantidad;
      ConsoleColor color;

      marca = this.txtMarca.Text;
      cantidad = this.txtCantidad.Text;
      color = (ConsoleColor)this.cmbColores.SelectedItem;
      this.t = new Tempera(color, marca, int.Parse(cantidad));
      
      MessageBox.Show(this.t);
      
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
