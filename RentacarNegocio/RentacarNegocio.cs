﻿using System;
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

        public static void BuscarCarroNegocio(string text)
        {
            throw new NotImplementedException();
        }

        public static int DevolverNumeroReservas()
        {
            return RentacarDatos.RentacarDatos.ObtenerNumeroReservas();
        }



    }
}
