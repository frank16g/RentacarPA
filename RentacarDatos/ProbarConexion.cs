﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RentacarDatos
{
    class ProbarConexion
    {
        public void probarConxion()
        {
            SqlConnection conexion = new SqlConnection(Settings1.Default.CadenaArchivo);
            conexion.Open();
        }
        
    }
}
