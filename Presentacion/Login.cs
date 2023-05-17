using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Presentacion.Formularios;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // ocultar el formulario de inicio de sesión
            RegistrarUsuarios registrarForm = new RegistrarUsuarios(); // instancia del formulario "Registrar"
            registrarForm.Show(); // mostrar el formulario "Registrar"
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var loginValido = usuario.LoginUsuario(txtUsuario.Text,txtContraseña.Text);

                    if (loginValido == true)
                    {
                        MenuPrincipal menuPrincipal = new MenuPrincipal();
                        menuPrincipal.Show();
                        menuPrincipal.FormClosed += Logout;//SOBRECARGA
                        this.Hide();
                    }
                    else
                    {
                        msgError("El usuario o contraeña es incorrecto\n Por favor verifique");
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingresa tu contraseña");
                }
            }
            else
            {
                msgError("Por favor ingresa tu nombre de usuario");            
            }

        }

        private void msgError(string msg)//metodo y firma
        {
            lblMensajeError.Text = msg;
            lblMensajeError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            lblMensajeError.Visible=false;
            this.Show();
            txtUsuario.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
