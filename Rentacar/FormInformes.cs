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
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.DataSet1.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);


            // TODO: esta línea de código carga datos en la tabla 'DataSet1.vTargetMail' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();

            ReportDataSource FuenteDeDatos = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = "Ejemplo.Report1.rdlc";
            FuenteDeDatos.Name = "DataSet1";
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1,);
            FuenteDeDatos.Value = DataTable1BindingSource;
            reportViewer1.LocalReport.DataSources.Add(FuenteDeDatos);

            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();

            ReportDataSource FuenteDeDatos = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = "Ejemplo.Report2.rdlc";
            FuenteDeDatos.Name = "DataSet1";
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            FuenteDeDatos.Value = DataTable1BindingSource;
            reportViewer1.LocalReport.DataSources.Add(FuenteDeDatos);

            reportViewer1.RefreshReport();
        }
    }
}
