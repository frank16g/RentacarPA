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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonMantenimientos_Click(object sender, EventArgs e)
        {
            LlamarFromMantenimientos();
        }

        private void LlamarFromMantenimientos()
        {
            FormMantenimientos formMantenimiento = new FormMantenimientos();

            formMantenimiento.ShowDialog();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            LlamarFromInfromes();
        }

        private void LlamarFromInfromes()
        {
            FormReportes formReportes = new FormReportes();

            formReportes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlamarFromAutos();
        }

        private void LlamarFromAutos()
        {
            FormAuto formAuto = new FormAuto();

            formAuto.ShowDialog();
        }
    }
}
