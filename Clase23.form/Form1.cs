using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_23.entidades;


namespace Clase23.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach(TipoManejador t in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(t);
            }

            this.cmbManejador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre;
                string apellido;
                string legajo;
                string sueldo;
                Empleado e1;

                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                legajo = txtLegajo.Text;
                sueldo = txtSueldo.Text;
                e1 = new Empleado(nombre, apellido, int.Parse(legajo));
                if((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.LimiteSueldo)
                {
                    e1.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                }
                if ((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.LimiteSueldoMejorado)
                {
                    e1.LimiteSueldoMejorado += new LimiteSueldoManejadoDel(Form1.ManejadorLimiteSueldoMejorado);
                }
                if ((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.Todos)
                {
                    e1.LimiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                    e1.LimiteSueldoMejorado += new LimiteSueldoManejadoDel(Form1.ManejadorLimiteSueldoMejorado);
                }
                e1.MiSueldo = double.Parse(sueldo);
                MessageBox.Show(e1.ToString());
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {
            MessageBox.Show(emp.MiNombre + "\n" + emp.MiApellido);
        }

        public static void ManejadorLimiteSueldoMejorado(Empleado e1, EmpleadoEventArgs e2)
        {
            MessageBox.Show(e1.MiNombre + "\n" + e2.SueldoAsignar);
        }

        public void ManejadorLimiteSueldoMejorado2(Empleado e1, EmpleadoEventArgs e2)
        {
            MessageBox.Show(e1.MiNombre + "\n" + e2.SueldoAsignar);
        }
    }
}
