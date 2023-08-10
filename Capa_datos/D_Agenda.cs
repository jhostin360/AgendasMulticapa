using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_entidad;
using System.Data;

namespace Capa_datos
{
    public class D_Agenda
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Agenda> ListarAgenda(string buscar) {


            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("sp_buscar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            reader = cmd.ExecuteReader();

            List<E_Agenda> listar = new List<E_Agenda>();
            while (reader.Read()) {
                
                listar.Add(new E_Agenda {
                
                    Id_agenda = reader.GetInt32(0),
                    Nombre_agenda = reader.GetString(1),
                    Apellido_agenda = reader.GetString(2),
                    Fecha_agenda = reader.GetString(3),
                    Direccion_agenda = reader.GetString(4),
                    Genero_agenda = reader.GetString(5),
                    EstadoCivil_agenda = reader.GetString(6),
                    Movil_agenda= reader.GetString(7),
                    Telefono_agenda= reader.GetString(8),
                    Correo_agenda= reader.GetString(9)
                });
                
            }

            conexion.Close();
            reader.Close();
            return listar;
        }

        public void Insertar(E_Agenda agenda) {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();

                cmd.Parameters.AddWithValue("@nombre", agenda.Nombre_agenda);
                cmd.Parameters.AddWithValue("@Apellido", agenda.Apellido_agenda);
                cmd.Parameters.AddWithValue("@Fecha", agenda.Fecha_agenda);
                cmd.Parameters.AddWithValue("@Direccion", agenda.Direccion_agenda);
                cmd.Parameters.AddWithValue("@Genero", agenda.Genero_agenda);
                cmd.Parameters.AddWithValue("@Estado_civil", agenda.EstadoCivil_agenda);
                cmd.Parameters.AddWithValue("@Movil", agenda.Movil_agenda);
                cmd.Parameters.AddWithValue("@Telefono", agenda.Telefono_agenda);
                cmd.Parameters.AddWithValue("@Correo", agenda.Correo_agenda);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        public void Editar(E_Agenda agenda) {

            SqlCommand cmd = new SqlCommand("sp_editar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@id", agenda.Id_agenda);
            cmd.Parameters.AddWithValue("@nombre", agenda.Nombre_agenda);
            cmd.Parameters.AddWithValue("@Apellido", agenda.Apellido_agenda);
            cmd.Parameters.AddWithValue("@Fecha", agenda.Fecha_agenda);
            cmd.Parameters.AddWithValue("@Direccion", agenda.Direccion_agenda);
            cmd.Parameters.AddWithValue("@Genero", agenda.Genero_agenda);
            cmd.Parameters.AddWithValue("@Estado_civil", agenda.EstadoCivil_agenda);
            cmd.Parameters.AddWithValue("@Movil", agenda.Movil_agenda);
            cmd.Parameters.AddWithValue("@Telefono", agenda.Telefono_agenda);
            cmd.Parameters.AddWithValue("@Correo", agenda.Correo_agenda);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void Eliminar(E_Agenda agenda)
        {

            SqlCommand cmd = new SqlCommand("sp_borrar", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@id", agenda.Id_agenda);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
