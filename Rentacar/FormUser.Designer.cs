namespace Rentacar
{
    partial class FormUser
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
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.buttonDevolucion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.Location = new System.Drawing.Point(216, 168);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlquilar.TabIndex = 0;
            this.buttonAlquilar.Text = "Iniciar";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // buttonDevolucion
            // 
            this.buttonDevolucion.Location = new System.Drawing.Point(467, 168);
            this.buttonDevolucion.Name = "buttonDevolucion";
            this.buttonDevolucion.Size = new System.Drawing.Size(75, 23);
            this.buttonDevolucion.TabIndex = 1;
            this.buttonDevolucion.Text = "Iniciar";
            this.buttonDevolucion.UseVisualStyleBackColor = true;
            this.buttonDevolucion.Click += new System.EventHandler(this.buttonDevolucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion de alquiler de Autos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestion devoluciones / Multas";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(749, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevolucion);
            this.Controls.Add(this.buttonAlquilar);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.Button buttonDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}