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
    public partial class FormInspeccion : Form
    {
        List<Chequeos> listaChequeos;
        List<AutoEntidad> listaAutos;
        int k = 2;
        public FormInspeccion()
        {
            
            InitializeComponent();
            listaChequeos = RentacarNegocio.RentacarNegocio.CargarChequeos();
            listaAutos = RentacarNegocio.RentacarNegocio.CargarAutos(k);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            asignarChequeos();
            asignarAutos();
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void asignarChequeos()
        { 

                for (int i = 0; i < listaChequeos.Count; i++)
                {
                    comboBox1.Items.Add(listaChequeos[i].Nombre);
                } 
        }
        private void asignarAutos()
        {

            for (int i = 0; i < listaAutos.Count; i++)
            {
                comboBox2.Items.Add(listaAutos[i].Id);
            }
        }

        private void buttonConfirmarAlquiler_Click(object sender, EventArgs e)
        {

        }
    }
}
