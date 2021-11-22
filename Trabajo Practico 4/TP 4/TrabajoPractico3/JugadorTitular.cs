using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class JugadorTitular
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public JugadorTitular(int id, string nombre, string apellido, int edad):this(nombre,apellido,edad)
        {
            this.Id = id;
        }
        public JugadorTitular(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellido: {this.Apellido} Id: {this.id}";
        }
    }
}
