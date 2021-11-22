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
        private List<Arquero> arqueros = new List<Arquero>();

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormSeleccionarPorHabilidad()
        { 
            InitializeComponent();
        }
        /// <summary>
        /// Constructor con parametros que asigna los valores de equipo, un label y la opcion
        /// </summary>
        /// <param name="e"></param>
        /// <param name="jugadoresCargados"></param>
        public FormSeleccionarPorHabilidad(Equipo equipo,Label nombre,int opcion):this()
        {
            this.opcion = opcion;
            this.auxEquipo = equipo;
            lblNombre = nombre;
            armarListado(opcion);
        }
        /// <summary>
        /// Dependiendo de la opcion llama al listado correspondiente
        /// </summary>
        /// <param name="opcion"></param>
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
        /// <summary>
        /// Agrega un jugador a la formacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    arqueros.Add((Arquero)item);
                    //CrudTitulares.Guardar(new JugadorTitular(item.Nombre,item.Apellido,item.Edad));
                }
            }
        }
        /// <summary>
        /// Arma el listado con solo defensas
        /// </summary>
        private void ArmarListadoDefensas()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Defensor)
                {
                    lstHabilidadesJ.Items.Add((string)(Defensor)item);
                    //CrudTitulares.Guardar(new JugadorTitular(item.Nombre, item.Apellido, item.Edad));
                }
            }
        }
        /// <summary>
        /// Arma el listado con solo mediocampistas
        /// </summary>
        private void ArmarListadoMediocampista()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Mediocampista)
                {
                    lstHabilidadesJ.Items.Add((string)(Mediocampista)item);
                    //CrudTitulares.Guardar(new JugadorTitular(item.Nombre, item.Apellido, item.Edad));
                }
            }
        }
        /// <summary>
        /// Arma el listado con solo delanteros
        /// </summary>
        private void ArmarListadoDelantero()
        {
            lstHabilidadesJ.Items.Clear();
            foreach (Jugador item in auxEquipo.equipo)
            {
                if (item is Delantero)
                {
                    lstHabilidadesJ.Items.Add((string)(Delantero)item);
                    //CrudTitulares.Guardar(new JugadorTitular(item.Nombre, item.Apellido, item.Edad));
                }
            }
        }
    }
}
