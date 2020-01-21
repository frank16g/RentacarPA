using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
    public class DetalleInspeccionEntidad
    {
        public int id_chequeo { get; set; }
        public int id_inspeccion { get; set; }
        public string examinacion { get; set; }
    }
}
