using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public enum TipoDefensor
    {
        LateralIzquierdo,Central,LateralDerecho
    }
    public class Defensor:Jugador
    {
        private double distanciaRecorrida;
        private TipoDefensor tipo;
        private int totalQuites;
        private int quitesCorrectos;

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la distancia recorrida
        /// </summary>
        public double DistanciaRecorrida
        {
            get
            {
                return this.distanciaRecorrida;
            }
            set
            {
                this.distanciaRecorrida = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve el Tipo de defensor
        /// </summary>
        public TipoDefensor Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que retorna un entero con el total de quites
        /// </summary>
        public int TotalQuites
        {
            get
            {
                return this.totalQuites;
            }
            set
            {
                this.totalQuites = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que retorna un entero con la cantidad de quites correctos
        /// </summary>
        public int QuitesCorrectos
        {
            get
            {
                return this.quitesCorrectos;
            }
            set
            {
                this.quitesCorrectos = value;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna el porcentaje de quites correctos
        /// </summary>
        public double PorcentajeQuitesCorrectos
        {
            get
            {
                double porcentaje = 0;
                if(totalQuites != 0)
                {
                    porcentaje = CalcularPorcentajes(quitesCorrectos, totalQuites);
                }
                return porcentaje;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de defensor sin parametros
        /// </summary>
        public Defensor()
        {

        }
        /// <summary>
        /// Constructor de defensor que asigna los valores de distancia recorrida,tipo,total de quites y quites correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="tipo"></param>
        /// <param name="totalQuites"></param>
        /// <param name="quitesCorrectos"></param>
        /// <param name="distancia"></param>
        public Defensor(string nombre, string apellido, int edad, TipoDefensor tipo, int totalQuites, int quitesCorrectos, double distancia) : base(nombre, apellido, edad)
        {
            this.distanciaRecorrida = distancia;
            this.tipo = tipo;
            this.totalQuites = totalQuites;
            this.quitesCorrectos = quitesCorrectos;
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
            sb.AppendLine($"Distancia recorrida:{this.distanciaRecorrida}km");
            sb.AppendLine($"Porcentaje de quites efectivos:{PorcentajeQuitesCorrectos}%");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga explicita del string que muestra las estadisticas del defensor
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator string(Defensor d)
        {
            return d.MostrarEstadisticas();
        }
        
        #endregion

    }
}
