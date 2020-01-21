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
       public UsuarioEntidad usuarioSesion;
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
            int numeroAlquiler = RentacarNegocio.RentacarNegocio.DevolverNumeroReservas();
            numeroAlquiler += 1;
            alquiler.id = numeroAlquiler;
            textBoxCodAlquiler.Text = alquiler.id.ToString();

            if (numeroAlquiler < 0)
            {
                Application.Exit();
            }



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
            //string path = "C:\\Proyectos\\Programacion Avanzada\\Proyecto Final 2\\Rentacar\\Resources\\delete.png";
            //pictureBox4.Image = Image.FromFile(path);
        }

        private void LlamarFormularioSeleccionarAutos()
        {
            try
            {
                FormSeleccionarAuto formSeleccionarAuto = new FormSeleccionarAuto();
                formSeleccionarAuto.ShowDialog();
                
                textBoxModelo.Text = formSeleccionarAuto.autoSeleccionado.Nombre + " Marca: " + formSeleccionarAuto.Marca  + "Modelo"+ formSeleccionarAuto.autoSeleccionado.Nombre+  " Placa: " + formSeleccionarAuto.autoSeleccionado.Id;
                textBoxClase.Text = formSeleccionarAuto.autoSeleccionado.Id_Categoria.ToString();

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
                alquiler.idUsuario = usuarioSesion.Id;
                alquiler = RentacarNegocio.RentacarNegocio.GuardarAlquiler(alquiler);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Simule el alquiler y cargue los documentos");
            }
                
                
           
            
        }

        private void LimpiarCampos()
        {
            int numeroReservas = RentacarNegocio.RentacarNegocio.DevolverNumeroReservas();
            numeroReservas++;
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxRuc.Text = "";
            textBoxModelo.Text = "";
            textBoxClase.Text = "";
            textBoxSeguro.Text = "";
            textBoxIva.Text = "";
            textBoxSubtotal.Text = "";
            textBoxTotal.Text = "";
            textBoxCodAlquiler.Text = numeroReservas.ToString();
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
            textBoxSeguro.Text = formServicios.ServicioSelecionado.Nombre;
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
            RentacarNegocio.RentacarNegocio.ActualizarEstadoAuto(alquiler.idAuto,0);
            simulacion = true;
           
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

            e.Graphics.DrawString("Rentacar", fuenteCabecera, Brushes.Black, 280, 30);          
            e.Graphics.DrawString("Fecha", fuenteTitulo, Brushes.Black, 50, a);
            e.Graphics.DrawString(DateTime.Now.ToString(), fuenteCuerpo, Brushes.Black, 200, a + 5);

            e.Graphics.DrawString("Nombre", fuenteTitulo, Brushes.Black, 50, a += b);
            e.Graphics.DrawString(clienteAlquiler.Nombre + " " + clienteAlquiler.Apellido, fuenteCuerpo, Brushes.Black, 200, a + 5);

            e.Graphics.DrawString("Ci/Ruc", fuenteTitulo, Brushes.Black, 50, a += b);
            e.Graphics.DrawString(clienteAlquiler.Cedula, fuenteCuerpo, Brushes.Black, 200, a + 5);

            a += 60;

            e.Graphics.DrawString("Nombre", fuenteTitulo, Brushes.Black, 50, a += b);
            e.Graphics.DrawString("Cantidad", fuenteTitulo, Brushes.Black, 300, a);
            e.Graphics.DrawString("Precio / U", fuenteTitulo, Brushes.Black, 450, a);
      

            foreach (var item in alquiler.listaServicios)
            {
                e.Graphics.DrawString(item.Nombre, fuenteCuerpo, Brushes.Black, 50, a += b);
                e.Graphics.DrawString("1", fuenteCuerpo, Brushes.Black, 300, a);
                e.Graphics.DrawString(item.Costo.ToString(), fuenteCuerpo, Brushes.Black, 450, a);
             
            }
            a += 60;

            e.Graphics.DrawString("Subtotal", fuenteTitulo, Brushes.Black, 500, a += b);
            e.Graphics.DrawString(alquiler.subtotal.ToString("C2"), fuenteCuerpo, Brushes.Black, 650, a + 5);

            e.Graphics.DrawString("Iva", fuenteTitulo, Brushes.Black, 500, a += b);
            e.Graphics.DrawString(alquiler.iva.ToString("C2"), fuenteCuerpo, Brushes.Black, 650, a + 5);

            e.Graphics.DrawString("Total", fuenteTitulo, Brushes.Black, 500, a += b);
            e.Graphics.DrawString(alquiler.total.ToString("C2"), fuenteCuerpo, Brushes.Black, 650, a + 5);


            //Pie de Pagina
            e.Graphics.DrawString("Copyright(©) r, Todos los derechos reservados. David Constante 0961701208 davidconstante.uta@gmail.com", fuentePieDePagina, Brushes.Black, 15, 1130);


        }

        private List<object> GenerarCodigos(string texto)
        {
            GeneratedBarcode codigoQr;
       
            codigoQr = null;
    
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
            alquiler.idCliente = clienteAlquiler.id;
            
            textBoxApellido.Text = clienteAlquiler.Apellido;
            textBoxRuc.Text = clienteAlquiler.Cedula;
            textBoxNombre.Text = clienteAlquiler.Nombre;


            //alquiler.idCliente =  formCliente.clienteSeleccionados
        }

        private void buttonContrato_Click(object sender, EventArgs e)
        {
            if (simulacion)
            {
                GestionarContrato();
            }
            else
            {
                MessageBox.Show("Genere la Simulación");
            }

        }

        private void GestionarContrato()
        {

           RentacarNegocio.RentacarNegocio.GenerarContrato(alquiler);


            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {

                    
                        byte[] contrato = File.ReadAllBytes(dlg.FileName);
                        alquiler.contratoFirmado = contrato;
                        simulacion = true;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione un archivo válido.");
            }

           
           


        }


    }
}
