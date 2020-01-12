using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarEntidades
{
    class AutoEntidad
    {
        public string Id { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public int Km { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        public int Disponibilidad { get; set; } // 0 es no disponible

    }
}
