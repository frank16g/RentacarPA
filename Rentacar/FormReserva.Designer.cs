﻿namespace Rentacar
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
            this.buttonServicios = new System.Windows.Forms.Button();
            this.textBoxCodAlquiler = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.dateTimePickerRecogida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxRuc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxClase = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonConfirmarAlquiler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSimularAlquiler = new System.Windows.Forms.Button();
            this.buttonFacturar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Recogida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Devolución";
            // 
            // buttonServicios
            // 
            this.buttonServicios.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonServicios.Image = global::Rentacar.Properties.Resources.button;
            this.buttonServicios.Location = new System.Drawing.Point(355, 39);
            this.buttonServicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonServicios.Name = "buttonServicios";
            this.buttonServicios.Size = new System.Drawing.Size(132, 30);
            this.buttonServicios.TabIndex = 36;
            this.buttonServicios.Text = "ServiciosExtra";
            this.buttonServicios.UseVisualStyleBackColor = true;
            this.buttonServicios.Click += new System.EventHandler(this.buttonServicios_Click);
            // 
            // textBoxCodAlquiler
            // 
            this.textBoxCodAlquiler.Location = new System.Drawing.Point(249, 53);
            this.textBoxCodAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodAlquiler.Name = "textBoxCodAlquiler";
            this.textBoxCodAlquiler.ReadOnly = true;
            this.textBoxCodAlquiler.Size = new System.Drawing.Size(63, 22);
            this.textBoxCodAlquiler.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 26);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cod. Alquiler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(41, 78);
            this.textBoxModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(324, 22);
            this.textBoxModelo.TabIndex = 26;
            // 
            // dateTimePickerRecogida
            // 
            this.dateTimePickerRecogida.Location = new System.Drawing.Point(39, 78);
            this.dateTimePickerRecogida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerRecogida.Name = "dateTimePickerRecogida";
            this.dateTimePickerRecogida.Size = new System.Drawing.Size(225, 22);
            this.dateTimePickerRecogida.TabIndex = 23;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(285, 78);
            this.dateTimePickerDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(225, 22);
            this.dateTimePickerDevolucion.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(543, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total";
            // 
            // textBoxIva
            // 
            this.textBoxIva.Location = new System.Drawing.Point(355, 36);
            this.textBoxIva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.ReadOnly = true;
            this.textBoxIva.Size = new System.Drawing.Size(132, 22);
            this.textBoxIva.TabIndex = 18;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(609, 36);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(132, 22);
            this.textBoxTotal.TabIndex = 17;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(132, 36);
            this.textBoxSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(132, 22);
            this.textBoxSubtotal.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "IVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 11;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(33, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "Cédula";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(259, 44);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(355, 46);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(181, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(564, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 26);
            this.label15.TabIndex = 4;
            this.label15.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(663, 44);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.ReadOnly = true;
            this.textBoxApellido.Size = new System.Drawing.Size(181, 22);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Location = new System.Drawing.Point(119, 44);
            this.textBoxRuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRuc.Mask = "0000000000";
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(112, 22);
            this.textBoxRuc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.buttonConfirmarAlquiler);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonFacturar);
            this.groupBox1.Controls.Add(this.textBoxCodAlquiler);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Location = new System.Drawing.Point(-23, -15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1309, 649);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonServicios);
            this.groupBox6.Location = new System.Drawing.Point(71, 375);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(537, 94);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Servicios Extra";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.textBoxClase);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.textBoxModelo);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(639, 233);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(575, 236);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del carro";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(41, 121);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(276, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // textBoxClase
            // 
            this.textBoxClase.Location = new System.Drawing.Point(392, 78);
            this.textBoxClase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClase.Name = "textBoxClase";
            this.textBoxClase.ReadOnly = true;
            this.textBoxClase.Size = new System.Drawing.Size(48, 22);
            this.textBoxClase.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rentacar.Properties.Resources.grid;
            this.pictureBox2.Location = new System.Drawing.Point(392, 143);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Clase";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePickerDevolucion);
            this.groupBox4.Controls.Add(this.dateTimePickerRecogida);
            this.groupBox4.Location = new System.Drawing.Point(71, 233);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(537, 123);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempo de alquiler";
            // 
            // buttonConfirmarAlquiler
            // 
            this.buttonConfirmarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarAlquiler.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonConfirmarAlquiler.Image = global::Rentacar.Properties.Resources.button;
            this.buttonConfirmarAlquiler.Location = new System.Drawing.Point(1080, 503);
            this.buttonConfirmarAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirmarAlquiler.Name = "buttonConfirmarAlquiler";
            this.buttonConfirmarAlquiler.Size = new System.Drawing.Size(133, 28);
            this.buttonConfirmarAlquiler.TabIndex = 35;
            this.buttonConfirmarAlquiler.Text = "Confirmar Alquiler";
            this.buttonConfirmarAlquiler.UseVisualStyleBackColor = true;
            this.buttonConfirmarAlquiler.Click += new System.EventHandler(this.buttonConfirmarAlquiler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxRuc);
            this.groupBox2.Location = new System.Drawing.Point(71, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(988, 105);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rentacar.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(887, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.rentacar;
            this.pictureBox1.Location = new System.Drawing.Point(1096, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Controls.Add(this.textBoxSubtotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxTotal);
            this.groupBox3.Controls.Add(this.textBoxIva);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.buttonSimularAlquiler);
            this.groupBox3.Location = new System.Drawing.Point(71, 489);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(969, 86);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores Factura";
            // 
            // buttonSimularAlquiler
            // 
            this.buttonSimularAlquiler.BackColor = System.Drawing.Color.Transparent;
            this.buttonSimularAlquiler.BackgroundImage = global::Rentacar.Properties.Resources.button;
            this.buttonSimularAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSimularAlquiler.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonSimularAlquiler.Image = global::Rentacar.Properties.Resources.button;
            this.buttonSimularAlquiler.Location = new System.Drawing.Point(801, 33);
            this.buttonSimularAlquiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSimularAlquiler.Name = "buttonSimularAlquiler";
            this.buttonSimularAlquiler.Size = new System.Drawing.Size(133, 28);
            this.buttonSimularAlquiler.TabIndex = 21;
            this.buttonSimularAlquiler.Text = "Simular Alquiler";
            this.buttonSimularAlquiler.UseVisualStyleBackColor = false;
            this.buttonSimularAlquiler.Click += new System.EventHandler(this.buttonSimularAlquiler_Click);
            // 
            // buttonFacturar
            // 
            this.buttonFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFacturar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFacturar.Image = global::Rentacar.Properties.Resources.button;
            this.buttonFacturar.Location = new System.Drawing.Point(1080, 546);
            this.buttonFacturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFacturar.Name = "buttonFacturar";
            this.buttonFacturar.Size = new System.Drawing.Size(133, 28);
            this.buttonFacturar.TabIndex = 22;
            this.buttonFacturar.Text = "Facturar";
            this.buttonFacturar.UseVisualStyleBackColor = true;
            this.buttonFacturar.Click += new System.EventHandler(this.buttonFacturar_Click);
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1249, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReserva";
            this.Text = "Reserva";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCodAlquiler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonConfirmarAlquiler;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonServicios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.MaskedTextBox textBoxRuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

