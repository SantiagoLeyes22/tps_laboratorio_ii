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
        private int cantPenalesAtajados;//Durante toda su carrera
        private int cantPenalesPateados;//Durante toda su carrera

        #region Propiedades

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
        public Arquero()
        {

        }
        public Arquero(string nombre, string apellido, int edad, int vallasI, int cantPA, int pPateados) : base(nombre, apellido, edad)
        {
            this.vallasInvictas = vallasI;
            this.cantPenalesAtajados = cantPA;
            this.cantPenalesPateados = pPateados;
        }
        #endregion

        #region Metodos

        
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
        public static explicit operator string(Arquero a)
        {
            return a.MostrarEstadisticas();
        }
        public override string ToString()
        {
            return $"Arquero:"+this.apellido + " " +this.nombre+",Edad:"+this.edad;
        }
        #endregion
    }
}
