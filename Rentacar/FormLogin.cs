using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentacarEntidades;
using RentacarNegocio;

namespace Rentacar
{
    public partial class FormLogin : Form
    {
        UsuarioEntidad usuario;
        bool log;
        public FormLogin()
        {
            InitializeComponent();

            usuario = new UsuarioEntidad();
            textBoxContraseña.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AccederSistema();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccederSistema();
        }

        private void AccederSistema()
        {
            List<UsuarioEntidad> listaUsuarios = RentacarNegocio.RentacarNegocio.DevolverListadoUsuarios();


            foreach (var usr in listaUsuarios)
            {
                if (textBoxUsuario.Text == usr.Usuario && textBoxContraseña.Text == usr.Contraseña)
                {
                    log = true;
                    usuario = usr;
                }

            }

            if (log)
            {

                if (usuario.Usuario == "root")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.ShowDialog();
                    this.Close();

                }
                else
                {
                    FormReserva formReserva = new FormReserva();
                    formReserva.usuarioSesion = usuario;
                    formReserva.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");

                textBoxContraseña.Text = "";
            }
            
        }

    }
}
