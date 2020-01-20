using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentacarNegocio;
using RentacarEntidades;

namespace Rentacar
{
    public partial class FormMantenimiento : Form
    {
        AutoEntidad auto = new AutoEntidad();
        List<MantenimientoEntidad> m = new List<MantenimientoEntidad>();
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCarro();
        }

        private void BuscarCarro()
        {
            auto.Id = tbid.Text;
            if (tbid.Text != "")
            {
                bool flag = ComprobarExistenciaAuto(auto);

                if (flag)
                {
                    m = RentacarNegocio.RentacarNegocio.BuscarCarroNegocio(auto);
                    ListarMantenimientos();
                }
                else
                {
                    MessageBox.Show("Carro no existe");
                }
            }
            
            
        }

        private void ListarMantenimientos()
        {
            mantenimientos.DataSource = null;
            mantenimientos.DataSource = m;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            auto.Id = tbid.Text;
            if (tbid.Text != "")
            {
                bool flag = ComprobarExistenciaAuto(auto);
                if (flag && tbid.Text != "" && dtfecha.Value != null && tbcosto.Text != "" && tbdescripcion.Text != "")
                {
                    GuardarMantenimiento();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }

        private bool ComprobarExistenciaAuto(AutoEntidad auto)
        {
            List<MarcaEntidad> marcas = new List<MarcaEntidad>();
            marcas = RentacarNegocio.RentacarNegocio.DevolverListadoMarcas();

            bool flag = false;
            for (int i = 0; i < marcas.Count; i++)
            {
                try
                {
                    for (int j = 0; j < marcas[i].ListaAutos.Count; j++)
                    {
                        if (marcas[i].ListaAutos[j].Id == auto.Id)
                        {
                            flag = true;
                        }

                    }
                }
                catch (System.NullReferenceException e)
                {

                    
                }
                
            }
            return flag;
        }

        private void GuardarMantenimiento()
        {
            MantenimientoEntidad mantenimiento = new MantenimientoEntidad();
            mantenimiento.Id_Auto = tbid.Text;
            mantenimiento.Costo = float.Parse(tbcosto.Text);
            mantenimiento.Descripcion = tbdescripcion.Text;
            mantenimiento.Fecha = DateTime.Parse(dtfecha.Text);
            RentacarNegocio.RentacarNegocio.insertarMantenimiento(mantenimiento);
        }


        private void mantenimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
