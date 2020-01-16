using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentacarEntidades;
using RentacarNegocio;

namespace Rentacar
{
    public partial class FormServicios : Form
    {

        List<ServicioEntidad> listaServicios;
        public ServicioEntidad ServicioSelecionado { get; set; }

        public FormServicios()
        {
            InitializeComponent();
            listaServicios = RentacarNegocio.RentacarNegocio.CargarServicios();

            dataGridView1.DataSource = listaServicios;
            ServicioSelecionado = new ServicioEntidad();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                ServicioSelecionado = new ServicioEntidad();
                ServicioSelecionado.Id = id;

           

            foreach (var item in listaServicios)
            {
                if (item.Id == ServicioSelecionado.Id)
                {
                    ServicioSelecionado.Nombre = item.Nombre;
                    ServicioSelecionado.Descripccion = item.Descripccion;
                    ServicioSelecionado.Costo = item.Costo;

                    this.Close();
                    break;
                }
            }
        }

      
    }
}
