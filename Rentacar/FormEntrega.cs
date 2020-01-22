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
    public partial class FormEntrega : Form
    {
        public FormEntrega()
        {
            InitializeComponent();
        }

        private void textBox_Cedula_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button_Continuar_Click(object sender, EventArgs e)
        {
            FormInspeccion formInspeccion = new FormInspeccion();
            formInspeccion.ShowDialog();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            ReservaEntidad reserva = new ReservaEntidad();
            int k = 2;
            reserva = RentacarNegocio.RentacarNegocio.CargarFactura(Convert.ToInt32(textBox_Id.Text));
            if (reserva != null)
            {
                textBox_Auto.Text = reserva.Auto;
                textBox_Cliente.Text = RentacarNegocio.RentacarNegocio.ObtenerCedCliente(reserva.Cliente);
                dateTimePicker.Value = reserva.Fec_Devolucion;
                RentacarNegocio.RentacarNegocio.ActualizarEstadoAuto(reserva.Auto, k);
                var resul = (dateTimePicker1.Value - dateTimePicker.Value).TotalDays;
                var dias = Math.Round(resul);
                if (dias > 1)
                {
                    label5.Text = (dias * 20).ToString();
                    MultaEntidad multa = new MultaEntidad();
                    multa.Dias = Convert.ToInt32(dias);
                    multa.Reserva = Convert.ToInt32(textBox_Id.Text);
                    multa.Monto = Convert.ToInt32(label5.Text);
                    RentacarNegocio.RentacarNegocio.insertarMulta(multa);

                }
                else
                    label5.Text = "0";

                button_Continuar.Visible = true;
            }
            else
            {
                MessageBox.Show("La factura no se encuentra registrada ");
            }
        }
    }
}
