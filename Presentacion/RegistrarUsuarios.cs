using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDatos;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Presentacion
{
    public partial class RegistrarUsuarios : Form
    {
        private readonly coneccionPublica conexion = new coneccionPublica();
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void txtRContraseña_TextChanged(object sender, EventArgs e)
        {
            txtRContraseña.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtRUsuario.Text.Trim();
            string password = txtRContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y contraseña válidos.");
                return;
            }

            // Verificar si el usuario ya existe
            coneccionPublica conexion = new coneccionPublica();
            if (conexion.ExisteUsuario(nombreUsuario))
            {
                MessageBox.Show("El usuario ya existe en la base de datos.");
                return;
            }

            // Si el usuario no existe, agregarlo a la base de datos
            using (MySqlConnection conn = conexion.GetConnection())//conexion mysql
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (Nombre_Usuario, Password_Usuario) VALUES (@nombreUsuario, @password)", conn);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@password", password);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Usuario agregado correctamente.");
                    txtRUsuario.Text = "";
                    txtRContraseña.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el usuario.");
                }
            }
        }
    }
}
