using AcessoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using Dominio.metodos;

namespace Presentacion.Formularios.Productos
{
    public partial class Agregar_Prodcutos : Form
    {
        public Agregar_Prodcutos()
        {
            InitializeComponent();
        }

        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string nombreProducto = txtNombreProducto.Text;
            int talla = (int)nudTalla.Value;
            decimal precio = 0;
            int cantidad = (int)nudCantidad.Value;

            // Obtener el proveedor seleccionado
            int proveedorId = (int)cbProveedoresP.SelectedValue;

            // Validar que los valores no estén vacíos o sean inválidos
            try
            {
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    throw new Exception("Por favor, ingrese el nombre del producto.");
                }

                if (talla < 1 || talla > 10)
                {
                    throw new Exception("Por favor, ingrese una talla válida (entre 1 y 10).");
                }

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    throw new Exception("Por favor, ingrese solo números en el precio.");
                }

                if (precio <= 0)
                {
                    throw new Exception("Por favor, ingrese un precio válido (mayor que 0).");
                }

                if (cantidad <= 0 || cantidad > 999)
                {
                    throw new Exception("Por favor, ingrese una cantidad válida (entre 1 y 999).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (nombreProducto.Length > 45)
            {
                MessageBox.Show("El nombre del producto no puede tener más de 45 caracteres.");
                return;
            }

            // Conectar con la base de datos
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())//llamando al metodo de la conexion
            {
                connection.Open();

                // Crear un nuevo comando para insertar el producto en la tabla de productos
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PRODUCTOS (Nombre_del_producto, Talla, Precio_del_producto, cantidad, Proveedor_id) VALUES (@nombreProducto, @talla, @precio, @cantidad, @proveedorId)";
                command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                command.Parameters.AddWithValue("@talla", talla);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@proveedorId", proveedorId);

                // Ejecutar el comando
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si se insertó el producto correctamente
                if (rowsAffected > 0)
                {
                    MessageBox.Show("¡Producto agregado correctamente!", "Agregado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Productos productos = (Productos)Application.OpenForms["Productos"];
                    productos.ActualizarTablaProductos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar agregar el producto.");
                }

                // Limpiar los controles
                txtNombreProducto.Text = "";
                nudTalla.Value = 0;
                txtPrecio.Text = "";
                nudCantidad.Value = 0;
                cbProveedoresP.SelectedIndex = -1;
            }
        }

        private void Agregar_Prodcutos_Load(object sender, EventArgs e)
        {
            // Conectar con la base de datos
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())//llamando al metodo de la conexion
            {
                connection.Open();

                // Crear un nuevo comando para obtener los proveedores
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT id_Proveedor, Nombre FROM Proveedores";

                // Crear un nuevo adaptador y llenar un DataTable con los datos de los proveedores
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable al ComboBox
                cbProveedoresP.DisplayMember = "Nombre";
                cbProveedoresP.ValueMember = "id_Proveedor";
                cbProveedoresP.DataSource = dataTable;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
