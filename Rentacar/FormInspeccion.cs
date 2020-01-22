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
    public partial class FormInspeccion : Form
    {
        List<Chequeos> listaChequeos;
        List<AutoEntidad> listaAutos;
        List<DetalleInspeccionEntidad> di = new List<DetalleInspeccionEntidad>();
        int k = 2;
        InspeccionEntidad ie = new InspeccionEntidad();
        public FormInspeccion()
        {
            
            InitializeComponent();
            listaChequeos = RentacarNegocio.RentacarNegocio.CargarChequeos();
            listaAutos = RentacarNegocio.RentacarNegocio.CargarAutos(k);
            comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_autos.DropDownStyle = ComboBoxStyle.DropDownList;
            asignarChequeos();
            asignarAutos();
            ie.Id = RentacarNegocio.RentacarNegocio.ObtenerIdInspeccion();
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
                    comboBox_tipo.Items.Add(listaChequeos[i].Nombre);
                } 
        }
        private void asignarAutos()
        {

            for (int i = 0; i < listaAutos.Count; i++)
            {
                comboBox_autos.Items.Add(listaAutos[i].Id);
            }
        }

        private void buttonConfirmarAlquiler_Click(object sender, EventArgs e)
        {
            DetalleInspeccionEntidad d = new DetalleInspeccionEntidad();
            d.examinacion = comboBox_Examinacion.Text;
            foreach (var item in listaChequeos)
            {
                if (item.Nombre == comboBox_tipo.Text)
                    d.id_chequeo = item.Id;
            }
            d.id_inspeccion = ie.Id;
            bool existe = false ;
            foreach (var item in di)
            {
                if (d.id_chequeo == item.id_chequeo)
                    existe = true;
            }
            if (existe == true)
                MessageBox.Show("EL chequeo ya se realizo");
            else
            {
                di.Add(d);
                RentacarNegocio.RentacarNegocio.insertarDetalleInspeccion(d);
                Inspecciones.DataSource = null;
                Inspecciones.DataSource = di;
                limpiarProducto();
            }
        }

        private void limpiarProducto()
        {
            comboBox_Examinacion.Text = "";
            comboBox_tipo.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listaAutos)
            {
                if (item.Id == comboBox_autos.Text)
                    textBox_Nombre.Text = item.Nombre;
            }
        }

        private void button_Continuar_Click(object sender, EventArgs e)
        {
            InspeccionEntidad i = new InspeccionEntidad();
            i.Id_Auto = comboBox_autos.Text;
            i.Fecha = dateTimePicker.Value;
            RentacarNegocio.RentacarNegocio.insertarInspeccion(i);
            bool mantenimiento = false;
            foreach (var item in di)
            {
                if (item.examinacion == "Necesita Mantenimiento")
                    mantenimiento = true;

            }
            if (mantenimiento== true)
            {
                MessageBox.Show("Necesita Un Mantenimiento");
                RentacarNegocio.RentacarNegocio.ActualizarEstadoAuto(i.Id_Auto, 3);
            }
            else
            {
                MessageBox.Show("El vehivulo esta disponible");
                RentacarNegocio.RentacarNegocio.ActualizarEstadoAuto(i.Id_Auto, 1);
            }
        }
    }
}
