using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
    public class ReservaEntidad
    {
        public int Id { get; set; }
        public string Auto { get; set; }
        public DateTime Fec_Devolucion { get; set; }
        public int Cliente { get; set; }
    }
}
