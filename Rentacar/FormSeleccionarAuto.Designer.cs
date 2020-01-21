namespace Rentacar
{
    partial class FormSeleccionarAuto
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
            this.dataGridViewAutos = new System.Windows.Forms.DataGridView();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAutos
            // 
            this.dataGridViewAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutos.Location = new System.Drawing.Point(65, 91);
            this.dataGridViewAutos.Name = "dataGridViewAutos";
            this.dataGridViewAutos.Size = new System.Drawing.Size(641, 220);
            this.dataGridViewAutos.TabIndex = 25;
            this.dataGridViewAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutos_CellClick);
            this.dataGridViewAutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutos_CellContentClick);
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "A (Bronze)",
            "B (Platinum)",
            "C (Gold)",
            "D (Premiun)"});
            this.comboBoxClase.Location = new System.Drawing.Point(164, 45);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClase.TabIndex = 0;
            this.comboBoxClase.SelectedIndexChanged += new System.EventHandler(this.comboBoxClase_SelectedIndexChanged);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(383, 45);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 1;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(326, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clase";
            // 
            // FormSeleccionarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(764, 346);
            this.Controls.Add(this.dataGridViewAutos);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormSeleccionarAuto";
            this.Text = "FormSeleccionarAuto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAutos;
        private System.Windows.Forms.ComboBox comboBoxClase;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}