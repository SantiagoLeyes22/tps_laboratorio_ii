using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv: Vehiculo
    {
        /// <summary>
        /// Crea una instancia de Suv con sus datos.
        /// </summary>
        /// <param name="marca">Marca del Suv.</param>
        /// <param name="chasis">Chasis del Suv.</param>
        /// <param name="color">Color del Suv.</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// ReadOnly SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Obtiene todos los datos del Suv y los lista en un string.
        /// </summary>
        /// <returns>Los datos del Suv como string.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
