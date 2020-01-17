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
        public ClienteEntidad  clienteSeleccionados { get; set; }
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
                ClienteEntidad cliente = new ClienteEntidad();
                button_Continuar.Visible = true;
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra registrado");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
         
                GuardarCliente();
        }

            private void GuardarCliente()
            {
            if (textBox_Apellido.Text == "" || textBox_Cedula.Text == "" || textBox_Nom.Text == "" || textBox_Direccion.Text == "" || textBox_Gmail.Text == "" || textBox_Telefono.Text == "")
            {
                MessageBox.Show("Algun dato se encuentra vacio");
            }
            else
            {

                DateTime fecha = DateTime.Now;
                TimeSpan timeSpan = fecha - dateTimePicker.Value;

                int dias = timeSpan.Days;
                if (dias < 6570)
                {
                    MessageBox.Show("El cliente es menor de edad");
                }
                else
                {
                    ClienteEntidad cliente = new ClienteEntidad();
                    cliente.Nombre = textBox_Nom.Text.Trim();
                    cliente.Apellido = textBox_Apellido.Text.Trim();
                    cliente.Cedula = textBox_Cedula.Text.Trim();
                    cliente.Direcccion = textBox_Direccion.Text.Trim();
                    cliente.Telefono = textBox_Telefono.Text.Trim();
                    cliente.Gmail = textBox_Gmail.Text.Trim();
                    cliente.Nacimiento = dateTimePicker.Value;
                    RentacarNegocio.RentacarNegocio.insertarCliente(cliente);
                    cliente.id = RentacarNegocio.RentacarNegocio.ObtenerIdCliente();
                    clienteSeleccionados = cliente;
                    button_Continuar.Visible = true;
                }
            }
        }

        private void pictureBoxAgregar_Click(object sender, EventArgs e)
        {
            Editar();
        }

                public void Editar()
        {
            textBox_Nom.ReadOnly = false;
            textBox_Apellido.ReadOnly = false;
            textBox_Telefono.ReadOnly = false;
            textBox_Direccion.ReadOnly = false;
            textBox_Gmail.ReadOnly = false;
            dateTimePicker.Enabled = true;
            Guardar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_Nom.Text = "";
            textBox_Apellido.Text = "";
            textBox_Telefono.Text = "";
            textBox_Direccion.Text = "";
            textBox_Gmail.Text = "";
            textBox_Cedula.Text = "";
            Guardar.Visible = false;
            button_Continuar.Visible = false;
        }

        private void button_Continuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
