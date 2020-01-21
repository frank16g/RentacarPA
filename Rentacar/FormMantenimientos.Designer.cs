namespace Rentacar
{
    partial class FormMantenimientos
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label2222 = new System.Windows.Forms.Label();
            this.label333 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.mantenimientos = new System.Windows.Forms.DataGridView();
            this.label1111 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(235, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 37);
            this.label4.TabIndex = 42;
            this.label4.Text = "MANTENIMIENTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(56, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 10);
            this.panel1.TabIndex = 41;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "A (Bronze)",
            "B (Platinum)",
            "C (Gold)",
            "D (Premiun)"});
            this.comboBoxClase.Location = new System.Drawing.Point(300, 111);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClase.TabIndex = 37;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(519, 111);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 38;
            // 
            // label2222
            // 
            this.label2222.AutoSize = true;
            this.label2222.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2222.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2222.Location = new System.Drawing.Point(247, 108);
            this.label2222.Name = "label2222";
            this.label2222.Size = new System.Drawing.Size(47, 22);
            this.label2222.TabIndex = 39;
            this.label2222.Text = "Clase";
            // 
            // label333
            // 
            this.label333.AutoSize = true;
            this.label333.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label333.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label333.Location = new System.Drawing.Point(462, 108);
            this.label333.Name = "label333";
            this.label333.Size = new System.Drawing.Size(51, 22);
            this.label333.TabIndex = 40;
            this.label333.Text = "Marca";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(114, 111);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 20);
            this.tbid.TabIndex = 36;
            // 
            // mantenimientos
            // 
            this.mantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mantenimientos.Location = new System.Drawing.Point(47, 153);
            this.mantenimientos.Name = "mantenimientos";
            this.mantenimientos.Size = new System.Drawing.Size(707, 221);
            this.mantenimientos.TabIndex = 35;
            // 
            // label1111
            // 
            this.label1111.AutoSize = true;
            this.label1111.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1111.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1111.Location = new System.Drawing.Point(84, 108);
            this.label1111.Name = "label1111";
            this.label1111.Size = new System.Drawing.Size(24, 22);
            this.label1111.TabIndex = 44;
            this.label1111.Text = "ID";
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Image = global::Rentacar.Properties.Resources.button;
            this.btnnuevo.Location = new System.Drawing.Point(565, 395);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 43;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // FormMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1111);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label2222);
            this.Controls.Add(this.label333);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.mantenimientos);
            this.Name = "FormMantenimientos";
            this.Text = "FormMantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxClase;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label2222;
        private System.Windows.Forms.Label label333;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.DataGridView mantenimientos;
        private System.Windows.Forms.Label label1111;
    }
}