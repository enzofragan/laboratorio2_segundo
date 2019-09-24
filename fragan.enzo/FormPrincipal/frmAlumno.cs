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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen e in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbExamen.Items.Add(e);
            }
            this.cmbExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
