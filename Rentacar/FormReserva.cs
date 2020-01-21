using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronBarCode;

using RentacarNegocio;
using RentacarEntidades;
using System.IO;

namespace Rentacar
{
    public partial class FormReserva : Form
    {

        bool simulacion;

        AlquilerEntidad alquiler = new AlquilerEntidad();
        ClienteEntidad clienteAlquiler = new ClienteEntidad();
        int dias;

        public FormReserva()
        {
            InitializeComponent();
            MisComponenetesDeInicio();
        }

        private void MisComponenetesDeInicio()
        {
           
            dateTimePickerRecogida.Format = DateTimePickerFormat.Time;
            dateTimePickerDevolucion.Format = DateTimePickerFormat.Time;

            alquiler.listaServicios = new List<ServicioEntidad>();
            alquiler.id = RentacarNegocio.RentacarNegocio.DevolverNumeroReservas()+1;
            textBoxCodAlquiler.Text = alquiler.id.ToString();


            //Establecer usuario === Esto se puede borrar

            alquiler.idUsuario = 2;
            alquiler.idCliente = 1;
            alquiler.fechaReserva = Convert.ToDateTime("1/1/1777 12:00:00 AM ");
        }


        private void buttonSimularAlquiler_Click(object sender, EventArgs e)
        {
            
                SimularAlquiler();

        }

