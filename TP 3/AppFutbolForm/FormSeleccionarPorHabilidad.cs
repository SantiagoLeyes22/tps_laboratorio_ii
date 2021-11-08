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
    public partial class FormSeleccionarPorHabilidad : Form
    {
        private Equipo auxEquipo;
        private Label lblNombre;
        private int opcion;
        
        public FormSeleccionarPorHabilidad()
        { 
            InitializeComponent();
        }
        public FormSeleccionarPorHabilidad(Equipo equipo,Label nombre,int opcion):this()
        {
            this.opcion = opcion;
            this.auxEquipo = equipo;
            lblNombre = nombre;
            armarListado(opcion);
        }

        public void armarListado(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    ArmarListadoArqueros();
                    break;
                case 2:
                    ArmarListadoDefensas();
                    break;
                case 3:
                    ArmarListadoMediocampista();
                    break;
                case 4:
                    ArmarListadoDelantero();
                    break;
                default:
                    break;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Jugador a = new Arquero();
            if(lstHabilidadesJ.SelectedItem != null)
            {
                a.Apellido = lstHabilidadesJ.SelectedItem.ToString();
                lblNombre.Text = a.Apellido;
            }
            else
            {
                MessageBox.Show("Para agregar un jugador a la formacion primero debe seleccionarlo");
            }
       
          
            this.Close();
        }
        /// <summary>
        /// Llena el list Box con los jugadores de la posicion solicitada
        /// </summary>
        /// <returns></returns>
        private void ArmarListadoArqueros()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if(item is Arquero)
                {
                    lstHabilidadesJ.Items.Add((string)(Arquero)item);
                }
            }
        }
        private void ArmarListadoDefensas()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Defensor)
                {
                    lstHabilidadesJ.Items.Add((string)(Defensor)item);
                }
            }
        }
        private void ArmarListadoMediocampista()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Mediocampista)
                {
                    lstHabilidadesJ.Items.Add((string)(Mediocampista)item);
                }
            }
        }
        private void ArmarListadoDelantero()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Delantero)
                {
                    lstHabilidadesJ.Items.Add((string)(Delantero)item);
                }
            }
        }
    }
}
