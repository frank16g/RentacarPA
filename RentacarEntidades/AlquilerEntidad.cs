using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
    public class AlquilerEntidad
    {
        public int id { get; set; }
        public DateTime fechaRecogida { get; set; }
        public  DateTime fechaDevolucion { get; set; }
        public  DateTime fechaReserva { get; set; }

        public string idAuto { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }

        public float subtotal { get; set; }
        public float iva { get; set; }
        public float total { get; set; }

        public List<ServicioEntidad> listaServicios { get; set; }


    }
}
