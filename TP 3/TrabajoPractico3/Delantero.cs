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
        public Delantero()
        {

        }
        public Delantero(string nombre,string apellido,int edad,int cantGoles,int regatesCom,int totalRegates):base(nombre,apellido,edad)
        {
            this.cantidadGoles = cantGoles;
            this.cantidadRegatesCompletados = regatesCom;
            this.totalRegates = totalRegates;
        }
        #endregion

        #region Metodos
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
        public static explicit operator string(Delantero d)
        {
            return d.MostrarEstadisticas();
        }
        public override string ToString()
        {
            return $"Delantero:" + this.apellido + " " + this.nombre + ",Edad:" + this.edad;
        }
        #endregion
    }
}
