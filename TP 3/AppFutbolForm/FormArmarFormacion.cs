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
        public FormArmarFormacion()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
        }
        public FormArmarFormacion(Equipo equipo, ListBox lstJugadores):this()
        {
            this.auxEquipo = equipo;
            this.auxLstJugadores = lstJugadores;
        }

        private void btnArquero_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmArquero = new FormSeleccionarPorHabilidad(auxEquipo,lblArquero,1);
            frmArquero.Show();
        }

        private void btnDfc2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmDefensa2 = new FormSeleccionarPorHabilidad(auxEquipo, lblDefensa2, 2);
            frmDefensa2.Show();
        }

        private void btnDfc1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmDefensa1 = new FormSeleccionarPorHabilidad(auxEquipo, lblDefensa1, 2);
            frmDefensa1.Show();
        }

        private void btnLateralD_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmLd = new FormSeleccionarPorHabilidad(auxEquipo,lblLateralDerecho, 2);
            frmLd.Show();
        }

        private void btnLateralIzquierdo_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmLi = new FormSeleccionarPorHabilidad(auxEquipo, lblDefenzaIzquierdo, 2);
            frmLi.Show();
        }

        private void btnMedioIzquierdo_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmMi = new FormSeleccionarPorHabilidad(auxEquipo,lblMedioIzquierdo, 3);
            frmMi.Show();
        }

        private void btnMediocentro1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmM1 = new FormSeleccionarPorHabilidad(auxEquipo,lblMediocentro1, 3);
            frmM1.Show();
        }

        private void btnMediocentro2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmM2 = new FormSeleccionarPorHabilidad(auxEquipo, lblMediocentro2, 3);
            frmM2.Show();
        }

        private void btnMedioDerecho_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmMd = new FormSeleccionarPorHabilidad(auxEquipo,lblMedioDerecho, 3);
            frmMd.Show();
        }

        private void btnDelantero2_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmD2 = new FormSeleccionarPorHabilidad(auxEquipo, lblDelantero2, 4);
            frmD2.Show();
        }

        private void btnDelantero1_Click(object sender, EventArgs e)
        {
            FormSeleccionarPorHabilidad frmD1 = new FormSeleccionarPorHabilidad(auxEquipo, lblDelantero1, 4);
            frmD1.Show();
        }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArmarFormacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
