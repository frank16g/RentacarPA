using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentacarEntidades;
using RentacarDatos;

namespace RentacarNegocio
{
    public class Class1
    {
        public static ClienteEntidad asignarCliente(string cedula)
        {
            //Logica Negocio
            return ProbarConexion.asignarCliente(cedula);
        }
        public static void guardarCliente(ClienteEntidad cliente)
        {
            ProbarConexion.insertarCliente(cliente);
        }
    }
}
