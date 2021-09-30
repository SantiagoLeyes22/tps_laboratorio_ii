using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Enumerado con las posibles marcas del vehiculo.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumarado con los posibles tamaños del vehiculo.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// Constructor de vehiculo con sus datos.
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo.</param>
        /// <param name="marca">Marca del vehiculo.</param>
        /// <param name="color">Color del vehiculo.</param>
        public Vehiculo(string chasis,EMarca marca,ConsoleColor color)
        {
            this.chasis = chasis;
            this.color = color;
            this.marca = marca;
        }
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Retorna la informacion de un vehiculo mediante un StringBuilder
        /// </summary>
        /// <param name="p">Vehiculo del cual se obtendran los datos</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{p.GetType().Name.ToUpper()}");
            sb.AppendLine(string.Format("CHASIS: {0}\r", p.chasis));
            sb.AppendLine(string.Format("MARCA : {0}\r", p.marca.ToString()));
            sb.AppendLine(string.Format("COLOR : {0}\r", p.color.ToString()));
            sb.AppendLine("---------------------");
            sb.AppendLine(string.Format("TAMAÑO : {0}", p.Tamanio));

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
