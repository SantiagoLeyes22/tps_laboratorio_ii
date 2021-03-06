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
    public partial class FormAgregarBase : Form
    {
        private Equipo equipo = new Equipo(22,"dsadf"); //No si esta bien 
        private ListBox lstAuxiliar = new ListBox();
        #region Constructores
        /// <summary>
        /// Form sin parametros agregarBase
        /// </summary>
        public FormAgregarBase()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
            this.cmbPosicion.Items.AddRange(new object[] { TipoPosicion.Arquero, TipoPosicion.Defensor, TipoPosicion.Mediocampista, TipoPosicion.Delantero });
            //this.cmbPosicion.SelectedIndex = 0;
            this.cmbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Constructor con parametros que asigna los valores de un equipo y un ListBox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="jugadoresCargados"></param>
        public FormAgregarBase(Equipo e, ListBox jugadoresCargados) : this()
        {
            equipo = e;
            lstAuxiliar = jugadoresCargados;
        }
        #endregion

        /// <summary>
        /// Dependiendo del indice seleccionado redirecciona al formulario correcto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            switch (cmbPosicion.SelectedIndex)
            {
                case 0:
                    FormAgregarArquero frmAgregarArquero = new FormAgregarArquero(equipo,lstAuxiliar);
                    frmAgregarArquero.Show();
                    break;
                case 1:
                    FormAgregarDefensor frmAgregarDefensor = new FormAgregarDefensor(equipo, lstAuxiliar);
                    frmAgregarDefensor.Show();
                    break;
                case 2:
                    FormAgregarMediocampista frmAgregarMediocampista = new FormAgregarMediocampista(equipo, lstAuxiliar);
                    frmAgregarMediocampista.Show();
                    break;
                case 3:
                    FormAgregarDelantero frmAgregarDelantero = new FormAgregarDelantero(equipo, lstAuxiliar);
                    frmAgregarDelantero.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
