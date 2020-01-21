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
    public partial class Inspeccion : Form
    {
        List<Chequeos> listaChequeos;
        public Inspeccion()
        {
            InitializeComponent();
            listaChequeos = RentacarNegocio.RentacarNegocio.CargarChequeos();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            asignarChequeos();
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
    }
}
