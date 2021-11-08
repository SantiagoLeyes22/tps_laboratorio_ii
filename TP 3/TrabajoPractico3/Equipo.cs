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
        private Equipo()
        {
            equipo = new List<Jugador>();
        }
        public Equipo(int capacidad,string nombre) : this()
        {
            this.capacidad = capacidad;
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
     
        #endregion

        #region Metodos
        
        public string mostrarEquipo(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
           
            foreach (Jugador item in e.equipo)
            {
                //sb.AppendLine(item.ToString());
            }
            
            return sb.ToString();
        }
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
        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e.equipo.Contains(j))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool rta = false;
            try
            {
                if (e.equipo.Count < e.capacidad)
                {
                    if (e != j)
                    {
                        e.equipo.Add(j);
                        rta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return rta;
        }
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
