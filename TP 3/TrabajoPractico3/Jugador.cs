using System.Text;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace TrabajoPractico3
{
    public enum TipoPosicion
    {
        Arquero,Defensor,Mediocampista,Delantero
    }
    [XmlInclude(typeof(Arquero))]
    [XmlInclude(typeof(Defensor))]
    [XmlInclude(typeof(Mediocampista))]
    [XmlInclude(typeof(Delantero))]
    public abstract class Jugador
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected static Random edadAlAzar;
        protected int cantidadPartidosJugados;

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if(value >17 && value <40)
                {
                    this.edad = value;
                }
                else
                {
                    this.edad = edadAlAzar.Next(17, 40);
                }
            }
        }
        public int CantidadPartidosJugados
        {
            get
            {
                return this.cantidadPartidosJugados;
            }
            set
            {
                this.cantidadPartidosJugados = value;
            }
        }
        #endregion

        #region Constructores

        static Jugador()
        {
            edadAlAzar = new Random();
        }
        public Jugador()
        {

        }
        public Jugador(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            Edad = edad;
            this.cantidadPartidosJugados = 10; //valor por defecto
        }
        #endregion

        #region Metodos
        protected abstract string MostrarEstadisticas();

        public string MostrarJugador()
        {
            return $"{this.GetType().Name.ToUpper()},Nombre:{this.nombre},Apellido{this.apellido},Edad:{this.edad}";
        }

        protected double CalcularPorcentajes(int dato, int total)
        {
            //FORMULA: total.x = dato.100 => X = (dato.100)/total
            double porcentaje = 0;
            if(total != 0)
            {
                porcentaje = (100 * dato) / total;
            }
            return porcentaje;
        }
        #endregion

        #region Sobrecargas
        
        public static bool operator ==(Jugador a,Jugador b)
        {
            return a.apellido == b.apellido && a.nombre == b.nombre;
        }
        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }
        #endregion
    }
}
