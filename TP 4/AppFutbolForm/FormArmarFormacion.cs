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
    public partial class FormArmarFormacion : Form
    {
        private Equipo auxEquipo;
        private ListBox auxLstJugadores;
        private int flagBd = 0;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormArmarFormacion()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
        }
        /// <summary>
        /// Constructor con parametros que asigna los valores de equipo y un listBox
        /// </summary>
        /// <param name="equipo"></param>
        /// <param name="lstJugadores"></param>
        public FormArmarFormacion(Equipo equipo, ListBox lstJugadores):this()
        {
            this.auxEquipo = equipo;
            this.auxLstJugadores = lstJugadores;
        }
        public FormArmarFormacion(Equipo equipo, ListBox lstJugadores,int flag) : this(equipo,lstJugadores)
        {
            flagBd = flag;
        }


        #region BotonesDeLaFormacion
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un arquero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArquero_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmArquero = new FormSeleccionarPorHabilidad(auxEquipo, lblArquero, 1);
            frmArquero.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un defensor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDfc2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmDefensa2 = new FormSeleccionarPorHabilidad(auxEquipo, lblDefensa2, 2);
            frmDefensa2.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un defensor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDfc1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmDefensa1 = new FormSeleccionarPorHabilidad(auxEquipo, lblDefensa1, 2);
            frmDefensa1.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLateralD_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmLd = new FormSeleccionarPorHabilidad(auxEquipo, lblLateralDerecho, 2);
            frmLd.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLateralIzquierdo_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmLi = new FormSeleccionarPorHabilidad(auxEquipo, lblDefenzaIzquierdo, 2);
            frmLi.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un mediocampista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedioIzquierdo_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmMi = new FormSeleccionarPorHabilidad(auxEquipo, lblMedioIzquierdo, 3);
            frmMi.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un mediocampista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMediocentro1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmM1 = new FormSeleccionarPorHabilidad(auxEquipo, lblMediocentro1, 3);
            frmM1.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un mediocampista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMediocentro2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmM2 = new FormSeleccionarPorHabilidad(auxEquipo, lblMediocentro2, 3);
            frmM2.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un mediocampista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedioDerecho_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmMd = new FormSeleccionarPorHabilidad(auxEquipo, lblMedioDerecho, 3);
            frmMd.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un delantero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelantero2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmD2 = new FormSeleccionarPorHabilidad(auxEquipo, lblDelantero2, 4);
            frmD2.Show();
        }
        /// <summary>
        /// Abre el formulario seleccionar habilidad para mostrar las estadisticas de un delantero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelantero1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmD1 = new FormSeleccionarPorHabilidad(auxEquipo, lblDelantero1, 4);
            frmD1.Show();
        }
        /// <summary>
        /// Limpia la formacion para volver a empezar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está eliminar todo el equipo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rta == DialogResult.OK)
            {
                lblArquero.Text = "";
                lblDefensa1.Text = "";
                lblDefensa2.Text = "";
                lblDefenzaIzquierdo.Text = "";
                lblLateralDerecho.Text = "";
                lblMediocentro1.Text = "";
                lblMediocentro2.Text = "";
                lblMedioDerecho.Text = "";
                lblMedioIzquierdo.Text = "";
                lblDelantero1.Text = "";
                lblDelantero2.Text = "";
            }
        }
        /// <summary>
        /// Sale del form armar formacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Envia un mensaje preguntando al usuario si desea salir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormArmarFormacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region BaseDeDatos
        private void btnEliminarDeBD_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtIdEliminar.Text) == false)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro que desea eliminar este jugador de la base de datos?", "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (rta == DialogResult.OK)
                {
                    CrudTitulares.eliminar(Convert.ToInt32(txtIdEliminar.Text));
                    dtgvTitulares.DataSource = CrudTitulares.Leer();
                }
                
            }
            else
            {
                MessageBox.Show("Para borrar el jugador de la base primero ingrese su ID");
            }
        }
        #endregion

        private void FormArmarFormacion_Load(object sender, EventArgs e)
        {
            if(flagBd != 0)
            {
                dtgvTitulares.DataSource = CrudTitulares.Leer();
            }
        }

        #region validar
        private void txtIdEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
