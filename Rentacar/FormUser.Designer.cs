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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.buttonDevolucion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAlquilar.BackgroundImage")));
            this.buttonAlquilar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlquilar.Image")));
            this.buttonAlquilar.Location = new System.Drawing.Point(143, 156);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlquilar.TabIndex = 0;
            this.buttonAlquilar.Text = "Alquilar";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // buttonDevolucion
            // 
            this.buttonDevolucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDevolucion.BackgroundImage")));
            this.buttonDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevolucion.Image")));
            this.buttonDevolucion.Location = new System.Drawing.Point(394, 156);
            this.buttonDevolucion.Name = "buttonDevolucion";
            this.buttonDevolucion.Size = new System.Drawing.Size(75, 23);
            this.buttonDevolucion.TabIndex = 1;
            this.buttonDevolucion.Text = "Inspeccion";
            this.buttonDevolucion.UseVisualStyleBackColor = true;
            this.buttonDevolucion.Click += new System.EventHandler(this.buttonDevolucion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentacar.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(134, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rentacar.Properties.Resources.process__1_;
            this.pictureBox2.Location = new System.Drawing.Point(385, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(610, 253);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDevolucion);
            this.Controls.Add(this.buttonAlquilar);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.Button buttonDevolucion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}