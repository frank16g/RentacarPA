using Microsoft.Reporting.WinForms;
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
    public partial class FormReporteAlquilerMarca : Form
    {
        public FormReporteAlquilerMarca()
        {
            InitializeComponent();
        }

        private void FormReporteAlquilerMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetAlquilerAutosMarca.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetAlquilerAutosMarca.DataTable1);
            // TODO: esta línea de código carga datos en la tabla 'DataSetAlquilerAutosMarca.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetAlquilerAutosMarca.DataTable1);

            this.reportViewer1.RefreshReport();





        }
    }
}
