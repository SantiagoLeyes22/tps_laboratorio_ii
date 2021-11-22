using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico3;

namespace AppFutbolForm
{
    public partial class FormConsultas : Form
    {
        public Equipo equipoConsultas;
        private Delantero delantero = new Delantero();
        private Mediocampista mediocampista = new Mediocampista();
        private Defensor defensor = new Defensor();
        private static Random random;
        private int flagCalculando = 0;
        private int PoderSalir = 0;
      
        public FormConsultas(Equipo equipo)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            random = new Random();
            InitializeComponent();
            this.equipoConsultas = equipo;
            rtbTexto.Text = ArmarConsulta();
        }

        #region Metodos
        public string ArmarConsulta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----COSULTAS TOTALES DEL EQUIPO-----");
            sb.AppendLine("");
            sb.AppendLine("Seleccione mediante los botones el dato que desea consultar:");

            //Implemento el metodo de extension
            sb.AppendLine(this.equipoConsultas.DatosDelEquipo());
            sb.AppendLine("");
            return sb.ToString();
        }

        public string ArmarConsultaGoles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El equipo realizo un total de {totalGoles} goles");
            sb.AppendLine($"El equipo tiene un promedio de {PromedioGolPorPartido} goles por partido");
            sb.AppendLine($"El judador que mas golez hizo es {MejorGoleador}");
            sb.AppendLine($"La edad promedio de los delanteros del equipo es: {DelanterosEdadPromedio}");
            return sb.ToString();
        }
        public string ArmarConsultaQuites()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Se realizaron un total de {totalQuites} quites");
            sb.AppendLine($"De los cuales un {PorcentajeDeQutes}% fueron correctos");
            sb.AppendLine($"El defensor que obtuvo el mayor porcentaje de quites correctos es: {MejorQuitador}");
            sb.AppendLine($"El defensor que obtuvo el menor porcentaje de quites correctos es: {PeorQuitador}");
            return sb.ToString();
        }
        public string ArmarConsulPases()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Se realizaron un total de {TotalPases} pases");
            sb.AppendLine($"De los cuales un {PorcentajeDePases}% fueron correctos");
            sb.AppendLine($"El mediocampista que obtuvo el mayor porcentaje de pases correctos es: {MejorPasador}");
            sb.AppendLine($"De los {TotalPases} pases {TotalAsistencias} fueron asistencias que terminaron en gol");
            return sb.ToString();
        }
        private double CalcularPorcentajes(int dato, int total)
        {
            double porcentaje = 0;
            if (total != 0)
            {
                porcentaje = (100 * dato) / total;
            }
            return porcentaje;
        }
        #endregion

        #region Propiedades
        public double DelanterosEdadPromedio
        {
            get
            {
                double promedio = 0;
                int sumaEdades = 0;
                int cantDelanteros = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Delantero)
                    {
                        delantero = (Delantero)item;
                        sumaEdades = delantero.Edad + sumaEdades;
                        cantDelanteros++;
                    }
                }
                if(cantDelanteros != 0)
                {
                    promedio = sumaEdades / cantDelanteros;
                }
                return promedio;
            }
        }
        public string MejorGoleador
        {
            get
            {
                string nombre = "";
                int cantGoles = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Delantero)
                    {
                        delantero = (Delantero)item;
                        if(delantero.CantidadGoles > cantGoles)
                        {
                            nombre = $"{delantero.Nombre},{delantero.Apellido} con un total de {delantero.CantidadGoles} goles";
                            cantGoles = delantero.CantidadGoles;
                        }
                    }
                }
                return nombre;
            }
        }
        public double PromedioGolPorPartido
        {
            get
            {
                
                double promedio = (double)totalGoles / 50;//50 cantidad de goles establecida por defecto
                return promedio;
            }
        }
        public int totalQuites
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Defensor)
                    {
                        defensor = (Defensor)item;
                        total = defensor.TotalQuites + total;
                    }
                }
                return total;
            }
        }
        public int totalQuitesCorrectos
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Defensor)
                    {
                        defensor = (Defensor)item;
                        total = defensor.QuitesCorrectos + total;
                    }
                }
                return total;
            }
        }
        public string MejorQuitador
        {
            get
            {
                string nombre = "";
                double quites = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Defensor)
                    {
                        defensor = (Defensor)item;
                        if (defensor.PorcentajeQuitesCorrectos >= quites)
                        {
                            nombre = $"{defensor.Nombre},{ defensor.Apellido},Porcentaje:{defensor.PorcentajeQuitesCorrectos}%";
                            quites = defensor.PorcentajeQuitesCorrectos;
                        }
                    }
                }
                return nombre;
            }
        }
        public string PeorQuitador
        {
            get
            {
                string nombre = "";
                double quites = 500;
                
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Defensor)
                    {
                        defensor = (Defensor)item;
                        if (quites > defensor.PorcentajeQuitesCorrectos)
                        {
                            nombre = $"{defensor.Nombre},{defensor.Apellido} Porcentaje:{defensor.PorcentajeQuitesCorrectos}%";
                            quites = defensor.PorcentajeQuitesCorrectos;
                        }
                    }
                }
                return nombre;
            }
        }
        public int totalGoles
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Delantero)
                    {
                        delantero = (Delantero)item;
                        total = delantero.CantidadGoles + total;
                    }
                }
                return total;
            }
        }
        public int TotalPases
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Mediocampista)
                    {
                        mediocampista = (Mediocampista)item;
                        total = mediocampista.TotalPases + total;
                    }
                }
                return total;
            }
        }
        public int TotalAsistencias
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Mediocampista)
                    {
                        mediocampista = (Mediocampista)item;
                        total = mediocampista.CantAsistencias + total;
                    }
                }
                return total;
            }
        }
        public int TotalPasesCorrectos
        {
            get
            {
                int total = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Mediocampista)
                    {
                        mediocampista = (Mediocampista)item;
                        total = mediocampista.CantidadPasesCorrectos + total;
                    }
                }
                return total;
            }
        }
        public string MejorPasador
        {
            get
            {
                string nombre = "";
                double pPases = 0;
                foreach (Jugador item in equipoConsultas.equipo)
                {
                    if (item is Mediocampista)
                    {
                        mediocampista = (Mediocampista)item;
                        if(mediocampista.EfectividadDePases >= pPases)
                        {
                            nombre = $"{ mediocampista.Nombre},{ mediocampista.Apellido},Porcentaje:{mediocampista.EfectividadDePases}%";
                            pPases = mediocampista.EfectividadDePases;
                        }
                    }
                }
                return nombre;
            }
        }
        public double PorcentajeDePases
        {
            get
            {
                return CalcularPorcentajes(TotalPasesCorrectos,TotalPases);
            }
        }
        public double PorcentajeDeQutes
        {
            get
            {
                return CalcularPorcentajes(totalQuitesCorrectos, totalQuites);
            }
        }
        #endregion

        #region Botones
        private void btnPPASES_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (flagCalculando == 1)
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine(ArmarConsulPases());
                rtbTexto.Text = sb.ToString();
            }
            else
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine("Espere!!! se estan realizando los calculos de las consultas");
                rtbTexto.Text = sb.ToString();
            }
            
        }
        private void btnPQuites_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (flagCalculando !=0)
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine(ArmarConsultaQuites());
                rtbTexto.Text = sb.ToString();
            }
            else
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine("Espere!!! se estan realizando los calculos de las consultas");
                rtbTexto.Text = sb.ToString();
            }
        }

        private void btnPGoles_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if(flagCalculando != 0)
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine(ArmarConsultaGoles());
                rtbTexto.Text = sb.ToString();
            }
            else
            {
                sb.AppendLine(ArmarConsulta());
                sb.AppendLine("Espere!!! se estan realizando los calculos de las consultas");
                rtbTexto.Text = sb.ToString();
            }
        }
        #endregion

        #region HiloYdelegado
        private void FormConsultas_Load(object sender, EventArgs e)
        {
            //creo el hilo
            Task task = new Task(() => IniciarProceso(progressConsulta, lblPorcentajeProgreso));
            //arrancamos el hilo
            task.Start();
            
        }

        /// <summary>
        /// Inicia el proceso de la progressBar ademas ejecuta el evento
        /// </summary>
        /// <param name="barraProgreso"></param>
        /// <param name="label"></param>
        private void IniciarProceso(ProgressBar barraProgreso, Label label)
        {
            try
            {
                while (barraProgreso.Value < barraProgreso.Maximum)
                {
                    Thread.Sleep(random.Next(50, 100));
                    IncrementarBarraProgreso(barraProgreso, label);
                }
                flagCalculando = 1;
                calculosFinalizados += mostrarAvisoEstado;
                if (calculosFinalizados is not null)
                {
                    //invocamos el evento
                    calculosFinalizados.Invoke();
                }
                PoderSalir = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error");
            }
            
        }
        /// <summary>
        /// Incrementa la barra de progreso
        /// </summary>
        /// <param name="barraProgreso"></param>
        /// <param name="label"></param>
        private void IncrementarBarraProgreso(ProgressBar barraProgreso, Label label)
        {
            //pregunta si el invocador debe llamar al hilo original de windows form
            if (InvokeRequired)
            {
                //para utilizar el invoke voy a necesitar un delegado asique lo creo 
                Action<ProgressBar, Label> delegado = IncrementarBarraProgreso;
                //le paso el delegado al invoke pero antes le tenemos que pasar los objetos mediante array objets
                object[] parametros = new object[] { barraProgreso, label };
                Invoke(delegado, parametros);

            }
            else
            {
                barraProgreso.Increment(1);
                label.Text = $"{barraProgreso.Value}%";
            }
        }
        #endregion

        #region Evento

        /// <summary>
        /// Delegado sin parametros que notifica un estado
        /// </summary>
        public delegate void NotificarEstado();

        /// <summary>
        /// Evento que notifica un estado
        /// </summary>
        public event NotificarEstado calculosFinalizados;

        //Metodo manejador

        /// <summary>
        /// Metodo manejador que se encarga de mostrar la 
        /// </summary>
        public void mostrarAvisoEstado()
        {
             MessageBox.Show("Realizacion de los calculos finalizada!!! Consultas ya disponibles!!!");
        }
        #endregion

        /// <summary>
        /// Controla el cierre del formulario FormConsulta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(PoderSalir == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Para poder salir primero deben terminarse los calculos");
            }
        }
    }
}
