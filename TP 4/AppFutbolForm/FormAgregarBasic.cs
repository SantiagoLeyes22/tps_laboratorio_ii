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
    public partial class FormAgregarBasic : Form
    {
        protected Equipo equipo;
        protected ListBox lstAuxiliar = new ListBox();

        #region Constructores
        /// <summary>
        /// Constructor sin parametros 
        /// </summary>
        public FormAgregarBasic()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
            this.cmbPosicion.Items.AddRange(new object[] { TipoPosicion.Arquero, TipoPosicion.Defensor, TipoPosicion.Mediocampista, TipoPosicion.Delantero });
            //this.cmbPosicion.SelectedIndex = 0;
            this.cmbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public FormAgregarBasic(Equipo e,ListBox lst):this()
        {
            equipo = e;
            lstAuxiliar = lst;
        }
        #endregion


        /// <summary>
        /// Boton agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Actualiza los elementos del ListBox
        /// </summary>
        public void ActualizarLst()
        {

            this.lstAuxiliar.Items.Clear(); //Limpia el lst

            //Recorre la lista de jugadores y los agrega al lst.
            foreach (Jugador item in this.equipo.equipo)
            {
                this.lstAuxiliar.Items.Add(item.ToString());
            }
        }

        private void cmbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            switch (cmbPosicion.SelectedIndex)
            {
                case 0:
                    FormAgregarArquero frmAgregarArquero = new FormAgregarArquero(equipo, lstAuxiliar);
                    frmAgregarArquero.txtNombreP.Text = txtNombreP.Text;
                    frmAgregarArquero.txtApellidoP.Text = txtApellidoP.Text;
                    frmAgregarArquero.txtCantPatidosJugadosP.Text = txtCantPatidosJugadosP.Text;
                    frmAgregarArquero.txtEdadP.Text = txtEdadP.Text;
                    frmAgregarArquero.Show();
                    break;
                case 1:
                    FormAgregarDefensor frmAgregarDefensor = new FormAgregarDefensor(equipo, lstAuxiliar);
                    frmAgregarDefensor.txtNombreP.Text = txtNombreP.Text;
                    frmAgregarDefensor.txtApellidoP.Text = txtApellidoP.Text;
                    frmAgregarDefensor.txtCantPatidosJugadosP.Text = txtCantPatidosJugadosP.Text;
                    frmAgregarDefensor.txtEdadP.Text = txtEdadP.Text;
                    frmAgregarDefensor.Show();
                    break;
                case 2:
                    FormAgregarMediocampista frmAgregarMediocampista = new FormAgregarMediocampista(equipo, lstAuxiliar);
                    frmAgregarMediocampista.txtNombreP.Text = txtNombreP.Text;
                    frmAgregarMediocampista.txtApellidoP.Text = txtApellidoP.Text;
                    frmAgregarMediocampista.txtCantPatidosJugadosP.Text = txtCantPatidosJugadosP.Text;
                    frmAgregarMediocampista.txtEdadP.Text = txtEdadP.Text;
                    frmAgregarMediocampista.Show();
                    break;
                case 3:
                    FormAgregarDelantero frmAgregarDelantero = new FormAgregarDelantero(equipo, lstAuxiliar);
                    frmAgregarDelantero.txtNombreP.Text = txtNombreP.Text;
                    frmAgregarDelantero.txtApellidoP.Text = txtApellidoP.Text;
                    frmAgregarDelantero.txtCantPatidosJugadosP.Text = txtCantPatidosJugadosP.Text;
                    frmAgregarDelantero.txtEdadP.Text = txtEdadP.Text;
                    frmAgregarDelantero.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
