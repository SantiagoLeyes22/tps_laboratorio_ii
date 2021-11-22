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
    public partial class FormAgregarDelantero : FormAgregarBasic
    {
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormAgregarDelantero()
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
        public FormAgregarDelantero(Equipo e, ListBox jugadoresCargados) : this()
        {
            equipo = e;
            lstAuxiliar = jugadoresCargados;
        }

        /// <summary>
        /// Agrega un nuevo delantero a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Delantero d = new Delantero();
            d.Edad = 0;
            d.Nombre = txtNombre.Text;
            d.Apellido = txtApellido.Text;
            try
            {
                d.Edad = Convert.ToInt32(txtEdad.Text);
                d.CantidadPartidosJugados = Convert.ToInt32(txtCantPatidosJugados.Text);
                d.CantidadGoles = Convert.ToInt32(txtCantGoles.Text);
                d.CantRegatesCompletos = Convert.ToInt32(txtRegatesCorrectos.Text);
                d.TotalDeRegates = Convert.ToInt32(txtTotalRegates.Text);
                equipo.equipo.Add(d);
                ActualizarLst();
                CrudTitulares.Guardar(new JugadorTitular(d.Nombre, d.Apellido, d.Edad));
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan completar datos o alguno de ellos es incorrecto.La creacion del delantero fallo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }
    }
}
