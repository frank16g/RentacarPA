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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void buttonAutosMarca_Click(object sender, EventArgs e)
        {
            FormReporteAutosMarca formReporteAutosMarca = new FormReporteAutosMarca();
            formReporteAutosMarca.ShowDialog();

        }

        private void buttonGananciasMarca_Click(object sender, EventArgs e)
        {
            FormReporteAlquilerMarca formReporteAlquilerMarca = new FormReporteAlquilerMarca();
            formReporteAlquilerMarca.ShowDialog();
        }
    }
}
