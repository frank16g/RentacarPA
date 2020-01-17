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
    public partial class FormAuto : Form
    {
        List<MarcaEntidad> listaMarcas;
        public string Marca { get; set; }
        public int Clase { get; set; }
        public FormAuto()
        {
            InitializeComponent();
            listaMarcas = RentacarNegocio.RentacarNegocio.DevolverListadoMarcas();
            comboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAgregar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public void Editar()
        {
            textBox_Km.ReadOnly = false;
            textBox_Nombre.ReadOnly = false;
            textBox_Año.ReadOnly = false;
            textBox_Color.ReadOnly = false;
            textBox_Disponibilidad.Text = "1";
            Guardar.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox_Categoria.Text = "";
            comboBox_Marca.Text = "";
            textBox_Km.Text = "";
            textBox_Nombre.Text = "";
            textBox_Año.Text = "";
            textBox_Color.Text = "";
            textBox_Disponibilidad.Text = "";
            Guardar.Visible = false;
            button_Continuar.Visible = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void GuardarCliente()
        {
            if (textBox_Placa.Text == "" || comboBox_Marca.Text == "" || comboBox_Categoria.Text == "" || textBox_Km.Text == "" ||
                textBox_Nombre.Text == "" || textBox_Año.Text == "" || textBox_Color.Text == "")
            {
                MessageBox.Show("Algun dato se encuentra vacio");
            }
            else
            {


            }
        }

        private void comboBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox_Marca.Items.Clear();

            if (comboBox_Categoria.SelectedIndex != -1)
            {

                for (int i = 0; i < listaMarcas.Count; i++)
                {
                    comboBox_Marca.Items.Add(listaMarcas[i].Nombre);
                    Clase = comboBox_Categoria.SelectedIndex + 1;
                }

            }

        }
    }

}
