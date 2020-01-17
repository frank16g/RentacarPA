using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar
{
    public partial class FormAutos : Form
    {
        public FormAutos()
        {
            InitializeComponent();
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
            Marca.ReadOnly = false;
            textBox_Categoria.ReadOnly = false;
            textBox_Km.ReadOnly = false;
            textBox_Nombre.ReadOnly = false;
            textBox_Año.ReadOnly = false;
            textBox_Color.ReadOnly = false;
            textBox_Disponibilidad.Text = "1";
            Guardar.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Marca.Text = "";
            textBox_Categoria.Text = "";
            textBox_Km.Text = "";
            textBox_Nombre.Text = "";
            textBox_Año.Text = "";
            textBox_Color.Text = "";
            textBox_Disponibilidad.Text = "";
            Guardar.Visible = false;
            button_Continuar.Visible = false;
        }
    }
}
