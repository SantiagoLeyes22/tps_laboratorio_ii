using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class Arquero:Jugador
    {
        private int vallasInvictas;
        private int cantPenalesAtajados;
        private int cantPenalesPateados;

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura que muestra el porcentaje de vallas invictas
        /// </summary>
        public double PorcentajeVallasInvictas
        {
            get
            {
                double porcentaje = 0;
                if(cantidadPartidosJugados !=0)
                {
                    porcentaje = CalcularPorcentajes(vallasInvictas, this.cantidadPartidosJugados);
                }
                return porcentaje;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que muestra la efectivad en penales
        /// </summary>
        public double EfectivadEnPenales
        {
            get
            {
                double porcentaje = 0;
                if(cantPenalesAtajados <= cantPenalesPateados && cantPenalesPateados !=0)
                {
                    porcentaje = CalcularPorcentajes(cantPenalesAtajados, cantPenalesPateados);
                }
                return porcentaje;
            }
        }
        /// <summary>
        /// Propiedad que devuelve la cantidad de vallas invictas
        /// Tambien permite asignar el valor de vallas invictas
        /// </summary>
        public int CantVallasInvictas
        {
            get
            {
                return this.vallasInvictas;
            }
            set
            {
                this.vallasInvictas = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la cantidad de penales pateados,tambien
        /// permite asignar un valor
        /// </summary>
        public int CantPenalesAtajados
        {
            get
            {
                return this.cantPenalesAtajados;
            }
            set
            {
                this.cantPenalesAtajados = value;
            }
        }
        
        /// <summary>
        /// Propiedad que devuelve la cantidad de penales pateados
        /// Permite asignar un valor de penales pateados
        /// </summary>
        public int CantPenalesPateados
        {
            get
            {
                return this.cantPenalesPateados;
            }
            set
            {
                this.cantPenalesPateados = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Arquero()
        {

        }
        /// <summary>
        /// Constructor de Arquero con parametros
        /// Asigna la cantidad de vallas invictas,cantidad de penales atajados y pateados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="vallasI"></param>
        /// <param name="cantPA"></param>
        /// <param name="pPateados"></param>
        public Arquero(string nombre, string apellido, int edad, int vallasI, int cantPA, int pPateados) : base(nombre, apellido, edad)
        {
            this.vallasInvictas = vallasI;
            this.cantPenalesAtajados = cantPA;
            this.cantPenalesPateados = pPateados;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra las estadisticas
        /// </summary>
        /// <returns>Devuelve una cadena con las estadisticas</returns>
        protected override string MostrarEstadisticas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.apellido}");
            sb.AppendLine($"Porcentaje de vallas invictas:{PorcentajeVallasInvictas}%");
            sb.AppendLine($"Efectivdad en penales:{EfectivadEnPenales}%");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga explicita para que el operador string devuelva las estadisticas de los jugadores
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator string(Arquero a)
        {
            return a.MostrarEstadisticas();
        }
       
   
        #endregion
    }
}
