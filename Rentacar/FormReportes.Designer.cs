namespace Rentacar
{
    partial class FormReportes
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
            this.buttonAutosMarca = new System.Windows.Forms.Button();
            this.buttonGananciasMarca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAutosMarca
            // 
            this.buttonAutosMarca.Location = new System.Drawing.Point(174, 190);
            this.buttonAutosMarca.Name = "buttonAutosMarca";
            this.buttonAutosMarca.Size = new System.Drawing.Size(120, 23);
            this.buttonAutosMarca.TabIndex = 0;
            this.buttonAutosMarca.Text = "Autos por Marca";
            this.buttonAutosMarca.UseVisualStyleBackColor = true;
            this.buttonAutosMarca.Click += new System.EventHandler(this.buttonAutosMarca_Click);
            // 
            // buttonGananciasMarca
            // 
            this.buttonGananciasMarca.Location = new System.Drawing.Point(326, 190);
            this.buttonGananciasMarca.Name = "buttonGananciasMarca";
            this.buttonGananciasMarca.Size = new System.Drawing.Size(120, 23);
            this.buttonGananciasMarca.TabIndex = 1;
            this.buttonGananciasMarca.Text = "Ganancias  por Marca";
            this.buttonGananciasMarca.UseVisualStyleBackColor = true;
            this.buttonGananciasMarca.Click += new System.EventHandler(this.buttonGananciasMarca_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar Reserva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGananciasMarca);
            this.Controls.Add(this.buttonAutosMarca);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAutosMarca;
        private System.Windows.Forms.Button buttonGananciasMarca;
        private System.Windows.Forms.Button button1;
    }
}