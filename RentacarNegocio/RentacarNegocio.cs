using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentacarDatos;
using RentacarEntidades;
using Xceed.Document.NET;
using Xceed.Words.NET;

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
        public static List<Chequeos> CargarChequeos()
        {
            return RentacarDatos.RentacarDatos.CargarChequeos();
        }

        public static ReservaEntidad CargarFactura(int id)
        {
            return RentacarDatos.RentacarDatos.CargarFactura(id);
        }
        public static void insertarMulta(MultaEntidad multa)
        {
           RentacarDatos.RentacarDatos.insertarMulta(multa);
        }
        public static string ObtenerCedCliente(int id)
        {
           return  RentacarDatos.RentacarDatos.ObtenerCedCliente(id);
        }
        public static void ActualizarEstadoAuto(string id,int disp)
        {
            RentacarDatos.RentacarDatos.ActualizarEstadoAuto(id,disp);
        }

        public static List<AutoEntidad> CargarAutos(int disp)
        {
           return  RentacarDatos.RentacarDatos.CargarAutos(disp);
        }

       

        public static void GenerarContrato(AlquilerEntidad alquiler)
        {
            ClienteEntidad cliente = new ClienteEntidad();
            cliente = RentacarDatos.RentacarDatos.devolverClientePorIdSqlServer(alquiler.idCliente.ToString());

            AutoEntidad autoAlquiler = new AutoEntidad();
            MarcaEntidad marcaAlaquiler = new MarcaEntidad();
            List<MarcaEntidad> marcas = DevolverListadoMarcas();

            foreach (var marca in marcas)
            {
                if (marca.ListaAutos != null)
                {
                    foreach (var carro in marca.ListaAutos)
                    {
                        if (carro.Id == alquiler.idAuto)
                        {
                            autoAlquiler = carro;
                            marcaAlaquiler = marca;
                        }
                    }
                }


            }


            string fileName = @".\contrato.docx";

            var doc = DocX.Create(fileName);

            var headLineFormat = new Formatting();
            headLineFormat.Size = 18D;
            headLineFormat.Position = 20;

            var parrafoFormat = new Formatting();
            parrafoFormat.Size = 12D;

            Paragraph parrafo = doc.InsertParagraph();

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append(("                         Contrato de alquiler vehicular"), headLineFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("Hoy día " + DateTime.Now.ToString() + " en la ciudad  de  Ambato,  se presenta  por  una parte  el Sr./Sra. " + cliente.Nombre.ToString() + " " + cliente.Apellido.ToString() + ", con  cédula  de Identidad " + cliente.Cedula.ToString() + "  y por otra  parte La Organización Rentacar representada por el señor David Constante con cédula 1850176213  para celebrar el presente contrato de arrendamiento de un automóvil, el mismo que se someterá a las siguientes clausulas", parrafoFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("Primero: Que la organización Rentacar representada por el señor David Constante con sede en la ciudad de Ambato Alquila el vehículo de placa " + autoAlquiler.Id + ", " + marcaAlaquiler.Nombre + ", " + autoAlquiler.Nombre + " en excelentes condiciones al Sr/Sra " + cliente.Nombre + " " + cliente.Apellido + ". ");

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("Segundo: El alquiler se realiza desde " + alquiler.fechaRecogida.ToString() + " hasta, " + alquiler.fechaDevolucion.ToString() + " Si el arrendatario sobrepasase la fecha de devolución del vehículo se le facturara el valor excedente por el número de días.  ", parrafoFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("Tercero: El valor del contrato es de " + alquiler.total.ToString("C2") + ", el mismo que será abonado de contado a la fecha del presente contrato y el sobrante en caso de exceder la entrega del vehículo. ", parrafoFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append(" Es todo cuanto podemos estipular en este contrato, firmando  las dos partes en mutuo acuerdo.", parrafoFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();
            parrafo.AppendLine();
            parrafo.AppendLine();
            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("     ________________________", parrafoFormat);
            parrafo.AppendLine();

            parrafo.Append("     " + cliente.Nombre + " " + cliente.Apellido);
            parrafo.AppendLine();

            parrafo.Append("     " + cliente.Cedula, parrafoFormat);

            parrafo.AppendLine();
            parrafo.AppendLine();
            parrafo.AppendLine();

            parrafo.Append("     ________________________", parrafoFormat);
            parrafo.AppendLine();

            parrafo.Append("     " + "David Constante");
            parrafo.AppendLine();

            parrafo.Append("     " + 1850176213);




            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}
