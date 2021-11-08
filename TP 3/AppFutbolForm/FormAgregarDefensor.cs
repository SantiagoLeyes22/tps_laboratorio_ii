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
    public partial class FormAgregarDefensor : FormAgregarBasic
    {
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormAgregarDefensor()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            this.cmbTipoDefensor.Items.AddRange(new object[] { TipoDefensor.Central, TipoDefensor.LateralDerecho, TipoDefensor.LateralIzquierdo });
            this.cmbTipoDefensor.DropDownStyle = ComboBoxStyle.DropDownList;
            CenterToParent();
        }
        /// <summary>
        /// Constructor con parametros que asigna los valores de equipo y un listBox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="jugadoresCargados"></param>
        public FormAgregarDefensor(Equipo e,ListBox jugadoresCargados):this()
        {
            equipo = e;
            lstAuxiliar = jugadoresCargados;
        }

        /// <summary>
        /// Agrega un nuevo defensor a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Defensor d = new Defensor();
            d.Nombre = txtNombre.Text;
            d.Apellido = txtApellido.Text;
            try
            {
                d.Edad = Convert.ToInt32(txtEdad.Text);
                d.CantidadPartidosJugados = Convert.ToInt32(txtCantPatidosJugados.Text);
                d.DistanciaRecorrida = Convert.ToDouble(txtDistanciaRecorrida.Text);
                d.Tipo = (TipoDefensor)cmbTipoDefensor.SelectedItem;
                d.TotalQuites = Convert.ToInt32(txtTotalQuites.Text);
                d.QuitesCorrectos = Convert.ToInt32(txtQuitesCorrectos.Text);
                equipo.equipo.Add(d);
                ActualizarLst();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan completar datos o alguno de ellos es incorrecto.La creacion del defensor fallo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Close();
        }
    }
}
