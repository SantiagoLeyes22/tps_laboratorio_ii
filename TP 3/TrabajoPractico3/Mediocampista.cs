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

        public Mediocampista()
        {

        }
        public Mediocampista(string nombre,string apellido,int edad,int pasesC,int totalPases,double velocidad,int asistencias):base(nombre,apellido,edad)
        {
            this.cantidadPasesCorrectos = pasesC;
            this.velocidad = velocidad;
            this.cantidadAsistencias = asistencias;
            this.totalPases = totalPases;
        }
        #endregion

        #region Metodos
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
        public static explicit operator string(Mediocampista m)
        {
            return m.MostrarEstadisticas();
        }
        public override string ToString()
        {
            return $"Mediocampista:" + this.apellido + " " + this.nombre + ",Edad:" + this.edad;
        }
        #endregion
    }
}
