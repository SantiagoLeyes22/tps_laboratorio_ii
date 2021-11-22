using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class Mediocampista:Jugador
    {
        private int cantidadPasesCorrectos;
        private int totalPases;
        private double velocidad;
        private int cantidadAsistencias;

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la cantidad de pases correctos
        /// </summary>
        public int CantidadPasesCorrectos
        {
            get
            {
                return this.cantidadPasesCorrectos;
            }
            set
            {
                this.cantidadPasesCorrectos = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la cantidad total de pases
        /// </summary>
        public int TotalPases
        {
            get
            {
                return this.totalPases;
            }
            set
            {
                this.totalPases = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la velocidad
        /// </summary>

        public double Velocidad
        {
            get
            {
                return this.velocidad;
            }
            set
            {
                this.velocidad = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve la cantidad asistencias
        /// </summary>
        public int CantAsistencias
        {
            get
            {
                return this.cantidadAsistencias;
            }
            set
            {
                this.cantidadAsistencias = value;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que devuelve el porcentaje de efectividad de pases
        /// </summary>
        public double EfectividadDePases
        {
            get
            {
                double porcentaje = 0;
                if(totalPases != 0)
                {
                    porcentaje = CalcularPorcentajes(cantidadPasesCorrectos, totalPases);
                }
                return porcentaje;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor sin parametros de mediocampista
        /// </summary>
        public Mediocampista()
        {

        }
        /// <summary>
        /// Asigna la cantidad de pases correctos,velocidad,asistencias y totalidad de pases
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="pasesC"></param>
        /// <param name="totalPases"></param>
        /// <param name="velocidad"></param>
        /// <param name="asistencias"></param>
        public Mediocampista(string nombre,string apellido,int edad,int pasesC,int totalPases,double velocidad,int asistencias):base(nombre,apellido,edad)
        {
            this.cantidadPasesCorrectos = pasesC;
            this.velocidad = velocidad;
            this.cantidadAsistencias = asistencias;
            this.totalPases = totalPases;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra las estidisticas de un mediocampista 
        /// </summary>
        /// <returns>string con estadisticas</returns>
        protected override string MostrarEstadisticas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.apellido}");
            sb.AppendLine($"Porcentaje de efectividad de pases:{EfectividadDePases}%");
            sb.AppendLine($"Asistencias totales:{this.cantidadAsistencias}");
            sb.AppendLine($"Velocidad:{this.velocidad}km p/h");
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga explicita del string que muestra las estadisticas del mediocampista
        /// </summary>
        /// <param name="m"></param>
        public static explicit operator string(Mediocampista m)
        {
            return m.MostrarEstadisticas();
        }
        #endregion
    }
}
