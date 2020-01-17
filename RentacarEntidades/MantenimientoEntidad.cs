using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
    public class MantenimientoEntidad
    {
        public int Id { get; set; }
        public string Id_Auto { get; set; }
        public DateTime Fecha { get; set; }
        public float Costo { get; set; }
        public string Descripcion { get; set; }

    }
}