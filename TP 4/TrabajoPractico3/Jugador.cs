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

        /// <summary>
        /// Propiedad de lectura y escritura que devuelve un string con el nombre del jugador
        /// </summary>
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
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve un string con el apellido del jugador
        /// </summary>
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
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve un string con la edad del jugador
        /// </summary>
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
        /// <summary>
        /// Propiedad de lectura y escritura que devuelve un entero con la cantidad de partidos jugados
        /// </summary>
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

        /// <summary>
        /// Constructor estatico de jugador que instacia el random edadAlAzar
        /// </summary>
        static Jugador()
        {
            edadAlAzar = new Random();
        }
        /// <summary>
        /// Constructor sin parametros de jugador
        /// </summary>
        public Jugador()
        {

        }
        /// <summary>
        /// Constructor jugador que asigna el nombre,apellido,edad y cantidad de partidos jugados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Jugador(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            Edad = edad;
            this.cantidadPartidosJugados = 10; //valor por defecto
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo abstracto que muestra estadisticas 
        /// </summary>
        /// <returns></returns>
        protected abstract string MostrarEstadisticas();


        /// <summary>
        /// Metodo que calcula porcentajes
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        protected double CalcularPorcentajes(int dato, int total)
        {
            double porcentaje = 0;
            if(total != 0)
            {
                porcentaje = (100 * dato) / total;
            }
            return porcentaje;
        }
        #endregion

        #region Sobrecargas
        
        /// <summary>
        /// Verifica si dos jugadores son iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador a,Jugador b)
        {
            return a.apellido == b.apellido && a.nombre == b.nombre;
        }
        /// <summary>
        /// Verifica que dos jugadores sean diferentes
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Jugador a, Jugador b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Muestra los datos de un jugador
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.GetType().Name.ToUpper()}:" + this.apellido + " " + this.nombre + ",Edad:" + this.edad;
        }
        #endregion
    }
}
