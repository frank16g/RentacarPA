﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentacarEntidades;

namespace RentacarDatos
{
    public class RentacarDatos
    {

        public static List<MarcaEntidad> CargarMarcasSqlServer()
        {
            try
            {
                List<MarcaEntidad> listaMarcas = new List<MarcaEntidad>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                connection.Open();

                cmd.CommandText = @"SELECT [id]
                                  ,[nombre]
                              FROM [dbo].[Marca]";

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        MarcaEntidad marca = new MarcaEntidad();

                        marca.id = Convert.ToInt32(dataReader["id"].ToString());
                        marca.Nombre = dataReader["nombre"].ToString();



                        listaMarcas.Add(marca);

                    }
                }
                connection.Close();

                for (int i = 1; i < listaMarcas.Count; i++)
                {
                    SqlConnection connection2 = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = connection2;
                    cmd2.CommandType = CommandType.Text;

                    connection2.Open();

                    cmd2.CommandText = @"SELECT [id]
                              ,[id_marca]
                              ,[id_categoria]
                              ,[nombre]
                              ,[km]
                              ,[anio]
                              ,[color]
                              ,[disponibilidad]
                          FROM [dbo].[Autos]
                          WHERE [id_marca] = @id_marca;";

                    cmd2.Parameters.AddWithValue("@id_marca", i);

                    using (var dataReader = cmd2.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            AutoEntidad auto = new AutoEntidad();

                            auto.Id = dataReader["id"].ToString();
                            auto.Id_Marca = Convert.ToInt32(dataReader["id_marca"].ToString());
                            auto.Id_Categoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                            auto.Nombre = dataReader["nombre"].ToString();
                            auto.Km = Convert.ToInt32(dataReader["km"].ToString());
                            auto.Anio = Convert.ToInt32(dataReader["anio"].ToString());
                            auto.Color = dataReader["color"].ToString();
                            auto.Disponibilidad = Convert.ToInt32(dataReader["disponibilidad"].ToString());

                            for (int j = 0; j < listaMarcas.Count; j++)
                            {
                                if (listaMarcas[j].id == auto.Id_Marca)
                                {
                                    if (listaMarcas[j].ListaAutos == null)
                                    {
                                        listaMarcas[j].ListaAutos = new List<AutoEntidad>();
                                    }
                                    else
                                    {
                                        listaMarcas[j].ListaAutos.Add(auto);
                                    }

                                }
                            }

                        }


                        connection2.Close();
                    }
                }


