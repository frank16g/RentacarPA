namespace Rentacar
{
    partial class FormAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuto));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.textBox_Disponibilidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Color = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAgregar = new System.Windows.Forms.PictureBox();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Año = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Continuar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.comboBox_Categoria);
            this.groupBox2.Controls.Add(this.comboBox_Marca);
            this.groupBox2.Controls.Add(this.textBox_Disponibilidad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Color);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBoxAgregar);
            this.groupBox2.Controls.Add(this.textBox_Placa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Año);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox_Km);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Nombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(967, 469);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "`";
            // 
            // comboBox_Categoria
            // 
            this.comboBox_Categoria.FormattingEnabled = true;
            this.comboBox_Categoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox_Categoria.Location = new System.Drawing.Point(316, 85);
            this.comboBox_Categoria.Name = "comboBox_Categoria";
            this.comboBox_Categoria.Size = new System.Drawing.Size(339, 32);
            this.comboBox_Categoria.TabIndex = 22;
            this.comboBox_Categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categoria_SelectedIndexChanged);
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(316, 138);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(339, 32);
            this.comboBox_Marca.TabIndex = 21;
            // 
            // textBox_Disponibilidad
            // 
            this.textBox_Disponibilidad.Location = new System.Drawing.Point(316, 421);
            this.textBox_Disponibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Disponibilidad.Name = "textBox_Disponibilidad";
            this.textBox_Disponibilidad.ReadOnly = true;
            this.textBox_Disponibilidad.Size = new System.Drawing.Size(339, 29);
            this.textBox_Disponibilidad.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(73, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Disponibilidad";
            // 
            // textBox_Color
            // 
            this.textBox_Color.Location = new System.Drawing.Point(316, 373);
            this.textBox_Color.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Color.Name = "textBox_Color";
            this.textBox_Color.ReadOnly = true;
            this.textBox_Color.Size = new System.Drawing.Size(339, 29);
            this.textBox_Color.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(795, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxAgregar
            // 
            this.pictureBoxAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAgregar.Image")));
            this.pictureBoxAgregar.Location = new System.Drawing.Point(762, 146);
            this.pictureBoxAgregar.Name = "pictureBoxAgregar";
            this.pictureBoxAgregar.Size = new System.Drawing.Size(124, 108);
            this.pictureBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAgregar.TabIndex = 16;
            this.pictureBoxAgregar.TabStop = false;
            this.pictureBoxAgregar.Click += new System.EventHandler(this.pictureBoxAgregar_Click);
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.Location = new System.Drawing.Point(316, 36);
            this.textBox_Placa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(161, 29);
            this.textBox_Placa.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(73, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Año";
            // 
            // textBox_Año
            // 
            this.textBox_Año.Location = new System.Drawing.Point(316, 318);
            this.textBox_Año.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Año.Name = "textBox_Año";
            this.textBox_Año.ReadOnly = true;
            this.textBox_Año.Size = new System.Drawing.Size(339, 29);
            this.textBox_Año.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(73, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Color";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // textBox_Km
            // 
            this.textBox_Km.Location = new System.Drawing.Point(316, 252);
            this.textBox_Km.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.ReadOnly = true;
            this.textBox_Km.Size = new System.Drawing.Size(339, 29);
            this.textBox_Km.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(73, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Km";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(316, 194);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(339, 29);
            this.textBox_Nombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(73, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(73, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(73, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categotria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa";
            // 
            // button_Continuar
            // 
            this.button_Continuar.Location = new System.Drawing.Point(732, 498);
            this.button_Continuar.Name = "button_Continuar";
            this.button_Continuar.Size = new System.Drawing.Size(101, 35);
            this.button_Continuar.TabIndex = 19;
            this.button_Continuar.Text = "Continuar";
            this.button_Continuar.UseVisualStyleBackColor = true;
            this.button_Continuar.Visible = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(555, 498);
            this.Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(131, 37);
            this.Guardar.TabIndex = 18;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Visible = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.button_Continuar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAuto";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxAgregar;
        private System.Windows.Forms.TextBox textBox_Placa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Año;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Km;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Color;
        private System.Windows.Forms.TextBox textBox_Disponibilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Continuar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ComboBox comboBox_Categoria;
        private System.Windows.Forms.ComboBox comboBox_Marca;
    }
}