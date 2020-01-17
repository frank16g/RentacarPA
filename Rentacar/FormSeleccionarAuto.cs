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
    public partial class FormSeleccionarAuto : Form
    {

        List<MarcaEntidad> listaMarcas;

        string Id;

        public AutoEntidad autoSeleccionado { get; set; }
        public string Marca { get; set; }
        public int Clase { get; set; }

        public FormSeleccionarAuto()
        {
            InitializeComponent();

            listaMarcas = RentacarNegocio.RentacarNegocio.DevolverListadoMarcas();
            comboBoxClase.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
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
                                    if (comboBoxClase.SelectedIndex + 1 == listaMarcas[i].ListaAutos[j].Id_Categoria && listaMarcas[i].ListaAutos[j].Disponibilidad == 1)
                                    {
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

                dataGridViewAutos.DataSource = null;
                dataGridViewAutos.DataSource = listaAutos;
                dataGridViewAutos.MultiSelect = false;

                DataGridViewColumn Column = dataGridViewAutos.Columns[1];
                Column.Visible = false;
                DataGridViewColumn Column2 = dataGridViewAutos.Columns[2];
                Column2.Visible = false;
            }
        }

    

        private void dataGridViewAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            autoSeleccionado = null;
            try
            {
                 Id = dataGridViewAutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                for (int i = 0; i < listaMarcas.Count; i++)
                {

                    for (int j = 0; j < listaMarcas[i].ListaAutos.Count; j++)
                    {
                        if (listaMarcas[j].ListaAutos[i].Id == Id)
                        {
                            autoSeleccionado = listaMarcas[j].ListaAutos[i];
                            //MessageBox.Show("Placa " + autoSeleccionado.Id + " Marca " + Marca + " Modelo " + autoSeleccionado.Nombre);
                            this.Close();
                        }
                    }

                  
                }
            }
            catch (Exception)
            {
                
             
            }
        }
    }
}
