using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentacarNegocio;
using RentacarEntidades;

namespace Rentacar
{
    public partial class FormMantenimiento : Form
    {
        AutoEntidad auto = new AutoEntidad();
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCarro();
        }

        private void BuscarCarro()
        {
            RentacarNegocio.RentacarNegocio.BuscarCarroNegocio(tbid.Text); // Tbdi
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}
