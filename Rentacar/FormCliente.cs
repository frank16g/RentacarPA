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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClienteEntidad cliente = new ClienteEntidad();
            cliente = RentacarNegocio.RentacarNegocio.asignarCliente(textBox_Cedula.Text);
            if (cliente != null)
            {
                textBox_Nom.Text = cliente.Nombre;
                textBox_Apellido.Text = cliente.Apellido;
                textBox_Telefono.Text = cliente.Telefono;
                textBox_Direccion.Text = cliente.Direcccion;
                textBox_Gmail.Text = cliente.Gmail;
                dateTimePicker.Value = cliente.Nacimiento;       
            }
            else
            {
                textBox_Nom.ReadOnly = false;
                textBox_Apellido.ReadOnly = false;
                textBox_Telefono.ReadOnly = false;
                textBox_Direccion.ReadOnly = false;
                textBox_Gmail.ReadOnly = false;
                dateTimePicker.Enabled = false;
                Guardar.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
         
                GuardarCliente();
        }

            private void GuardarCliente()
            {
                ClienteEntidad cliente = new ClienteEntidad();
                cliente.Nombre = textBox_Nom.Text.Trim();
                cliente.Apellido = textBox_Apellido.Text.Trim();
                cliente.Cedula = textBox_Cedula.Text.Trim();
                cliente.Direcccion = textBox_Direccion.Text.Trim();
            cliente.Telefono = textBox_Telefono.Text.Trim();
                cliente.Gmail = textBox_Gmail.Text.Trim();
            cliente.Nacimiento = dateTimePicker.Value;
            RentacarNegocio.RentacarNegocio.insertarCliente (cliente);
            }
        
    }
}
