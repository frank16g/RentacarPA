namespace Rentacar
{
    partial class FormReserva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonServicios = new System.Windows.Forms.Button();
            this.buttonConfirmarAlquiler = new System.Windows.Forms.Button();
            this.textBoxCodAlquiler = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonFacturar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSimularAlquiler = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxClase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.buttonSeleccioanrAuto = new System.Windows.Forms.Button();
            this.dateTimePickerRecogida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.buttonBorrarCliente = new System.Windows.Forms.Button();
            this.textBoxRuc = new System.Windows.Forms.MaskedTextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Recogida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Devolución";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.buttonServicios);
            this.groupBox2.Controls.Add(this.buttonConfirmarAlquiler);
            this.groupBox2.Controls.Add(this.textBoxCodAlquiler);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.buttonFacturar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.buttonSimularAlquiler);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxIva);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSubtotal);
            this.groupBox2.Controls.Add(this.textBoxClase);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxModelo);
            this.groupBox2.Controls.Add(this.textBoxMarca);
            this.groupBox2.Controls.Add(this.textBoxPlaca);
            this.groupBox2.Controls.Add(this.buttonSeleccioanrAuto);
            this.groupBox2.Controls.Add(this.dateTimePickerRecogida);
            this.groupBox2.Controls.Add(this.dateTimePickerDevolucion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(48, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 456);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Alquiler";
            // 
            // buttonServicios
            // 
            this.buttonServicios.Location = new System.Drawing.Point(21, 427);
            this.buttonServicios.Name = "buttonServicios";
            this.buttonServicios.Size = new System.Drawing.Size(100, 23);
            this.buttonServicios.TabIndex = 36;
            this.buttonServicios.Text = "ServiciosExtra";
            this.buttonServicios.UseVisualStyleBackColor = true;
            this.buttonServicios.Click += new System.EventHandler(this.buttonServicios_Click);
            // 
            // buttonConfirmarAlquiler
            // 
            this.buttonConfirmarAlquiler.Location = new System.Drawing.Point(39, 284);
            this.buttonConfirmarAlquiler.Name = "buttonConfirmarAlquiler";
            this.buttonConfirmarAlquiler.Size = new System.Drawing.Size(100, 23);
            this.buttonConfirmarAlquiler.TabIndex = 35;
            this.buttonConfirmarAlquiler.Text = "Confirmar Alquiler";
            this.buttonConfirmarAlquiler.UseVisualStyleBackColor = true;
            this.buttonConfirmarAlquiler.Click += new System.EventHandler(this.buttonConfirmarAlquiler_Click);
            // 
            // textBoxCodAlquiler
            // 
            this.textBoxCodAlquiler.Location = new System.Drawing.Point(110, 36);
            this.textBoxCodAlquiler.Name = "textBoxCodAlquiler";
            this.textBoxCodAlquiler.ReadOnly = true;
            this.textBoxCodAlquiler.Size = new System.Drawing.Size(48, 20);
            this.textBoxCodAlquiler.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cod. Alquiler";
            // 
            // buttonFacturar
            // 
            this.buttonFacturar.Location = new System.Drawing.Point(185, 330);
            this.buttonFacturar.Name = "buttonFacturar";
            this.buttonFacturar.Size = new System.Drawing.Size(100, 23);
            this.buttonFacturar.TabIndex = 22;
            this.buttonFacturar.Text = "Facturar";
            this.buttonFacturar.UseVisualStyleBackColor = true;
            this.buttonFacturar.Click += new System.EventHandler(this.buttonFacturar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Modelo";
            // 
            // buttonSimularAlquiler
            // 
            this.buttonSimularAlquiler.Location = new System.Drawing.Point(185, 283);
            this.buttonSimularAlquiler.Name = "buttonSimularAlquiler";
            this.buttonSimularAlquiler.Size = new System.Drawing.Size(100, 23);
            this.buttonSimularAlquiler.TabIndex = 21;
            this.buttonSimularAlquiler.Text = "Simular Alquiler";
            this.buttonSimularAlquiler.UseVisualStyleBackColor = true;
            this.buttonSimularAlquiler.Click += new System.EventHandler(this.buttonSimularAlquiler_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Marca";
            // 
            // textBoxIva
            // 
            this.textBoxIva.Location = new System.Drawing.Point(349, 324);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.ReadOnly = true;
            this.textBoxIva.Size = new System.Drawing.Size(100, 20);
            this.textBoxIva.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Placa";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(349, 375);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Clase";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(349, 279);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubtotal.TabIndex = 16;
            // 
            // textBoxClase
            // 
            this.textBoxClase.Location = new System.Drawing.Point(21, 212);
            this.textBoxClase.Name = "textBoxClase";
            this.textBoxClase.ReadOnly = true;
            this.textBoxClase.Size = new System.Drawing.Size(37, 20);
            this.textBoxClase.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "SUBTOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Auto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "IVA";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(230, 212);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(97, 20);
            this.textBoxModelo.TabIndex = 26;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(148, 212);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(76, 20);
            this.textBoxMarca.TabIndex = 25;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(83, 212);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.ReadOnly = true;
            this.textBoxPlaca.Size = new System.Drawing.Size(56, 20);
            this.textBoxPlaca.TabIndex = 23;
            // 
            // buttonSeleccioanrAuto
            // 
            this.buttonSeleccioanrAuto.Location = new System.Drawing.Point(355, 183);
            this.buttonSeleccioanrAuto.Name = "buttonSeleccioanrAuto";
            this.buttonSeleccioanrAuto.Size = new System.Drawing.Size(79, 49);
            this.buttonSeleccioanrAuto.TabIndex = 23;
            this.buttonSeleccioanrAuto.Text = "Seleccionar Auto";
            this.buttonSeleccioanrAuto.UseVisualStyleBackColor = true;
            this.buttonSeleccioanrAuto.Click += new System.EventHandler(this.buttonSeleccioanrAuto_Click);
            // 
            // dateTimePickerRecogida
            // 
            this.dateTimePickerRecogida.Location = new System.Drawing.Point(22, 115);
            this.dateTimePickerRecogida.Name = "dateTimePickerRecogida";
            this.dateTimePickerRecogida.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerRecogida.TabIndex = 23;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(262, 115);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerDevolucion.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.textBoxFechaNacimiento);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.buttonAgregarCliente);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.buttonBorrarCliente);
            this.groupBox1.Controls.Add(this.textBoxRuc);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(561, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 456);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(125, 322);
            this.textBoxFechaNacimiento.Mask = "00/00/0000";
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(70, 20);
            this.textBoxFechaNacimiento.TabIndex = 18;
            this.textBoxFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 329);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Fecha Nacimiento";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(125, 281);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(137, 20);
            this.textBoxMail.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "E Mail";
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.BackgroundImage = global::Rentacar.Properties.Resources.AgregarCliente;
            this.buttonAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregarCliente.Location = new System.Drawing.Point(287, 19);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(61, 59);
            this.buttonAgregarCliente.TabIndex = 14;
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(125, 236);
            this.textBoxTelefono.Mask = "0000000000";
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(85, 20);
            this.textBoxTelefono.TabIndex = 12;
            // 
            // buttonBorrarCliente
            // 
            this.buttonBorrarCliente.BackgroundImage = global::Rentacar.Properties.Resources.delete;
            this.buttonBorrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrarCliente.Location = new System.Drawing.Point(300, 166);
            this.buttonBorrarCliente.Name = "buttonBorrarCliente";
            this.buttonBorrarCliente.Size = new System.Drawing.Size(36, 33);
            this.buttonBorrarCliente.TabIndex = 11;
            this.buttonBorrarCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(125, 60);
            this.textBoxRuc.Mask = "0000000000";
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(85, 20);
            this.textBoxRuc.TabIndex = 0;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackgroundImage = global::Rentacar.Properties.Resources.search;
            this.buttonBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(287, 87);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(61, 59);
            this.buttonBuscarCliente.TabIndex = 10;
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(125, 194);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(137, 20);
            this.textBoxDireccion.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Direccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tel.";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(125, 148);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(137, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(125, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Nombre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Cédula";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(965, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormReserva";
            this.Text = "Reserva";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSimularAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecogida;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.Button buttonFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Button buttonSeleccioanrAuto;
        private System.Windows.Forms.TextBox textBoxClase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.MaskedTextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonBorrarCliente;
        private System.Windows.Forms.MaskedTextBox textBoxRuc;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCodAlquiler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox textBoxFechaNacimiento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonConfirmarAlquiler;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonServicios;
    }
}

