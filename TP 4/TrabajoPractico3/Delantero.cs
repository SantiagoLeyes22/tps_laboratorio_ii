using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class Delantero:Jugador
    {
        private int cantidadGoles;
        private int cantidadRegatesCompletados;
        private int totalRegates;

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura que retorna la cantidad de goles
        /// </summary>
        public int CantidadGoles
        {
            get
            {
                return this.cantidadGoles;
            }
            set
            {
                this.cantidadGoles = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que retorna la cantidad de regates completos
        /// </summary>
        public int CantRegatesCompletos
        {
            get
            {
                return this.cantidadRegatesCompletados;
            }
            set
            {
                this.cantidadRegatesCompletados = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que retorna la cantidad total de regates
        /// </summary>
        public int TotalDeRegates
        {
            get
            {
                return this.totalRegates;
            }
            set
            {
                this.totalRegates = value;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna el porcentaje de regates correctos
        /// </summary>
        public double RegatesCorrectos
        {
            get
            {
                double porcentaje = 0;
                if (totalRegates != 0)
                {
                    porcentaje = CalcularPorcentajes(cantidadRegatesCompletados, totalRegates);
                }
                return porcentaje;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor sin parametros de un delantero
        /// </summary>
        public Delantero()
        {

        }
        /// <summary>
        /// Construtor que asigna los valores de cantidad de goles,cantidad de regates completos y total de regates
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="cantGoles"></param>
        /// <param name="regatesCom"></param>
        /// <param name="totalRegates"></param>
        public Delantero(string nombre,string apellido,int edad,int cantGoles,int regatesCom,int totalRegates):base(nombre,apellido,edad)
        {
            this.cantidadGoles = cantGoles;
            this.cantidadRegatesCompletados = regatesCom;
            this.totalRegates = totalRegates;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra las estadisticas del defensor
        /// </summary>
        /// <returns>String con las estadisticas</returns>
        protected override string MostrarEstadisticas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.apellido}");
            sb.AppendLine($"Cantidad de goles:{this.cantidadGoles}");
            //sb.AppendLine($"Porcentaje de goles:{CalcularPorcentajes(cantidadGoles,10)}%");
            sb.AppendLine($"Porcentaje de regates efectivos:{RegatesCorrectos}%");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga explicita del string que muestra las estadisticas del delantero
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator string(Delantero d)
        {
            return d.MostrarEstadisticas();
        }
        #endregion
    }
}