        private void SimularAlquiler()
        {
            alquiler.fechaRecogida = dateTimePickerRecogida.Value;
            alquiler.fechaDevolucion = dateTimePickerDevolucion.Value;

            TimeSpan timeSpan = alquiler.fechaDevolucion.AddMilliseconds(5000) - alquiler.fechaRecogida;
 
            dias = timeSpan.Days;

            if (dias>0)
            {

                if (textBoxClase.Text.Length != 0)
                {
                   
                    GenerarValoresPago(dias, Convert.ToInt32(textBoxClase.Text));
              

                    simulacion = true;
                }
                else
                {
                    MessageBox.Show("Seleccione un auto");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un rango de fechas válido");
            }

        }

        private void GenerarValoresPago(int dias, int clase)
        {
            switch (clase)
            {
                case 1:
                    alquiler.subtotal = dias * 50;
                    break;
                case 2:
                    alquiler.subtotal = dias * 100;
                    break;
                case 3:
                    alquiler.subtotal = dias * 150;
                    break;
                case 4:
                    alquiler.subtotal = dias * 200;
                    break;
            }

            if (alquiler.listaServicios.Count > 0)
            {
                foreach (var item in alquiler.listaServicios)
                {
                    alquiler.subtotal += item.Costo;
                        }
            }
            alquiler.iva = alquiler.subtotal * 0.12f;
            alquiler.total = alquiler.subtotal + alquiler.iva;

            textBoxSubtotal.Text = alquiler.subtotal.ToString("C2");
            textBoxIva.Text = alquiler.iva.ToString("C2");
            textBoxTotal.Text = alquiler.total.ToString("C2");
        }

        private void buttonSeleccioanrAuto_Click(object sender, EventArgs e)
        {
            LlamarFormularioSeleccionarAutos();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LlamarFormularioSeleccionarAutos();
            string path = "C:\\Proyectos\\Programacion Avanzada\\Proyecto Final 2\\Rentacar\\Resources\\delete.png";
            pictureBox4.Image = Image.FromFile(path);
        }

        private void LlamarFormularioSeleccionarAutos()
        {
            try
            {
                FormSeleccionarAuto formSeleccionarAuto = new FormSeleccionarAuto();
                formSeleccionarAuto.ShowDialog();
                textBoxClase.Text = formSeleccionarAuto.Clase.ToString();
                textBoxModelo.Text = formSeleccionarAuto.autoSeleccionado.Nombre +" MARCA: "+ formSeleccionarAuto.Marca
                    + " PLACA: "+formSeleccionarAuto.autoSeleccionado.Id +" CLASE: "+ formSeleccionarAuto.Clase.ToString();

                alquiler.idAuto = formSeleccionarAuto.autoSeleccionado.Id;
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione un Auto");
            }
        }

        private void buttonConfirmarAlquiler_Click(object sender, EventArgs e)
        {
            GuardarAlquiler();
           

        }

        private void GuardarAlquiler()
        {
            if (simulacion)
            {
                alquiler = RentacarNegocio.RentacarNegocio.GuardarAlquiler(alquiler);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Simule el alquiler");
            }
                
                
           
            
        }

        private void LimpiarCampos()
        {
            textBoxCodAlquiler.Text = RentacarNegocio.RentacarNegocio.DevolverNumeroReservas()+1.ToString();
            textBoxModelo.Text = "";

           dateTimePickerRecogida.Value = DateTime.Today.AddDays(-1);
            dateTimePickerDevolucion.Value = DateTime.Today.AddDays(-1);

            simulacion = false;

            alquiler = new AlquilerEntidad();

        }

        private void buttonServicios_Click(object sender, EventArgs e)
        {
            AgregarServicioAlAlquiler();

        }

        private void AgregarServicioAlAlquiler()
        {
            
                FormServicios formServicios = new FormServicios();
                formServicios.ShowDialog();
              
                alquiler.listaServicios.Add(formServicios.ServicioSelecionado);
                simulacion = false;

          

            
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            ImpirmirFactura();
        }

        private void ImpirmirFactura()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "Codigo Alquiler " + alquiler.id +  " Total: " + alquiler.total.ToString("C2");

            List<Object> listaCodigos = GenerarCodigos(texto);

      
            Image codigoQr = (Image)listaCodigos.ElementAt(0);

            int a = 250, b = 40;

            var logoRentaCar = new Bitmap(Properties.Resources.rentacar);

            Pen penBlack = new Pen(Color.Black, 2);
            Rectangle rectangle = new Rectangle(20, 500, 790, 600);
            e.Graphics.DrawRectangle(penBlack, rectangle);

            //Generar estilos de fuente
            Font fuenteCabecera = new Font("Calibri", 40, FontStyle.Bold);
            Font fuenteCabecera2 = new Font("Calibri", 30);
            Font fuenteTitulo = new Font("Times New Roman", 20, FontStyle.Bold);
            Font fuenteCuerpo = new Font("Times New Roman", 15);
            Font fuentePieDePagina = new Font("Times New Roman", 13);

            //Colocar Dibujos + Codigos
            //e.Graphics.DrawImage(codigoBarras, 200, 90, 550, 110);
            e.Graphics.DrawImage(logoRentaCar, 600, 70, 200, 200);
            e.Graphics.DrawImage(codigoQr, 599, 280, 175, 175);
            int y = 150;
            e.Graphics.DrawString("Cliente"+ clienteAlquiler.Nombre, fuenteCabecera, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString("Carro"+ textBoxModelo.Text, fuenteCabecera, Brushes.Black, 120, y);
            e.Graphics.DrawString("Dias" + dias, fuenteCabecera, Brushes.Black, 200, y);
            e.Graphics.DrawString("Subtotal" + alquiler.subtotal, fuenteCabecera, Brushes.Black, 300, y);
            e.Graphics.DrawString("IVA" + alquiler.iva, fuenteCabecera, Brushes.Black, 300, y);
            e.Graphics.DrawString("Total" + alquiler.total, fuenteCabecera, Brushes.Black, 300, y);
            y += 10;

        }

        private List<object> GenerarCodigos(string texto)
        {
            GeneratedBarcode codigoQr;
            GeneratedBarcode codigoBarras;

            codigoQr = null;
            codigoBarras = null;

            List<Object> listaCodigos = new List<object>();

            codigoQr = IronBarCode.BarcodeWriter.CreateBarcode(texto, BarcodeWriterEncoding.QRCode);
            codigoQr.SaveAsPng("codigoQr.png");
            Image codigoQrRecortado = codigoQr.Image;


            //codigoBarras = BarcodeWriter.CreateBarcode(texto, BarcodeWriterEncoding.PDF417);
            // Style the Barcode in a fluent LINQ style fashion
            //codigoBarras.ResizeTo(550, 110).SetMargins(5);


            //   Rectangle rectanguloOrigen = new Rectangle(0, 0, 800, 200);
            //Image CodigoDeBarrasRecortado = codigoBarras.Image;

            //listaCodigos.Add(CodigoDeBarrasRecortado);
            listaCodigos.Add(codigoQrRecortado);

            return listaCodigos;
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();

            clienteAlquiler = formCliente.clienteSeleccionados;

            textBoxApellido.Text = clienteAlquiler.Apellido;
            textBoxRuc.Text = clienteAlquiler.Cedula;
            textBoxNombre.Text = clienteAlquiler.Nombre;

            
            //alquiler.idCliente =  formCliente.clienteSeleccionados


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();

            clienteAlquiler = formCliente.clienteSeleccionados;

            textBoxApellido.Text = clienteAlquiler.Apellido;
            textBoxRuc.Text = clienteAlquiler.Cedula;
            textBoxNombre.Text = clienteAlquiler.Nombre;


            //alquiler.idCliente =  formCliente.clienteSeleccionados
        }
    }
}
