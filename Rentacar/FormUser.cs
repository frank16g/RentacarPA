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

namespace Rentacar
{
    public partial class FormUser : Form
    {

        public UsuarioEntidad usuarioUser;

        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonAlquilar_Click(object sender, EventArgs e)
        {
            LlamarFormReserva();

        }

        private void LlamarFormReserva()
        {
            FormReserva formReserva = new FormReserva();
            formReserva.usuarioSesion = usuarioUser;
            formReserva.ShowDialog();
        }

        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            LlamarFormInspecion();
        }

        private void LlamarFormInspecion()
        {
            FormEntrega formEntrega = new FormEntrega();
            formEntrega.ShowDialog();

            
        }
    }
}
