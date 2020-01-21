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
    public partial class FormTiposMantenimientos : Form

    {
        public TiposMantenimientosEntidad tipo { get; set; }
        public FormTiposMantenimientos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TiposMantenimientosEntidad p = new TiposMantenimientosEntidad();
            p.Nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            p.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            tipo = p;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTiposMantenimientos_Load(object sender, EventArgs e)
        {
            CargarMantenimientos();
        }

        private void CargarMantenimientos()
        {
            dataGridView1.DataSource = RentacarNegocio.RentacarNegocio.CargarTiposMantenimientos(cbtipo.Text);
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RentacarNegocio.RentacarNegocio.CargarTiposMantenimientos(cbtipo.Text);
        }
    }
}
