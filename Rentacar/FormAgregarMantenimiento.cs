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

namespace Rentacar
{
    public partial class FormAgregarMantenimiento : Form
    {
        FormTiposMantenimientos tipos = new FormTiposMantenimientos();
        FormMantenimiento formmantenimiento = new FormMantenimiento();
        List<MantenimientoDetalleEntidad> detalle = new List<MantenimientoDetalleEntidad>();
        public FormAgregarMantenimiento()
        {
            InitializeComponent();
        }

        private void FormAgregarMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnanadir_Click(object sender, EventArgs e)
        {
            tipos.ShowDialog();
            if (tipos.tipo != null)
            {
                tbnombre.Text = tipos.tipo.Nombre;
                tbcosto.Focus();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            float precio;
            try
            {
                precio = float.Parse(tbcosto.Text);
                MantenimientoDetalleEntidad d = new MantenimientoDetalleEntidad();
                d.Costo = precio;
                d.Id_Tipo = tipos.tipo.Id;
                detalle.Add(d);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = detalle;
                limpiarCosto();
                calcularTotal();
            }
            catch (System.FormatException fe)
            {
            }
            catch (NullReferenceException nr)
            {
            }
            catch (Exception)
            {

            }
        }

        private void calcularTotal()
        {
            float total = 0;
            foreach (var item in detalle)
            {
                total += item.Costo;
            }
            tbtotal.Text = total.ToString();
        }

        private void limpiarCosto()
        {
            tbcosto.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MantenimientoEntidad mantenimiento = new MantenimientoEntidad();
            mantenimiento.Fecha = DateTime.Parse(dtfecha.Text);
            mantenimiento.Costo = float.Parse(tbtotal.Text);
            mantenimiento.Id_Auto = formmantenimiento.auto.Id;
            RentacarNegocio.RentacarNegocio.insertarMantenimiento(mantenimiento, detalle);
        }
    }
}
