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
    public partial class FormAgregarArquero: FormAgregarBasic
    {
        
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormAgregarArquero()
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
        public FormAgregarArquero(Equipo e,ListBox jugadoresCargados):this()
        {
            equipo = e;
            lstAuxiliar = jugadoresCargados;
        }

        /// <summary>
        /// Agrega un nuevo arquero a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Arquero nuevoArquero = new Arquero();
            nuevoArquero.Nombre = txtNombre.Text;
            nuevoArquero.Apellido = txtApellido.Text;
            try
            {
                nuevoArquero.Edad = Convert.ToInt32(txtEdad.Text);
                nuevoArquero.CantidadPartidosJugados = Convert.ToInt32(txtCantPatidosJugados.Text);
                nuevoArquero.CantVallasInvictas = Convert.ToInt32(txtVallasInvictas.Text);
                nuevoArquero.CantPenalesAtajados = Convert.ToInt32(txtPenalesAtajados.Text);
                nuevoArquero.CantPenalesPateados = Convert.ToInt32(txtTotalPenales.Text);
                equipo.equipo.Add(nuevoArquero);
                ActualizarLst();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan completar datos o alguno de ellos es incorrecto.La creacion del arquero fallo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Hide();
        }
    }
}
