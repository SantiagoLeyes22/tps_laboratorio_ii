using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico3;

namespace AppFutbolForm
{
    public static class CrudTitulares
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static CrudTitulares()
        {
            connectionString = @"Data Source =.;Initial Catalog = BD-EQUIPO_TITULAR;Integrated Security = true";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<JugadorTitular> Leer()
        {
            List<JugadorTitular> jugadores = new List<JugadorTitular>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT Id,Nombre,Apellido,Edad FROM equipo";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new JugadorTitular(Convert.ToInt32(dataReader["id"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), Convert.ToInt32(dataReader["Edad"])));
                }
                return jugadores;
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal al leer la base de datos");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM equipo WHERE Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al eliminar el jugador de la base de datos");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Guardar(JugadorTitular jugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO equipo (Nombre,Apellido,Edad) VALUES (@NOMBRE,@APELLIDO,@EDAD)";
                command.Parameters.AddWithValue("@NOMBRE", jugador.Nombre);
                command.Parameters.AddWithValue("@APELLIDO", jugador.Apellido);
                command.Parameters.AddWithValue("@EDAD", jugador.Edad);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el jugador en la base de datos");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Modificar(JugadorTitular nuevoJugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE equipo SET Nombre = @nombre, Apellido = @apellido, Edad = @edad WHERE Id = @id";
                command.Parameters.AddWithValue("@nombre", nuevoJugador.Nombre);
                command.Parameters.AddWithValue("@apellido", nuevoJugador.Apellido);
                command.Parameters.AddWithValue("@edad", nuevoJugador.Edad);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al modificar el jugador en la base de datos");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
