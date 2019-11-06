using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class frmVisorDataTable : frmVisorPersona
    {
        private DataTable datatable;

        public frmVisorDataTable()
        {
            InitializeComponent();
        }

        public frmVisorDataTable(DataTable tabla):this()
        {
            try
            {
                for(int i=0;i<tabla.Rows.Count;i++)
                {
                    base.lstVisor.Items.Add(String.Format("{0} - {1} - {2} - {3}", tabla.Rows[i][datatable.Columns[0]], tabla.Rows[i][datatable.Columns[1]], tabla.Rows[i][datatable.Columns[2]], tabla.Rows[i][datatable.Columns[3]]));
                }
            }
            catch (Exception exeption)
            {

                MessageBox.Show(exeption.Message);
            }
        }

        public DataTable Tabla {
            get
            {
                return this.datatable;
            }
        }

        private void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach(DataRow dr in datatable.Rows)
            {
                if(dr.RowState != DataRowState.Deleted)
                {
                    this.lstVisor.Items.Add($"{dr[0]} - {dr[1]} - {dr[2]} - {dr[3]}");
                }
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                DataColumnCollection columnas = datatable.Columns;
                DataRow fila = datatable.NewRow();
                DataRowCollection datrow = datatable.Rows;
                fila[columnas[1]] = frm.Persona.nombre;
                fila[columnas[2]] = frm.Persona.apellido;
                fila[columnas[3]] = frm.Persona.edad;
                this.ActualizarLista();
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow datafile = this.datatable.Rows[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(new Entidades.Persona(datafile["nombre"].ToString(), datafile["apellido"].ToString(), int.Parse(datafile["edad"].ToString())));
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                datafile["nombre"] = frm.Persona.nombre;
                datafile["apellido"] = frm.Persona.apellido;
                datafile["edad"] = frm.Persona.edad;
            }

            this.ActualizarLista();
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
           if(lstVisor.SelectedIndex >=0)
            {
                DataRow fila = this.Tabla.Rows[this.lstVisor.SelectedIndex];
                fila.Delete();
                this.ActualizarLista();
            }
        }
    }
}
