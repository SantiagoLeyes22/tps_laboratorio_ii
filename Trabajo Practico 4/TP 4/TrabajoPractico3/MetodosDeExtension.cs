using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// Retorna datos del equipo
        /// </summary>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static string DatosDelEquipo(this Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();
            if(equipo != null)
            {
                sb.AppendLine($"EQUIPO:!{equipo.nombre}!");
                sb.AppendLine($"");
                sb.AppendLine($"Tecnico: Martin Gonzalez");
                sb.AppendLine($"Cantidad de jugadores:{equipo.equipo.Count}");
            }
            
            return sb.ToString();
        }
    }
}
