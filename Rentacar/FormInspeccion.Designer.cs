namespace Rentacar
{
    partial class FormInspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInspeccion));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Inspecciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Examinacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfirmarAlquiler = new System.Windows.Forms.Button();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_autos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button_Continuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inspecciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha";
            // 
            // Inspecciones
            // 
            this.Inspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inspecciones.Location = new System.Drawing.Point(57, 204);
            this.Inspecciones.Margin = new System.Windows.Forms.Padding(4);
            this.Inspecciones.Name = "Inspecciones";
            this.Inspecciones.RowHeadersWidth = 51;
            this.Inspecciones.Size = new System.Drawing.Size(841, 272);
            this.Inspecciones.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Examinacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonConfirmarAlquiler);
            this.groupBox1.Controls.Add(this.comboBox_tipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 98);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checkeos";
            // 
            // comboBox_Examinacion
            // 
            this.comboBox_Examinacion.FormattingEnabled = true;
            this.comboBox_Examinacion.Items.AddRange(new object[] {
            "Todo  Correcto",
            "Necesita Mantenimiento"});
            this.comboBox_Examinacion.Location = new System.Drawing.Point(317, 50);
            this.comboBox_Examinacion.Name = "comboBox_Examinacion";
            this.comboBox_Examinacion.Size = new System.Drawing.Size(220, 24);
            this.comboBox_Examinacion.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Examinacion";
            // 
            // buttonConfirmarAlquiler
            // 
            this.buttonConfirmarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarAlquiler.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonConfirmarAlquiler.Image = global::Rentacar.Properties.Resources.button;
            this.buttonConfirmarAlquiler.Location = new System.Drawing.Point(601, 46);
            this.buttonConfirmarAlquiler.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmarAlquiler.Name = "buttonConfirmarAlquiler";
            this.buttonConfirmarAlquiler.Size = new System.Drawing.Size(133, 28);
            this.buttonConfirmarAlquiler.TabIndex = 36;
            this.buttonConfirmarAlquiler.Text = "+";
            this.buttonConfirmarAlquiler.UseVisualStyleBackColor = true;
            this.buttonConfirmarAlquiler.Click += new System.EventHandler(this.buttonConfirmarAlquiler_Click);
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(57, 50);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(220, 24);
            this.comboBox_tipo.TabIndex = 1;
            this.comboBox_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo";
            // 
            // comboBox_autos
            // 
            this.comboBox_autos.FormattingEnabled = true;
            this.comboBox_autos.Location = new System.Drawing.Point(122, 36);
            this.comboBox_autos.Name = "comboBox_autos";
            this.comboBox_autos.Size = new System.Drawing.Size(225, 24);
            this.comboBox_autos.TabIndex = 31;
            this.comboBox_autos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(566, 36);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(166, 22);
            this.textBox_Nombre.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Nombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_autos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(68, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 85);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(144, 492);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(399, 22);
            this.dateTimePicker.TabIndex = 35;
            // 
            // button_Continuar
            // 
            this.button_Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Continuar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_Continuar.Image = ((System.Drawing.Image)(resources.GetObject("button_Continuar.Image")));
            this.button_Continuar.Location = new System.Drawing.Point(685, 490);
            this.button_Continuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Continuar.Name = "button_Continuar";
            this.button_Continuar.Size = new System.Drawing.Size(133, 27);
            this.button_Continuar.TabIndex = 36;
            this.button_Continuar.Text = "Continuar";
            this.button_Continuar.UseVisualStyleBackColor = true;
            this.button_Continuar.Click += new System.EventHandler(this.button_Continuar_Click);
            // 
            // FormInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1088, 528);
            this.Controls.Add(this.button_Continuar);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Inspecciones);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Name = "FormInspeccion";
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.Inspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inspecciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Inspecciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_autos;
        private System.Windows.Forms.ComboBox comboBox_Examinacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirmarAlquiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_Continuar;
    }
}