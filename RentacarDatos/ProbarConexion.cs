using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RentacarEntidades;

namespace RentacarDatos
{
    public class ProbarConexion
    {
        public void probarConxion()
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaArchivo);
            conexion.Open();
        }


        public static ClienteEntidad asignarCliente(string cedula)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.cadena);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" SELECT [nombre]
                                             ,[apellido]
                                             ,[direccion]
                                             ,[telefono]
                                             ,[cedula]
                                             ,[email]
                                             ,[fecha_nac]
                                         FROM [Cliente]
                                     WHERE cedula=@cedula;";
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.CommandType = CommandType.Text;
                ClienteEntidad cliente = new ClienteEntidad();
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    cliente.Nombre = dr["nombre"].ToString();
                    cliente.Cedula = dr["cedula"].ToString();
                    cliente.Apellido = dr["apellido"].ToString();
                    cliente.Telefono = dr["telefono"].ToString();
                    cliente.Direcccion = dr["direccion"].ToString();
                    cliente.Gmail = dr["email"].ToString();
                    cliente.Nacimiento = Convert.ToDateTime(dr["fecha_nac"].ToString());
                }

                conexion.Close();
                return cliente;
            }
            catch (System.InvalidOperationException)
            {
                
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

            public static void insertarCliente(ClienteEntidad cliente)
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(Settings1.Default.cadena);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @" INSERT INTO [dbo].[Cliente]
                                                           ([nombre]
                                                           ,[apellido]
                                                           ,[direccion]
                                                           ,[telefono]
                                                           ,[cedula]
                                                           ,[email]
                                                           ,[fecha_nac])
                                                     VALUES
                               (@nombre,@apellido,@direccion,@telefono,@cedula,@email,@nacimiento);
                               SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@cedula", cliente.Cedula);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direcccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@email", cliente.Gmail);
                cmd.Parameters.AddWithValue("@nacimiento", cliente.Nacimiento);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                conexion.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }


    }
}
