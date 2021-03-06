using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico3;

namespace AppFutbolForm
{
    public partial class FormAgregarMediocampista : FormAgregarBasic
    {
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormAgregarMediocampista()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
        }
        /// <summary>
        /// Constructor con parametros que asigna los valores de equipo y un listBox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="jugadoresCargados"></param>
        public FormAgregarMediocampista(Equipo e,ListBox jugadoresCargados):this()
        {
            equipo = e;
            lstAuxiliar = jugadoresCargados;
        }

        /// <summary>
        /// Agrega un nuevo mediocampista a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Mediocampista m = new Mediocampista();
            m.Nombre = txtNombre.Text;
            m.Apellido = txtApellido.Text;
            try
            {
                m.Edad = Convert.ToInt32(txtEdad.Text);
                m.CantidadPartidosJugados = Convert.ToInt32(txtCantPatidosJugados.Text);
                m.CantAsistencias = Convert.ToInt32(txtAsistencias.Text);
                m.CantidadPasesCorrectos = Convert.ToInt32(txtPasesCorrectos.Text);
                m.TotalPases = Convert.ToInt32(txtTotalPases.Text);
                m.Velocidad = Convert.ToDouble(txtVelocidad.Text);
                equipo.equipo.Add(m);
                ActualizarLst();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan completar datos o alguno de ellos es incorrecto.La creacion del mediocampista fallo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }
    }
}
