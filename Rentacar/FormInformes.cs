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
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {


            reportViewer1.Reset();

            ReportDataSource FuenteDeDatos = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = "Ejemplo.Report1.rdlc";
            FuenteDeDatos.Name = "DataSet1";
            this.reservaTableAdapter.Fill(this.DataSet1.Reserva);
            FuenteDeDatos.Value = TablaBindingSource;
            reportViewer1.LocalReport.DataSources.Add(FuenteDeDatos);

            reportViewer1.RefreshReport();
        }
    }
}
