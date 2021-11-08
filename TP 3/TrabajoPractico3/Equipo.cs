using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoPractico3
{
    public class Equipo
    {
        private int capacidad;
        public List<Jugador> equipo;
        public string nombre;

        #region Construcores
        /// <summary>
        /// Constructor de equipo que instancia una lista de jugadores
        /// </summary>
        private Equipo()
        {
            equipo = new List<Jugador>();
        }
        /// <summary>
        /// Constructor de equipo que asigna los valores de capacidad y nombre
        /// </summary>
        /// <param name="capacidad"></param>
        /// <param name="nombre"></param>
        public Equipo(int capacidad,string nombre) : this()
        {
            this.capacidad = capacidad;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Escribe los datos del equipo en un archivo xml.
        /// </summary>
        /// <param name="f">Fabrica a escribir.</param>
        /// <param name="path">Ruta del archivo.</param>
        /// <returns>True si fue exitoso, false si no.</returns>
        public static bool Escribir(Equipo f, string path)
        {
            Xml<Equipo> eF = new Xml<Equipo>();

            return eF.Escribir(path, f);
        }

        /// <summary>
        /// Lee los datos de un archivo xml.
        /// </summary>
        /// <param name="path">Ruta del archivo.</param>
        /// <returns>Equipo nuevo con los datos del archivo.</returns>
        public static Equipo Leer(string path)
        {
            Xml<Equipo> lF = new Xml<Equipo>();

            return lF.Leer(path);
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verifica que un jugador este dentro del equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e.equipo.Contains(j))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que un jugador no este dentro del equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        /// <summary>
        /// Verifica que un jugador no este dentro de la lista, si no esta lo agrega
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator +(Equipo e, Jugador j)
        {
            bool rta = false;
            try
            {
                  if (e != j)
                  {
                     e.equipo.Add(j);
                     rta = true;
                  }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return rta;
        }
        /// <summary>
        /// Verifica que el jugador este dentro del equipo,si lo encuentra lo elimina
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator -(Equipo e, Jugador j)
        {
            bool rta = false;
            int indice = e.equipo.IndexOf(j);
            try
            {
                if (e.equipo.Contains(j))
                {
                    e.equipo.RemoveAt(indice);
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return rta;
        }
        #endregion
    }
}
