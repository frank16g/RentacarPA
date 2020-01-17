namespace Rentacar
{
    partial class FormAdmin
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
            this.buttonMantenimientos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMantenimientos
            // 
            this.buttonMantenimientos.Location = new System.Drawing.Point(257, 71);
            this.buttonMantenimientos.Name = "buttonMantenimientos";
            this.buttonMantenimientos.Size = new System.Drawing.Size(75, 23);
            this.buttonMantenimientos.TabIndex = 0;
            this.buttonMantenimientos.Text = "Iniciar";
            this.buttonMantenimientos.UseVisualStyleBackColor = true;
            this.buttonMantenimientos.Click += new System.EventHandler(this.buttonMantenimientos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestionar Mantenimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ver Reportes";
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(257, 136);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(75, 23);
            this.buttonReportes.TabIndex = 2;
            this.buttonReportes.Text = "Iniciar";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMantenimientos);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMantenimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReportes;
    }
}