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
        public Defensor()
        {

        }
        public Defensor(string nombre, string apellido, int edad, TipoDefensor tipo, int totalQuites, int quitesCorrectos, double distancia) : base(nombre, apellido, edad)
        {
            this.distanciaRecorrida = distancia;
            this.tipo = tipo;
            this.totalQuites = totalQuites;
            this.quitesCorrectos = quitesCorrectos;
        }
        #endregion

        #region Metodos

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

        public static explicit operator string(Defensor d)
        {
            return d.MostrarEstadisticas();
        }
        public override string ToString()
        {
            return $"Defensor:" + this.apellido + " " + this.nombre + ",Edad:" + this.edad;
        }
        #endregion

    }
}
