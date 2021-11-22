using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class FileException :Exception
    {
        /// <summary>
        /// Constructor con parametro string
        /// </summary>
        /// <param name="mensaje">Mensaje de error ingresado</param>
        public FileException(string mensaje)
            : base(mensaje)
        { }

        /// <summary>
        /// Constructor con parametro exception.
        /// Llama al constructor con parametro string y le coloca su mensaje de error.
        /// </summary>
        /// <param name="innerException">Excepción ingresada</param>
        public FileException(Exception innerException)
            : this(innerException.Message)
        { }

        /// <summary>
        /// Constructor con parametro string y exception.
        /// Llama a la base con los mismos parametros.
        /// </summary>
        /// <param name="mensaje">Mensaje de error ingresado</param>
        /// <param name="innerException">Excepción ingresada</param>
        public FileException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        { }
    }
}

