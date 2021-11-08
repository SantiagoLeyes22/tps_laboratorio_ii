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
        public FormAgregarBasic()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
        }
        #endregion


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        public void ActualizarLst()
        {

            this.lstAuxiliar.Items.Clear(); //Limpia el lst

            //Recorre la lista de jugadores y los agrega al lst.
            foreach (Jugador item in this.equipo.equipo)
            {
                this.lstAuxiliar.Items.Add(item.ToString());
            }
        }
    }
}
