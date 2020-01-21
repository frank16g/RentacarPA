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
        public AutoEntidad auto = new AutoEntidad();
        FormAgregarMantenimiento formagregar = new FormAgregarMantenimiento();
        List<MantenimientoEntidad> m = new List<MantenimientoEntidad>();
        List<MarcaEntidad> listaMarcas = RentacarNegocio.RentacarNegocio.DevolverListadoMarcas();
        public string Marca { get; set; }
        public int Clase { get; set; }

        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCarro();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BuscarCarro();
            btnnuevo.Visible = false;
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
                    btnnuevo.Visible = true;
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
        /*
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
        */

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

       


        private void mantenimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMarca.Items.Clear();

            if (comboBoxClase.SelectedIndex != -1)
            {

                for (int i = 0; i < listaMarcas.Count; i++)
                {
                    comboBoxMarca.Items.Add(listaMarcas[i].Nombre);
                    Clase = comboBoxClase.SelectedIndex + 1;
                }

            }
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedIndex != -1)
            {
                List<AutoEntidad> listaAutos = new List<AutoEntidad>();

                try
                {
                    for (int i = 0; i < listaMarcas.Count; i++)
                    {
                        if (listaMarcas[i].Nombre == comboBoxMarca.SelectedItem.ToString())
                        {

                            if (listaMarcas[i].ListaAutos.Count != 0)
                            {
                                for (int j = 0; j < listaMarcas[i].ListaAutos.Count; j++)
                                {
                                    if (comboBoxClase.SelectedIndex + 1 == listaMarcas[i].ListaAutos[j].Id_Categoria)
                                    {
                                        //LISTA DE AUTOS FALTA MANTENIMIENTO
                                        listaAutos.Add(listaMarcas[i].ListaAutos[j]);
                                        Marca = listaMarcas[i].Nombre;

                                    }
                                }
                            }



                        }

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("No existen autos Disponibles (Seleccione otra marca o categoría)");
                }

                for (int j = 0; j < listaAutos.Count; j++)
                {
                    m = m.Union(RentacarNegocio.RentacarNegocio.BuscarCarroNegocio(listaAutos[j])).ToList();
                }

               
                ListarMantenimientos();
                mantenimientos.MultiSelect = false;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            formagregar.ShowDialog();
        }
    }
}