                return listaMarcas;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public static List<TiposMantenimientosEntidad> BuscarTiposMantenimientos(string text)
        {
            List<TiposMantenimientosEntidad> tipos = new List<TiposMantenimientosEntidad>();
            SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT [id],[nombre]
                                FROM [dbo].[TipoMantenimiento]
                                WHERE tipo = @tipo
                                Select Scope_Identity()";


            cmd.Parameters.AddWithValue("@tipo", text);
            cmd.CommandType = CommandType.Text;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    TiposMantenimientosEntidad t = new TiposMantenimientosEntidad();
                    t.Nombre = (dr["nombre"].ToString());
                    t.Id = Convert.ToInt32(dr["id"].ToString());
                    tipos.Add(t);
                }
            }

            connection.Close();
            return tipos;
        }

        public static void insertarMantenimiento(MantenimientoEntidad mantenimiento, List<MantenimientoDetalleEntidad> detalle)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" INSERT INTO [dbo].[Mantenimiento]
                                                           ([id_auto]
                                                           ,[fecha]
                                                           ,[costo]
                                                           ,[descripcion])
                                                     VALUES
                               (@id_auto,@fecha,@costo,@descripcion);
                               SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@id_auto", mantenimiento.Id_Auto);
                cmd.Parameters.AddWithValue("@fecha", mantenimiento.Fecha);
                cmd.Parameters.AddWithValue("@costo", mantenimiento.Costo);
                cmd.Parameters.AddWithValue("@descripcion", mantenimiento.Descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            foreach (var item in detalle)
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = @" INSERT INTO [dbo].[Mantenimiento_Detalle]
                                                           ([id_tipo]
                                                           ,[costo]
                                                           ,[id_mantenimiento])
                                                     VALUES
                               (@id_tipo,@costo,@id_man);
                               SELECT SCOPE_IDENTITY();";
                    cmd.Parameters.AddWithValue("@id_tipo", item.Id_Tipo);
                    cmd.Parameters.AddWithValue("@costo", item.Costo);
                    cmd.Parameters.AddWithValue("@id_man", item.Id_Mantenimiento);
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

        public static List<ServicioEntidad> CargarServiciosSqlServer()
        {
            try
            {

                List<ServicioEntidad> listaServicios = new List<ServicioEntidad>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();

                cmd
                    .CommandText = @"SELECT [id]
                                  ,[nombre]
                                  ,[costo]
                                  ,[descripcion]
                              FROM [dbo].[Servicio]";

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        ServicioEntidad servicio = new ServicioEntidad();

                        servicio.Id = Convert.ToInt32(dataReader["id"].ToString());
                        servicio.Costo = float.Parse(dataReader["costo"].ToString());
                        servicio.Nombre = (dataReader["nombre"].ToString());
                        servicio.Descripccion = (dataReader["descripcion"].ToString());

                        listaServicios.Add(servicio);

                    }

                }

                connection.Close();
                return listaServicios;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<UsuarioEntidad> CargaUsuariosSqlServer()
        {
            try
            {

                List<UsuarioEntidad> listaUsuarios = new List<UsuarioEntidad>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();

                cmd
                    .CommandText = @"SELECT [id]
                                          ,[nombre]
                                          ,[apellido]
                                          ,[fecha_nac]
                                          ,[direccion]
                                          ,[telefono]
                                          ,[cedula]
                                          ,[username]
                                          ,[password]
                                      FROM [dbo].[Usuario]";

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UsuarioEntidad usuario = new UsuarioEntidad();

                        usuario.Id = Convert.ToInt32(dataReader["id"].ToString());
                        usuario.Nombre = (dataReader["nombre"].ToString());
                        usuario.Apellido = (dataReader["apellido"].ToString());
                        //   usuario.Nacimiento = Convert.ToDateTime((dataReader["fecha_nac"].ToString()));

                        usuario.Direcccion = (dataReader["direccion"].ToString());
                        usuario.Telefono = (dataReader["telefono"].ToString());
                        usuario.Cedula = (dataReader["cedula"].ToString());
                        usuario.Usuario = (dataReader["username"].ToString());
                        usuario.Contraseña = (dataReader["password"].ToString());


                        listaUsuarios.Add(usuario);

                    }

                }

                connection.Close();
                return listaUsuarios;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static AlquilerEntidad GuardarAlquilerSqlServer(AlquilerEntidad alquiler)
        {

            //Guardar Alquiler
            SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            connection.Open();

            cmd.CommandText = @"INSERT INTO [dbo].[Reserva]
                               (
                                [fecha_recogida]
                               ,[fecha_devolucion]
                               ,[id_auto]
                               ,[id_usuario]
                               ,[id_cliente]
                               ,[subtotal]
                               ,[iva]
                               ,[total])
                         VALUES
                                                        (@fecha_recogida,@fecha_devolucion,@id_auto,@id_usuario,@id_cliente,@subtotal,@iva,@total);
                                Select Scope_Identity()";


            cmd.Parameters.AddWithValue("@fecha_recogida", alquiler.fechaRecogida);
            cmd.Parameters.AddWithValue("@fecha_devolucion", alquiler.fechaDevolucion);
            cmd.Parameters.AddWithValue("@id_auto", alquiler.idAuto);
            cmd.Parameters.AddWithValue("@id_usuario", alquiler.idUsuario);
            cmd.Parameters.AddWithValue("@id_cliente", alquiler.idCliente);
            cmd.Parameters.AddWithValue("@subtotal", alquiler.subtotal);
            cmd.Parameters.AddWithValue("@iva", alquiler.iva);
            cmd.Parameters.AddWithValue("@total", alquiler.total);

            alquiler.id = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();


            if (alquiler.listaServicios.Count > 0)
            {
                for (int i = 0; i < alquiler.listaServicios.Count; i++)
                {
                    SqlConnection connection2 = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = connection2;
                    cmd2.CommandType = CommandType.Text;

                    connection2.Open();

                    cmd2.CommandText = @"INSERT INTO [dbo].[Detalle_Reserva]
                                                       ([id_reserva]
                                                       ,[id_servicio])
                                 VALUES
                                       (@id_reserva, @id_servicio)";

                    cmd2.Parameters.AddWithValue("@id_reserva", alquiler.id);
                    cmd2.Parameters.AddWithValue("@id_servicio", alquiler.listaServicios[i].Id);

                    cmd2.ExecuteNonQuery();
                    connection2.Close();
                }
            }

            return alquiler;
        }

        public static int ObtenerNumeroReservas()
        {
            int numeroReserva = 0;
            SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT top (1)[id]
                                FROM [dbo].[Reserva]
                                order by id desc";
            cmd.CommandType = CommandType.Text;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    numeroReserva = Convert.ToInt32(dr["id"].ToString());
                }
            }

            return numeroReserva;
        }

        public static ClienteEntidad asignarCliente(string cedula)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" SELECT [id]
                                             ,[nombre]
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
                    cliente.id = Convert.ToInt32(dr["id"]);
                    cliente.Nombre = dr["nombre"].ToString();
                    cliente.Cedula = dr["cedula"].ToString();
                    cliente.Apellido = dr["apellido"].ToString();
                    cliente.Telefono = dr["telefono"].ToString();
                    cliente.Direcccion = dr["direccion"].ToString();
                    cliente.Gmail = dr["email"].ToString();
                    cliente.Nacimiento = Convert.ToDateTime(dr["fecha_nac"]);
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
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
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

        public static List<MantenimientoEntidad> CargarMantenimientosId(AutoEntidad auto)
        {
            try
            {

                List<MantenimientoEntidad> m = new List<MantenimientoEntidad>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();

                cmd
                    .CommandText = @"SELECT [id_auto]
                                  ,[fecha]
                                  ,[costo]
                                  ,[descripcion]
                              FROM [dbo].[Mantenimiento]
                              WHERE id_auto=@id";
                cmd.Parameters.AddWithValue("@id", auto.Id);

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        MantenimientoEntidad man = new MantenimientoEntidad();

                        man.Id_Auto = (dataReader["id_auto"].ToString());
                        man.Costo = float.Parse(dataReader["costo"].ToString());
                        man.Fecha = Convert.ToDateTime(dataReader["fecha"].ToString());
                        man.Descripcion = (dataReader["descripcion"].ToString());

                        m.Add(man);

                    }

                }

                connection.Close();
                return m;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int ObtenerIdCliente()
        {
            int idCliente = 0;
            SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT top (1)[id]
                                FROM [dbo].[Cliente]
                                order by id desc";
            cmd.CommandType = CommandType.Text;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    idCliente = Convert.ToInt32(dr["id"].ToString());
                }
            }

            return idCliente;
        }

        public static bool insertarAuto(AutoEntidad auto)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" INSERT INTO [dbo].[Autos] ([id]
                                                             ,[id_marca]
                                                             ,[id_categoria]
                                                             ,[nombre]
                                                             ,[km]
                                                             ,[anio]
                                                             ,[color]
                                                             ,[disponibilidad])
                                                     VALUES
                               (@id,@marca,@categoria,@nombre,@km,@año,@color,@disponibilidad);
                               SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@id", auto.Id);
                cmd.Parameters.AddWithValue("@marca", auto.Id_Marca);
                cmd.Parameters.AddWithValue("@categoria", auto.Id_Categoria);
                cmd.Parameters.AddWithValue("@nombre", auto.Nombre);
                cmd.Parameters.AddWithValue("@km", auto.Km);
                cmd.Parameters.AddWithValue("@año", auto.Anio);
                cmd.Parameters.AddWithValue("@color", auto.Color);
                cmd.Parameters.AddWithValue("@disponibilidad", auto.Disponibilidad);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                conexion.Close();
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }


        }
        public static AutoEntidad asignarAuto(string placa)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" SELECT [id]
                                             ,[nombre]
                                            
                                         FROM [Autos]
                                     WHERE id=@placa;";
                cmd.Parameters.AddWithValue("@placa", placa);
                cmd.CommandType = CommandType.Text;
                AutoEntidad auto = new AutoEntidad();
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    auto.Id = dr["id"].ToString();
                    auto.Nombre = dr["nombre"].ToString();

                }

                conexion.Close();
                return auto;
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
        public static List<Chequeos> CargarChequeos()
        {
            try
            {
                List<Chequeos> listaChequeos = new List<Chequeos>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                connection.Open();

                cmd.CommandText = @"SELECT [id]
                                          ,[nombre]
                                          ,[descripcion]
                                      FROM [dbo].[Chequeos]";

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Chequeos chequeos = new Chequeos();

                        chequeos.Id = Convert.ToInt32(dataReader["id"].ToString());
                        chequeos.Nombre = dataReader["nombre"].ToString();
                        chequeos.Descripcion = dataReader["descripcion"].ToString();
                        listaChequeos.Add(chequeos);

                    }
                }
                connection.Close();
                return listaChequeos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static ReservaEntidad CargarFactura(int id)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @"SELECT [fecha_devolucion]
                                      ,[id_auto]
                                      ,[id_cliente]
                                  FROM [dbo].[Reserva]
                                    WHERE id = @id; ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                ReservaEntidad reserva = new ReservaEntidad();
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    reserva.Auto = dr["id_auto"].ToString();
                    reserva.Cliente = Convert.ToInt32(dr["id_cliente"]);
                    reserva.Fec_Devolucion = Convert.ToDateTime(dr["fecha_devolucion"]);
                }

                conexion.Close();
                return reserva;
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

        public static void insertarMulta(MultaEntidad multa)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" INSERT INTO [dbo].[Multas]
                                                          ([num_reserva]
                                                          ,[monto]
                                                          ,[dias])
                                                    VALUES
                               (@reserva,@monto,@dias);
                               SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@reserva", multa.Reserva);
                cmd.Parameters.AddWithValue("@monto", multa.Monto);
                cmd.Parameters.AddWithValue("@dias", multa.Dias);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string ObtenerCedCliente(int id)
        {

            try
            {
                string cedula = "";
                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT [cedula]
                                FROM [dbo].[Cliente]
                                WHERE id = @id; ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cedula = dr["cedula"].ToString();
                    }
                }
                connection.Close();
                return cedula;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarEstadoAuto(string id,int disp)
        {

            try
            {
                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"UPDATE [dbo].[Autos]
                                SET [disponibilidad] = @disp
                                WHERE id = @id; ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@dis", disp);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteReader();


                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<AutoEntidad> CargarAutos(int disp)
        {
            try
            {

                List<AutoEntidad> m = new List<AutoEntidad>();

                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();

                cmd.CommandText = @"SELECT [id]
                                          ,[id_marca]
                                          ,[id_categoria]
                                          ,[nombre]
                                          ,[km]
                                          ,[anio]
                                          ,[color]
                                          ,[disponibilidad]
                                      FROM [dbo].[Autos]
                              WHERE disponibilidad=@disp";
                cmd.Parameters.AddWithValue("@disp",disp);

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        AutoEntidad auto = new AutoEntidad();

                        auto.Id = dataReader["id"].ToString();
                        auto.Id_Marca = Convert.ToInt32(dataReader["id_marca"].ToString());
                        auto.Id_Categoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                        auto.Nombre = dataReader["nombre"].ToString();
                        auto.Km = Convert.ToInt32(dataReader["km"].ToString());
                        auto.Anio = Convert.ToInt32(dataReader["anio"].ToString());
                        auto.Color = dataReader["color"].ToString();
                        auto.Disponibilidad = Convert.ToInt32(dataReader["disponibilidad"].ToString());


                        m.Add(auto);

                    }

                }

                connection.Close();
                return m;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int ObtenerIdInspeccion()
        {
            try
            {
                int idCliente = 0;
                SqlConnection connection = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT top (1)[id]
                                FROM [dbo].[Inspeccion]
                                order by id desc";
                cmd.CommandType = CommandType.Text;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idCliente = Convert.ToInt32(dr["id"].ToString());
                    }
                }
                int idInspeccion = idCliente + 1;
                return idCliente;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return 1;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static void insertarDetalleInspeccion(DetalleInspeccionEntidad detalle)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaConexionSqlServer);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = @" INSERT INTO [dbo].[Detalle_Inspeccion]
                                                       ([id_chequeo]
                                                       ,[examinacion]
                                                       ,[id_inspeccion])
                                                 VALUES
                               (@chequeo,@examinacion,@inspeccion);
                               SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@chequeo", detalle.id_chequeo);
                cmd.Parameters.AddWithValue("@examinacion", detalle.examinacion);
                cmd.Parameters.AddWithValue("@inspeccion", detalle.id_inspeccion);
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
