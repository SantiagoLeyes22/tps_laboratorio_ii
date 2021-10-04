using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        /// <summary>
        /// Enum para indicar si el Sedan 
        /// sera de 4 puertas o de 5 puertas.
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Crea una instancia de Sedan, por defecto TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }

        /// <summary>
        /// Crea una instancia de Sedan seteando todos sus atributos.
        /// </summary>
        /// <param name="marca">Marca del Sedan.</param>
        /// <param name="chasis">Chasis del Sedan.</param>
        /// <param name="color">Color del Sedan.</param>
        /// <param name="tipo">Tipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo): base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano', propiedad ReadOnly
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Obtiene todos los datos del Sedan y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Sedan como string.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
