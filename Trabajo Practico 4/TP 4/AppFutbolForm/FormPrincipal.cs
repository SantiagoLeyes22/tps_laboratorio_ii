using System;
using System.Windows.Forms;
using TrabajoPractico3;

namespace AppFutbolForm
{
    public partial class FormPrincipal : Form
    {
        public Equipo jugadores;
        int flag = 0;
        int flagBd = 0;


        /// <summary>
        /// Constructor sin parametros del FormPrincipal, instancia un equipo
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
            jugadores = new Equipo(20, "Los leones de Villa Crespo");
        }

        /// <summary>
        /// Agrega un jugador al equipo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarBase frmAgregar = new FormAgregarBase(jugadores,this.lstJugadores);
            frmAgregar.Show();
            this.ActualizarLst();
        }

        /// <summary>
        /// Guarda el equipo en un archivo Xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();

            path.Filter = "Archivos XML|*.xml|Todos los archivos|*.*"; //Se agregan filtros

            try
            {
                if (path.ShowDialog() == DialogResult.OK)
                {
                    Equipo.Escribir(this.jugadores, path.FileName); //Escribe los datos

                    MessageBox.Show($"Se guardaron los datos en {path.FileName}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = 1;
                }
            }
            catch (FileException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga un equipo mediante un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();

            try
            {
                if (path.ShowDialog() == DialogResult.OK)
                {
                    this.jugadores = Equipo.Leer(path.FileName); //Lee los datos y los deserializa en la Fabrica.
                    this.Text = "EQUIPO: " + this.jugadores.nombre; //Cambia el nombre de la ventana de form

                    MessageBox.Show("Se cargó el archivo correctamente!", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flagBd = 1;
                }
            }
            catch (FileException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.ActualizarLst(); //Actualiza
        }
        /// <summary>
        /// Actualiza los datos del listBox
        /// </summary>
        public void ActualizarLst()
        {

            this.lstJugadores.Items.Clear(); //Limpia el lst
            
            //Recorre la lista de jugadores y los agrega al lst.
            foreach (Jugador item in this.jugadores.equipo)
            {
                this.lstJugadores.Items.Add(item.ToString());
            }
        }
        /// <summary>
        /// Evento formClosing, advierte al usuario que guarde antes de salir de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            int eliminar;
            if (flag ==0)
            {
                DialogResult rta = MessageBox.Show("¿Está seguro de salir? No se registran datos guardados", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (rta == DialogResult.Cancel)
                {
                    
                    e.Cancel = true;
                }
                if (rta == DialogResult.OK)
                {
                    //si el usuario no guardo los datos borrame de la bd el que creo 
                    //antes de activar esto eliminar los jugadores de la base que estan de mas. 
                    eliminar = lstJugadores.Items.Count;
                    //CrudTitulares.eliminar(eliminar);
                }
            }
            
        }
        /// <summary>
        /// FormLoad actualiza constantemente el listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.ActualizarLst();
        }

        /// <summary>
        /// Elimina un jugador previamente seleccionado en el ListView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea eliminar este jugador?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (rta == DialogResult.OK)
                {
                    jugadores.equipo.RemoveAt(lstJugadores.SelectedIndex);
                }
                this.ActualizarLst();
            }
            catch (Exception)
            {
                MessageBox.Show("Para eliminar debe seleccionar un jugador de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        /// <summary>
        /// Abre el formulario para armar la formacion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArmarFormacion_Click(object sender, EventArgs e)
        {
            FormArmarFormacion frmArmarF = new FormArmarFormacion(jugadores,lstJugadores,flagBd);
            frmArmarF.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FormConsultas frmConsultas = new FormConsultas(jugadores);
            frmConsultas.Show();
        }
    }
}
