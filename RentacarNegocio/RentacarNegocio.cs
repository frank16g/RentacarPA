using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentacarDatos;
using RentacarEntidades;

namespace RentacarNegocio
{
    public class RentacarNegocio
    {

        public static List<MarcaEntidad> DevolverListadoMarcas()
        {
           return RentacarDatos.RentacarDatos.CargarMarcasSqlServer();
        }

        public static List<ServicioEntidad> CargarServicios()
        {
            return RentacarDatos.RentacarDatos.CargarServiciosSqlServer();
        }

        public static AlquilerEntidad GuardarAlquiler(AlquilerEntidad alquiler)
        {
            return RentacarDatos.RentacarDatos.GuardarAlquilerSqlServer( alquiler);
        }

        public static int DevolverNumeroReservas()
        {
            return RentacarDatos.RentacarDatos.ObtenerNumeroReservas();
        }

        public static List<UsuarioEntidad> DevolverListadoUsuarios()
        {
            return RentacarDatos.RentacarDatos.CargaUsuariosSqlServer();
        }

        //

        public static void insertarCliente(ClienteEntidad cliente)
        {
           RentacarDatos.RentacarDatos.insertarCliente(cliente);
        }

        public static ClienteEntidad asignarCliente(string cedula)
        {
            return RentacarDatos.RentacarDatos.asignarCliente(cedula);
        }

        public static List<TiposMantenimientosEntidad> CargarTiposMantenimientos(string text)
        {
            return RentacarDatos.RentacarDatos.BuscarTiposMantenimientos(text);
        }

        public static int ObtenerIdCliente()
        {
            return   RentacarDatos.RentacarDatos.ObtenerIdCliente();
        }
        public static bool insertarAuto(AutoEntidad auto)
        {
            return RentacarDatos.RentacarDatos.insertarAuto(auto);
            
        }
        public static List<MantenimientoEntidad> BuscarCarroNegocio(AutoEntidad auto)
               
        {
            return RentacarDatos.RentacarDatos.CargarMantenimientosId(auto);
        }

        public static void insertarMantenimiento(MantenimientoEntidad mantenimiento, List<MantenimientoDetalleEntidad> detalle)
        {
            RentacarDatos.RentacarDatos.insertarMantenimiento(mantenimiento, detalle);
        }

        public static AutoEntidad asignarAuto(string placa)
        {
            return RentacarDatos.RentacarDatos.asignarAuto(placa);
        }
    }
}
