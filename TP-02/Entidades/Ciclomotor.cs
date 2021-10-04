using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Crea una instancia de Ciclomotor con sus datos.
        /// </summary>
        /// <param name="marca">Marca del Ciclomotor.</param>
        /// <param name="chasis">Chasis del Ciclomotor.</param>
        /// <param name="color">Color del Ciclomotor.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// Propiedad ReadOnly
        /// </summary>
        public override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Obtiene todos los datos del Ciclomotor y los lista en un String.
        /// </summary>
        /// <returns>Los datos del Ciclomotor como string.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
